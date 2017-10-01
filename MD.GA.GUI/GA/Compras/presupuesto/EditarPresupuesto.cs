using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MD.GA.SERVICES;
using MD.GA.BE.Entidades;
using MD.GA.COMMOM;
using System.Globalization;
using System.Threading;
using System.Reflection;

namespace MD.GA.GUI.GA.Compras.presupuesto
{
    public partial class EditarPresupuesto : Form
    {
        
        Documento documento = null;
        IServiceAlmacen servicio = new ServiceAlmacen();
        private List<Area> listaArea;
        private List<Empresa> listaEmpresa;
        private List<Articulo> listaArticulo;
        private List<Proveedor> listaProveedor;
        private List<BANCO> listaBanco;
        private Documento docGenerado;
        private List<Documento_Articulo> lista;
        private String moneda = "S";
        private NumberFormatInfo nfi = Thread.CurrentThread.CurrentCulture.NumberFormat;
        private char decSeperator;
        private List<Documento_Articulo> listaDocumentoArticulo = new List<Documento_Articulo>();
        public EditarPresupuesto(Documento documento)
        {
            InitializeComponent();
            decSeperator = nfi.CurrencyDecimalSeparator[0];
            this.documento = documento;
        }
        public void InitializeCulture()
        {
            var culture = CultureInfo.CreateSpecificCulture("es-ES");
            culture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        private void EditarPresupuesto_Load(object sender, EventArgs e)
        {
            InitializeCulture();
            LoadBoxes();
        }
        public void LoadDocumento()
        {
            decimal monto = 0;
            double cantidadItems = 0;
            lista = servicio.ArticulosByDocumento(documento.Id_Documento);
            try
            {
                if(lista != null)
                {
                    foreach (var docArticulo in lista)
                    {
                        dgvArticulos.Rows.Add(docArticulo.Empresa.RazonSocial, docArticulo.CodArea, docArticulo.Articulo.Descripcion, docArticulo.Proveedor.RazonSocial, docArticulo.NombreBanco, docArticulo.CuentaBanco, docArticulo.Articulo.UnidadMedida.Descripcion, docArticulo.Cantidad, docArticulo.Articulo.Costo, docArticulo.Importe);
                        
                    }

                    foreach (var articulo in lista)
                    {
                        monto = monto + Convert.ToDecimal(articulo.Importe);
                        cantidadItems = cantidadItems + 1;
                    }

                    lblMonto.Text = monto.ToString("#.##");
                    lblItems.Text = cantidadItems.ToString();
                    lblPresupuesto.Text = "PR-" + documento.TipoPresupuesto + "-" + documento.NroDocumento.ToString("0000000");

                    if (documento.Moneda == "S")
                        //lblMoneda.Text = "Soles";
                        rbSoles.Checked = true;
                    else
                        //lblMoneda.Text = "Dólares";
                        rbDolares.Checked = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        public async void LoadBoxes()
        {
            try
            {
                var responseArea = await servicio.AreaGetAllAsync();
                var responseEmpresa = await servicio.EmpresaGetAllAsync();
                var responseProveedor = await servicio.ProveedorGetAllAsync();
                var responseBanco = await servicio.BancoGetAllAsync();

                if (responseArea.IsValid && responseEmpresa.IsValid && responseProveedor.IsValid && responseBanco.IsValid)
                {
                    listaArea = responseArea.Value;
                    listaEmpresa = responseEmpresa.Value;
                    listaArticulo = new List<Articulo>();
                    listaArea.ForEach(tx => {
                        listaArticulo.AddRange(tx.Articuloes);
                    });
                    listaProveedor = responseProveedor.Value;
                    listaBanco = responseBanco.Value;

                    ConfigurarGrilla();

                }
                else
                {
                    MessageBox.Show(responseArea.ErrorMensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ConfigurarGrilla()
        {
            try
            {
                dgvArticulos.AutoGenerateColumns = false;
                dgvArticulos.Columns["Importe"].ReadOnly = true;
                //cambio
                dgvArticulos.Columns["UnidadMedida"].ReadOnly = true;
                dgvArticulos.Columns["Precio"].ReadOnly = true;

                ConfigurarComboCells();

                LoadDocumento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ConfigurarComboCells()
        {
            DataGridViewComboBoxColumn dtColumn = dgvArticulos.Columns["CodArea"] as DataGridViewComboBoxColumn;
            dtColumn.DataSource = listaArea;
            dtColumn.DisplayMember = "CodArea";

            DataGridViewComboBoxColumn dtColumn2 = (DataGridViewComboBoxColumn)dgvArticulos.Columns["RazonSocial"] as DataGridViewComboBoxColumn;
            dtColumn2.DataSource = listaEmpresa;
            dtColumn2.DisplayMember = "RazonSocial";

            DataGridViewComboBoxColumn dtColumn3 = (DataGridViewComboBoxColumn)dgvArticulos.Columns["Descripcion"] as DataGridViewComboBoxColumn;
            dtColumn3.DataSource = listaArticulo;
            dtColumn3.DisplayMember = "Descripcion";

            DataGridViewComboBoxColumn dtcolumn3 = dgvArticulos.Columns["Proveedor"] as DataGridViewComboBoxColumn;
            dtcolumn3.DataSource = listaProveedor;
            dtcolumn3.DisplayMember = "RazonSocial";

            DataGridViewComboBoxColumn dtcolumn4 = dgvArticulos.Columns["Banco"] as DataGridViewComboBoxColumn;
            dtcolumn4.DataSource = listaBanco;
            dtcolumn4.DisplayMember = "Nombre";

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ControlarFilRepetidas())
            {
                importeTotal();
                ActualizarDocumento();
            }
        }

        private void dgvArticulos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Seleccione un elemento de la lista", "Aviso");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dgvArticulos.Rows.Add();
        }

        private Documento GenerarDocumento()
        {
            documento.UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1;

            if (rbSoles.Checked) { 
            documento.Moneda = "S";}
            else if (rbDolares.Checked) { 
                documento.Moneda = "D";}

                foreach (DataGridViewRow row in dgvArticulos.Rows)
                {

                    Documento_Articulo da = new Documento_Articulo();


                    DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)row.Cells["CodArea"];
                    DataGridViewComboBoxCell comboDescripcion = (DataGridViewComboBoxCell)row.Cells["Descripcion"];
                    DataGridViewComboBoxCell cboEmpresa = (DataGridViewComboBoxCell)row.Cells["RazonSocial"];
                    DataGridViewTextBoxCell txtCnt = (DataGridViewTextBoxCell)row.Cells["Cantidad"];
                    DataGridViewTextBoxCell txtPrecio = (DataGridViewTextBoxCell)row.Cells["Precio"];
                    DataGridViewComboBoxCell cboProveedor = (DataGridViewComboBoxCell)row.Cells["Proveedor"];
                    DataGridViewComboBoxCell cboBanco = (DataGridViewComboBoxCell)row.Cells["Banco"];
                    DataGridViewTextBoxCell txtCuenta = (DataGridViewTextBoxCell)row.Cells["NumCuenta"];

                if (comboCell.Value == null || comboDescripcion.Value == null || cboEmpresa.Value == null || txtCnt.Value == null || cboProveedor.Value == null || cboBanco.Value == null || txtCuenta.Value == null)
                    {
                        btnGrabar.Visible = true;
                        MessageBox.Show("Complete todos los campos", "Aviso");
                        return null;
                    }

                    Area area = listaArea.Where(tx => tx.CodArea == comboCell.Value.ToString()).FirstOrDefault();
                    Articulo articulo = listaArticulo.Where(tx => tx.Descripcion == comboDescripcion.Value.ToString()).FirstOrDefault();
                    Empresa empresa = listaEmpresa.Where(tx => tx.RazonSocial == cboEmpresa.Value.ToString()).FirstOrDefault();
                    Proveedor proveedor = listaProveedor.Where(tx => tx.RazonSocial == cboProveedor.Value.ToString()).FirstOrDefault();
                    BANCO banco = listaBanco.Where(tx => tx.Nombre == cboBanco.Value.ToString()).FirstOrDefault();
                    da.Articulo = articulo;

                    double Cantidad = 0;
                    double Importe = Convert.ToDouble(row.Cells["Importe"].Value.ToString());
                    decimal precioUnitario = Convert.ToDecimal(row.Cells["Precio"].Value.ToString());
                    string cuenta = row.Cells["NumCuenta"].Value.ToString();

                if (!Double.TryParse(row.Cells["Cantidad"].Value.ToString(), out Cantidad))
                    {
                        MessageBox.Show("Debe ingresar la cantidad", "Aviso");
                        return null;
                    }

                    da.Empresa = empresa;
                    da.Id_Empresa = empresa.Id_Empresa;
                    da.RazonSocial = empresa.RazonSocial;
                    da.RUC = empresa.RUC;
                    da.DescripcionArticulo = articulo.Descripcion;
                    da.CodArea = area.CodArea;
                    da.UnidadMedida = articulo.UnidadMedida.Descripcion;
                    da.Cantidad = Cantidad;
                    da.PrecioUnitario = precioUnitario;
                    da.Importe = Decimal.Parse(Importe.ToString());
                    da.Id_Articulo = articulo.Id_Articulo;
                    da.UsuarioCreacion = Session.CurrentSession.Usuario.Usuario1;
                    da.FechaCreacion = DateTime.Now;
                    da.Proveedor = proveedor;
                    da.Id_Proveedor = proveedor.Id_Proveedor;
                    da.RUCProveedor = proveedor.RUC;
                    da.NombreBanco = banco.Nombre;
                    da.RazonSocialProveedor = proveedor.RazonSocial;
                    da.TelefonoProveedor = proveedor.Telefono;
                    da.CuentaBanco = cuenta;
                    da.TipoCuentaBanco = moneda;

                listaDocumentoArticulo.Add(da);
                }
            documento.MontoTotal = Decimal.Parse(lblMonto.Text.ToString());
            documento.FechaModificacion = DateTime.Now;
            return documento;
        }

        private void dgvArticulos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                ComboBox box = e.Control as ComboBox;
                box.DropDownStyle = ComboBoxStyle.DropDown;
                box.AutoCompleteSource = AutoCompleteSource.ListItems;
                box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                if (box.Tag == null)
                {
                    box.Leave += Combos_Leave;
                    box.Tag = true;
                }
            }
            if (e.Control is TextBox)
            {
                e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
                if (dgvArticulos.CurrentCell.ColumnIndex == dgvArticulos.Columns["Cantidad"].Index)
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                        tb.Leave += new EventHandler(txtCantidad_Leave);

                    }
                }

                if (dgvArticulos.CurrentCell.ColumnIndex == dgvArticulos.Columns["Precio"].Index)
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                        tb.Leave += new EventHandler(txtPrecio_Leave);

                    }
                }
            }

        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !(char.IsDigit(e.KeyChar) | e.KeyChar == decSeperator))
            {
                e.Handled = true;
            }
            if (e.KeyChar == decSeperator
                && (sender as TextBox).Text.IndexOf(decSeperator) > -1)
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            importeTotal();
            itemsTotal();
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            importeTotal();
            itemsTotal();
        }

