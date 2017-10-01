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
using System.Globalization;
using System.Threading;

namespace MD.GA.GUI.GA.Compras.presupuesto
{
    public partial class Presupuesto : Form
    {
        private const String TipoDocumento = "PR";
        private List<Area> listaArea;
        private List<Articulo> listaArticulo;
        private List<Empresa> listaEmpresa;
        private List<Proveedor> listaProveedor;
        private List<BANCO> listaBanco;
        private NumberFormatInfo nfi = Thread.CurrentThread.CurrentCulture.NumberFormat;
        private char decSeperator;
        private String moneda = "S";
        

        public Presupuesto()
        {
            InitializeComponent();
            decSeperator = nfi.CurrencyDecimalSeparator[0];
        }

        #region Configurar Grilla
        private void ConfigureDataGridView()
        {
            DataGridViewComboBoxColumn dtcolumn = dgvArticulos.Columns["CodArea"] as DataGridViewComboBoxColumn;
            dtcolumn.DataSource = listaArea;
            dtcolumn.DisplayMember = "CodArea";
            DataGridViewComboBoxColumn dtcolumn2 = dgvArticulos.Columns["RazonSocial"] as DataGridViewComboBoxColumn;
            dtcolumn2.DataSource = listaEmpresa;
            dtcolumn2.DisplayMember = "RazonSocial";
            DataGridViewComboBoxColumn dtcolumn3 = dgvArticulos.Columns["Proveedor"] as DataGridViewComboBoxColumn;
            dtcolumn3.DataSource = listaProveedor;
            dtcolumn3.DisplayMember = "RazonSocial";
            DataGridViewComboBoxColumn dtcolumn4 = dgvArticulos.Columns["Banco"] as DataGridViewComboBoxColumn;
            dtcolumn4.DataSource = listaBanco;
            dtcolumn4.DisplayMember = "Nombre";
        }
        #endregion

