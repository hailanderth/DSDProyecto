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

namespace MD.GA.GUI.GA.Salida.Registro_de_Salida
{
    public partial class RegistrodeSalida : Form
    {
        private const String TipoDocumento = "RS";
        private List<Area> listaArea = new List<Area>();
        private List<Articulo> listaArticulo;
        private NumberFormatInfo nfi = Thread.CurrentThread.CurrentCulture.NumberFormat;
        private char decSeperator;

        public RegistrodeSalida()
        {
            InitializeComponent();
        }
        private void Init()
        {
            SetDefaultValues();
            LoadComboSede();
            
        }
        private void SetDefaultValues()
        {
            dtpFechaEstIngI.Value = DateTime.Now;
            lblUsuarioActual.Text = Session.CurrentSession.Usuario.Usuario1;
            decSeperator = nfi.CurrencyDecimalSeparator[0];
        }
        private void RegistrodeSalida_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void ConfigureDataGridView()
        {
            DataGridViewComboBoxColumn dtcolumn = dgvSalida.Columns["CodArea"] as DataGridViewComboBoxColumn;
            dtcolumn.DataSource = listaArea;
            dtcolumn.DisplayMember = "CodArea";
        }
        private async void LoadAreas()
        {
            try
            {
                IServiceAlmacen service = new ServiceAlmacen();
                var responseArea = await service.AreaGetAllAsync();
                var responseArticulo = await service.ArticuloGetAllAsync();
                
                if (responseArea.IsValid && responseArticulo.IsValid)
                {
                    listaArticulo = responseArticulo.Value;
                    listaArea = responseArea.Value;
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
        private async void LoadComboSede()
        {
            try
            {
                IServiceAlmacen service = new ServiceAlmacen();
                var response = await service.SedeGetAllAsync();
                if (response.IsValid)
                {
                    cboSede.DataSource = response.Value;
                    cboSede.DisplayMember = "NombreSede";
                    LoadAreas();
                }
                else
                {
                    MessageBox.Show(response.ErrorMensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error "+ex.Message,"Aviso",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
        private void btnRegdSal2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                ComboBox box = e.Control as ComboBox;
                ConfigureDataGridViewComboBox(box);
            }
            if (e.Control is TextBox)
            {
                e.Control.KeyPress -= new KeyPressEventHandler(txtPrecio_KeyPress);
                if (dgvSalida.CurrentCell.ColumnIndex == dgvSalida.Columns["Cantidad"].Index)
                {
                    TextBox tb = e.Control as TextBox;
                    ConfigureDataGridViewTextBox(tb);
                }
            }
        }
        private void ConfigureDataGridViewTextBox(TextBox tb)
        {
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(txtPrecio_KeyPress);
                tb.Leave += new EventHandler(txtCantidad_Leave);
            }
        }
        private void ConfigureDataGridViewComboBox(ComboBox box)
        {
            box.DropDownStyle = ComboBoxStyle.DropDown;
            box.AutoCompleteSource = AutoCompleteSource.ListItems;
            box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            box.Leave -= Combos_Leave;
            box.Leave += Combos_Leave;
        }
        private void dgvSalida_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Seleccione un elemento de la lista", "Aviso");
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !(char.IsDigit(e.KeyChar) | e.KeyChar == decSeperator))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == decSeperator
                && (sender as TextBox).Text.IndexOf(decSeperator) > -1)
            {
                e.Handled = true;
            }
        }
        private void CalcularTotal()
        {
            //double Cantidad = 0;
            //foreach (DataGridViewRow dtr in dgvSalida.Rows)
            //{
            //    double actual = 0;
            //    Double.TryParse(dtr.Cells["Cantidad"].EditedFormattedValue.ToString(), out actual);
            //    Cantidad += actual;
            //}
            lblTotalItems.Text = dgvSalida.Rows.Count.ToString();
        }
        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            CalcularTotal();
        }
        private void Combos_Leave(object sender, EventArgs e)
        {
            DataGridViewComboBoxCell cbcell = dgvSalida.Rows[dgvSalida.CurrentRow.Index].Cells["Descripcion"] as DataGridViewComboBoxCell;
            DataGridViewTextBoxCell txtUnidadMedida = dgvSalida.Rows[dgvSalida.CurrentRow.Index].Cells["UnidadMedida"] as DataGridViewTextBoxCell;
            DataGridViewComboBoxCell cbAreaCell = dgvSalida.Rows[dgvSalida.CurrentRow.Index].Cells["CodArea"] as DataGridViewComboBoxCell;


            if (dgvSalida.Columns[dgvSalida.CurrentCell.ColumnIndex] == dgvSalida.Columns["CodArea"])
            {
                ComboBox combo = (ComboBox)sender;

                Area area = combo.SelectedItem as Area;
                if (area == null)
                {
                    area = listaArea.Where(tx => tx.CodArea.ToUpper() == combo.Text.ToUpper()).FirstOrDefault();
                }
                if (area != null)
                {
                    cbAreaCell.Value = area.CodArea;
                    combo.Text = area.CodArea;
                    dgvSalida.Rows[dgvSalida.CurrentRow.Index].Cells["Descripcion"].Value = null;
                    txtUnidadMedida.Value = null;
                    cbcell.DataSource = listaArticulo.Where(tx => tx.Id_Area == area.Id_Area).ToList();
                    cbcell.DisplayMember = "Descripcion";
                }




            }
            if (dgvSalida.Columns[dgvSalida.CurrentCell.ColumnIndex] == dgvSalida.Columns["Descripcion"])
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
                }
            }
        }

        private async void RegistrarDocumento()
        {
            Documento documento = GenerarDocumento();
            if (documento != null)
            {
                btnGrabar.Visible = false;
                if (documento.Documento_Articulo.Count > 0)
                {
                    
                    IServiceAlmacen service = new ServiceAlmacen();
                    var response = await service.DocumentoInsertAsync(documento);
                    if (response.IsValid)
                    {
                        MessageBox.Show("Proceso realizado satisfactoriamente", "Aviso");
                        documento = response.Value;
                        lblNumeroDocumento.Text = documento.TipoDocumento + "-" + documento.Sede.Codigo + "-" + documento.NroDocumento.ToString("0000000");
                        HideControls();
                    }
                    else
                    {
                        MessageBox.Show(response.ErrorMensaje);
                        btnGrabar.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Debe agregar al menos un articulo", "Aviso");
                    btnGrabar.Visible = true;
                }
            }
            
        }
        private void HideControls()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnGrabar.Visible = false;
            cboSede.Enabled = false;
            dgvSalida.Enabled = false;
        }
        private void btnRegdSal1_Click(object sender, EventArgs e)
        {
            if (ValidarGrilla())
            {
                RegistrarDocumento();
            }
        }
        private bool ValidarGrilla()
        { 
            foreach (DataGridViewRow row in dgvSalida.Rows)
            {
                int cantidad = 0;
                foreach(DataGridViewRow subRow in dgvSalida.Rows)
                {
                    if (subRow.Cells["Descripcion"].Value == row.Cells["Descripcion"].Value)
                    {
                        cantidad++;
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
        private Documento GenerarDocumento()
        {
            Documento documento = new Documento();
            documento.TipoDocumento = TipoDocumento;
            documento.Sede = cboSede.SelectedValue as Sede;
            documento.Encargado = Session.CurrentSession.Usuario.Usuario1;
            documento.UsuarioCreacion = Session.CurrentSession.Usuario.Usuario1;
            List<Documento_Articulo> listaDocumentoArticulo = new List<Documento_Articulo>();
            foreach (DataGridViewRow dgvr in dgvSalida.Rows)
            {
                Documento_Articulo da = new Documento_Articulo();

                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dgvr.Cells["CodArea"];
                DataGridViewComboBoxCell comboDescripcion = (DataGridViewComboBoxCell)dgvr.Cells["Descripcion"];

                if (comboCell.Value == null || comboDescripcion.Value == null)
                {
                    MessageBox.Show("Debe completar todos los campos", "Aviso");
                    return null;
                }


                Area area = listaArea.Where(tx => tx.CodArea == comboCell.Value.ToString()).FirstOrDefault();
                Articulo articulo = listaArticulo.Where(tx => tx.Descripcion == comboDescripcion.Value.ToString()).FirstOrDefault();
                da.Articulo = articulo;
                double Cantidad = 0;
                if (dgvr.Cells["Cantidad"].Value == null)
                {
                    MessageBox.Show("Debe ingresar la cantidad", "Aviso");
                    return null;
                }
                if (!Double.TryParse(dgvr.Cells["Cantidad"].Value.ToString(), out Cantidad))
                {
                    MessageBox.Show("Debe ingresar la cantidad", "Aviso");
                    return null;
                }
                da.NombreArea = area.NombreArea;
                da.CodArea = area.CodArea;
                da.UnidadMedida = articulo.UnidadMedida.Descripcion;
                da.Cantidad = Cantidad;
                da.DescripcionArticulo = articulo.Descripcion;
                listaDocumentoArticulo.Add(da);

            }
            documento.Documento_Articulo = listaDocumentoArticulo;
            return documento;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int rowId = dgvSalida.Rows.Add();
            dgvSalida.Rows[rowId].Cells[0].Selected = true;
            CalcularTotal();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dgvSalida.CurrentRow != null)
            {
                dgvSalida.Rows.Remove(dgvSalida.CurrentRow);
                CalcularTotal();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "Aviso");
            }
        }
    }
}