        private void Combos_Leave(object sender, EventArgs e)
        {
            DataGridViewComboBoxCell cbDescripcion = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells["Descripcion"] as DataGridViewComboBoxCell;
            DataGridViewTextBoxCell txtUnidadMedida = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells["UnidadMedida"] as DataGridViewTextBoxCell;
            DataGridViewComboBoxCell cbCodArea = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells["CodArea"] as DataGridViewComboBoxCell;
            DataGridViewTextBoxCell txtPrecio = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells["Precio"] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell txtImporte = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells["Importe"] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell txtCantidad = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells["Cantidad"] as DataGridViewTextBoxCell;
            DataGridViewTextBoxCell txtCuenta = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells["NumCuenta"] as DataGridViewTextBoxCell;
            DataGridViewComboBoxCell cboBanco = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells["Banco"] as DataGridViewComboBoxCell;

            if (dgvArticulos.Columns[dgvArticulos.CurrentCell.ColumnIndex] == dgvArticulos.Columns["CodArea"])
            {
                ComboBox combo = (ComboBox)sender;

                Area area = combo.SelectedItem as Area;

                if (area == null)
                {
                    area = listaArea.Where(tx => tx.CodArea.ToUpper() == combo.Text.ToUpper()).FirstOrDefault();
                    cbCodArea.Value = area.CodArea;
                    combo.Text = area.CodArea;
                }

                dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells["Descripcion"].Value = null;
                txtUnidadMedida.Value = null;
                txtPrecio.Value = null;
                txtImporte.Value = null;
                txtCantidad.Value = null;
                cbDescripcion.DataSource = listaArticulo.Where(tx => tx.Id_Area == area.Id_Area && tx.Moneda.ToUpper() == moneda).ToList();
                cbDescripcion.DisplayMember = "Descripcion";
            }
            if (dgvArticulos.Columns[dgvArticulos.CurrentCell.ColumnIndex] == dgvArticulos.Columns["Proveedor"])
            {
                ComboBox combo = (ComboBox)sender;


                Proveedor proveedor = combo.SelectedItem as Proveedor;
                BANCO banco = servicio.BancoGetById(proveedor.Id_Banco).Value;

                cboBanco.Value = banco.Nombre;
                cboBanco.DisplayMember = "Nombre";
                txtCuenta.Value = proveedor.NumeroCuenta;
            }

            if (dgvArticulos.Columns[dgvArticulos.CurrentCell.ColumnIndex] == dgvArticulos.Columns["Descripcion"])
            {
                ComboBox combo = (ComboBox)sender;

                Articulo articulo = combo.SelectedItem as Articulo;

                if (articulo == null)
                {
                    articulo = listaArticulo.Where(tx => tx.Descripcion.ToUpper() == combo.Text.ToUpper()).FirstOrDefault();

                    if (articulo != null)
                    {
                        if (combo.Items.IndexOf(articulo) != -1)
                        {
                            combo.SelectedItem = articulo;
                            combo.Text = articulo.Descripcion;
                            cbDescripcion.Value = articulo.Descripcion;

                        }
                    }

                }

                if (articulo != null)
                {
                    txtUnidadMedida.Value = articulo.UnidadMedida.Descripcion;
                    txtPrecio.Value = articulo.Costo;
                }
            }
        }