        #region Cargar Combos Grilla
        private async void Loadboxes()
        {
            try
            {
                cboTipoPre.SelectedIndex = 0;
                IServiceAlmacen service = new ServiceAlmacen();
                var responseArea = await service.AreaGetAllAsync();
                var responseArticulo = await service.ArticuloGetAllAsync();
                var responseEmpresa = await service.EmpresaGetAllAsync();
                var responseProveedor = await service.ProveedorGetAllAsync();
                var responseBanco = await service.BancoGetAllAsync();

                if (responseArea.IsValid && responseArticulo.IsValid && responseEmpresa.IsValid && responseProveedor.IsValid && responseBanco.IsValid)
                {
                    listaArticulo = responseArticulo.Value;
                    listaArea = responseArea.Value;
                    listaEmpresa = responseEmpresa.Value;
                    listaProveedor = responseProveedor.Value;
                    listaBanco = responseBanco.Value;
                    ConfigureDataGridView();
                }
                else
                {
                    MessageBox.Show(responseArticulo.ErrorMensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void Presupuesto_Load(object sender, EventArgs e)
        {
            Loadboxes();
        }

        private void BtnArtbutton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvArticulos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Seleccione un elemento de la lista", "Aviso");
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
        }

        private void Combos_Leave(object sender, EventArgs e)
        {
            ServiceAlmacen servicio = new ServiceAlmacen();
            DataGridViewComboBoxCell cbcell = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells["Descripcion"] as DataGridViewComboBoxCell;
            DataGridViewTextBoxCell txtUnidadMedida = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells["UnidadMedida"] as DataGridViewTextBoxCell;
            DataGridViewComboBoxCell cbAreaCell = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells["CodArea"] as DataGridViewComboBoxCell;
            DataGridViewTextBoxCell txtPrecio = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells["Costo"] as DataGridViewTextBoxCell;
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
                    cbAreaCell.Value = area.CodArea;
                    combo.Text = area.CodArea;
                }
                dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells["Descripcion"].Value = null;
                txtUnidadMedida.Value = null;
                txtPrecio.Value = null;
                txtImporte.Value = null;
                txtCantidad.Value = null;
                cbcell.DataSource = listaArticulo.Where(tx => tx.Id_Area == area.Id_Area && tx.Moneda.ToUpper() == moneda).ToList();
                cbcell.DisplayMember = "Descripcion";
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
                            cbcell.Value = articulo.Descripcion;
                            
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int rowId = dgvArticulos.Rows.Add();
            dgvArticulos.Rows[rowId].Cells[0].Selected = true;
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
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dgvArticulos.Rows.Clear();
            lblTotalI.Text = "";
            lblMoneda.Text = "S/.";
            moneda = "S";
        }

        #region Generar Documento
        private Documento GenerarDocumento()
        {
            Documento documento = new Documento();
            documento.TipoDocumento = TipoDocumento;
            documento.UsuarioCreacion = Session.CurrentSession.Usuario.Usuario1;
            string tipoPre = "";
            if(cboTipoPre.SelectedItem.ToString() =="Varios")
            {
                tipoPre = "VAR";
            }
            if (cboTipoPre.SelectedItem.ToString() == "Placas")
            {
                tipoPre = "PLA";
            }
            if(cboTipoPre.SelectedItem.ToString() == "Lab")
            {
                tipoPre = "LAB";
            }
            documento.TipoPresupuesto = tipoPre;
            List<Documento_Articulo> listaDocumentoArticulo = new List<Documento_Articulo>();
            foreach (DataGridViewRow dgvr in dgvArticulos.Rows)
            {
                Documento_Articulo da = new Documento_Articulo();

                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dgvr.Cells["CodArea"];
                DataGridViewComboBoxCell comboDescripcion = (DataGridViewComboBoxCell)dgvr.Cells["Descripcion"];
                DataGridViewComboBoxCell cboEmpresa = (DataGridViewComboBoxCell)dgvr.Cells["RazonSocial"];
                DataGridViewTextBoxCell txtCnt = (DataGridViewTextBoxCell)dgvr.Cells["Cantidad"];
                DataGridViewComboBoxCell cboProveedor = (DataGridViewComboBoxCell)dgvr.Cells["Proveedor"];
                DataGridViewComboBoxCell cboBanco = (DataGridViewComboBoxCell)dgvr.Cells["Banco"];
                DataGridViewTextBoxCell txtCuenta = (DataGridViewTextBoxCell)dgvr.Cells["NumCuenta"];

                if (comboCell.Value == null || comboDescripcion.Value == null || cboEmpresa.Value == null || txtCnt.Value == null || cboProveedor.Value == null || cboBanco.Value == null || txtCuenta.Value == null)
                {
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

                double Importe = Convert.ToDouble(dgvr.Cells["Importe"].Value.ToString());
                string cuenta = dgvr.Cells["NumCuenta"].Value.ToString();

                if (!Double.TryParse(dgvr.Cells["Cantidad"].Value.ToString(), out Cantidad))
                {
                    MessageBox.Show("Debe ingresar la cantidad", "Aviso");
                    return null;
                }
                
                da.Empresa = empresa;
                da.RazonSocial = empresa.RazonSocial;
                da.RUC = empresa.RUC;
                da.DescripcionArticulo = articulo.Descripcion;
                da.CodArea = area.CodArea;
                da.UnidadMedida = articulo.UnidadMedida.Descripcion;
                da.Cantidad = Cantidad;
                da.PrecioUnitario = articulo.Costo;
                da.Importe = Decimal.Parse(Importe.ToString());
                da.Id_Articulo = articulo.Id_Articulo;
                //
                da.Proveedor = proveedor;
                da.Id_Proveedor = proveedor.Id_Proveedor;
                da.RUCProveedor = proveedor.RUC;
                da.NombreBanco = banco.Nombre;
                da.RazonSocialProveedor = proveedor.RazonSocial;
                da.TelefonoProveedor = proveedor.Telefono;
                da.CuentaBanco = cuenta;
                da.TipoCuentaBanco = moneda;
                //
                listaDocumentoArticulo.Add(da);

            }
            documento.Moneda = moneda;
            documento.MontoTotal = Decimal.Parse(lblTotalI.Text.ToString());
            documento.Documento_Articulo = listaDocumentoArticulo;
            return documento;
        }
        #endregion
        #region Registrar Documento
        private async void RegistrarDocumento()
        {
            
            Documento documento = GenerarDocumento();
            if (documento != null)
            {
                HideControls();
                btnSalir.Enabled = false;
                if (documento.Documento_Articulo.Count > 0)
                {
                    IServiceAlmacen service = new ServiceAlmacen();
                    var response = await service.DocumentoInsertAsync(documento);
                    if (response.IsValid)
                    {
                        MessageBox.Show("Proceso realizado satisfactoriamente", "Aviso");
                        documento = response.Value;
                        lblnumPre.Text = documento.TipoDocumento + "-" + documento.TipoPresupuesto + "-" + documento.NroDocumento.ToString("0000000");
                        btnSalir.Enabled = true;
                    }
                    else
                    {
                        ShowControls();
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
        #endregion

        private void HideControls()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnGrabar.Visible = false;
            dgvArticulos.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            cboTipoPre.Enabled = false;
        }
        private void ShowControls()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            btnGrabar.Visible = true;
            dgvArticulos.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            cboTipoPre.Enabled = true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ControlarFilRepetidas())
            {
                importeTotal();
                RegistrarDocumento();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            moneda = "D";
            lblMoneda.Text = "U$$";
        }

        private void importeTotal()
        {
            double Cantidad = 0;
            double actual = 0;
            double total = 0;
            double pUni = 0;
            foreach (DataGridViewRow dtr in dgvArticulos.Rows)
            {

                Double.TryParse(dtr.Cells["Cantidad"].EditedFormattedValue.ToString(), out actual);
                Double.TryParse(dtr.Cells["Importe"].EditedFormattedValue.ToString(), out total);
                Double.TryParse(dtr.Cells["Costo"].EditedFormattedValue.ToString(), out pUni);
                Cantidad += total;
                DataGridViewTextBoxCell txtImporte = dgvArticulos.Rows[dtr.Index].Cells["Importe"] as DataGridViewTextBoxCell;
                txtImporte.Value = actual * pUni;
            }

            lblTotalI.Text = Cantidad.ToString("0.00");
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
                        /*Validación filas repetidas por Razón Social - <28/01/2017> -Gianfranco Chavez*/
                        if (subRow.Cells["RazonSocial"].Value == row.Cells["RazonSocial"].Value)
                        {
                            cantidad++;
                        }
                        /*Validación filas repetidas por Razón Social - <28/01/2017> -Gianfranco Chavez*/
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

        }
}