        private bool ControlarFilRepetidas()
        {
            foreach (DataGridViewRow row in dgvArticulos.Rows)
            {

                int cantidad = 0;
                foreach (DataGridViewRow subRow in dgvArticulos.Rows)
                {
                    if (subRow.Cells["Descripcion"].Value == row.Cells["Descripcion"].Value)
                    {
                        if (subRow.Cells["RazonSocial"].Value == row.Cells["RazonSocial"].Value)
                        {
                            cantidad++;
                        }
                    }
                }
                if (cantidad != 1)
                {
                    MessageBox.Show("No debe ingresar productos repetidos", "Aviso");
                    return false;
                }


            }
            return true;
        }

        private void importeTotal()
        {
            double Cantidad = 0;
            double actual = 0;
            double total = 0;
            double pUni = 0;
            double nuevoTotal = 0;
            foreach (DataGridViewRow dtr in dgvArticulos.Rows)
            {

                Double.TryParse(dtr.Cells["Cantidad"].EditedFormattedValue.ToString(), out actual);
                Double.TryParse(dtr.Cells["Importe"].EditedFormattedValue.ToString(), out total);
                Double.TryParse(dtr.Cells["Precio"].EditedFormattedValue.ToString(), out pUni);
                Cantidad += total;
                DataGridViewTextBoxCell txtImporte = dgvArticulos.Rows[dtr.Index].Cells["Importe"] as DataGridViewTextBoxCell;
                nuevoTotal = actual * pUni;
                txtImporte.Value = nuevoTotal;
            }

            lblMonto.Text = Cantidad.ToString("0.00");
            //lblMonto.Text = nuevoTotal.ToString("0.00");
        }

        private void itemsTotal()
        {
            int cantidad = 0;
            //int actual = 0;
            foreach (DataGridViewRow row in dgvArticulos.Rows)
            {
                //Int32.TryParse(row.Cells["Cantidad"].EditedFormattedValue.ToString(), out actual);
                cantidad += 1;
            }

            lblItems.Text = cantidad.ToString();
        }
        private async void ActualizarDocumento()
        {
            btnSalir.Enabled = false;
            btnGrabar.Visible = false;
            docGenerado = GenerarDocumento();
            if (docGenerado != null)
            {
                if (docGenerado.Documento_Articulo.Count > 0)
                {
                    IServiceAlmacen service = new ServiceAlmacen();
                    var response = await service.DocumentoUpdateAsync(docGenerado,listaDocumentoArticulo);
                    if (response.IsValid)
                    {
                        MessageBox.Show("Proceso realizado satisfactoriamente", "Aviso");
                        docGenerado = response.Value;
                        DisableControls();
                        //lblOrdenCompra.Text = docGenerado.TipoDocumento + "-" + docGenerado.TipoPresupuesto + "-" + docGenerado.NroDocumento.ToString("0000000");

                    }
                    else
                    {
                        btnGrabar.Visible = true;
                        btnSalir.Enabled = true;
                        MessageBox.Show(response.ErrorMensaje);
                    }
                }
                else
                {
                    MessageBox.Show("Debe agregar al menos un articulo", "Aviso");
                }
            }
        }

        private void DisableControls()
        {
            rbSoles.Enabled = false;
            rbDolares.Enabled = false;
            dgvArticulos.Enabled = false;
            dtpFechaEstIngI.Enabled = false;
            btnGrabar.Enabled = false;
            btnSalir.Enabled = true;
        }

        private void HideControls()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                dgvArticulos.Rows.Remove(dgvArticulos.CurrentRow);
                importeTotal();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "Aviso");
            }
        }

        private void rbSoles_CheckedChanged(object sender, EventArgs e)
        {
            
            lblMoneda.Text = "S/.";
            moneda = "S";
        }

        private void rbDolares_CheckedChanged(object sender, EventArgs e)
        {
            moneda = "D";
            lblMoneda.Text = "U$$";
        }

        private void rbSoles_MouseClick(object sender, MouseEventArgs e)
        {
            dgvArticulos.Rows.Clear();
            lblMonto.Text = "";
            lblItems.Text = "";
        }

        private void rbDolares_MouseClick(object sender, MouseEventArgs e)
        {
            dgvArticulos.Rows.Clear();
            lblMonto.Text = "";
            lblItems.Text = "";
        }
    }
}
