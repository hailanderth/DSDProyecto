using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MD.GA.BE.Entidades;
using MD.GA.SERVICES;
using MD.GA.GUI.Session;
using System.Globalization;
using System.Threading;

namespace MD.GA.GUI.GA.Almacen
{
    public partial class Articulos : Form
    {
        IServiceAlmacen service = new ServiceAlmacen();
        List<Articulo> listaArticulo;
        private int idArea = 0;
        private string nombreArticulo = string.Empty;


        public Articulos()
        {
            InitializeComponent();
        }

        public void InitializeCulture()
        {
            var culture = CultureInfo.CreateSpecificCulture("es-ES");
            culture.NumberFormat.NumberDecimalSeparator = ".";
            culture.NumberFormat.NumberDecimalDigits = 2;
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        private void BtnArtbutton2_Click(object sender, EventArgs e)
        {

        }

        private void BtnArtbutton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            GA.Almacen.Nuevo_Articulo nuevo_articulo = new Nuevo_Articulo();
            nuevo_articulo.ShowDialog();
            this.Show();
        }

        private void BtnArtbutton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            InitializeCulture();
            ConfigurarGrilla();
            CargarComboArea();
            cboArea.Focus();
            EnableControlsByRol();
        }

        private void EnableControlsByRol()
        {
            if (CurrentSession.Usuario.Id_Puesto == (int)Roles.Administrador)
            {
                BtnArtNue.Visible = true;
            }
            else if (CurrentSession.Usuario.Id_Puesto == (int)Roles.Operador)
            {
                BtnArtNue.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void ConfigurarGrilla()
        {
            dgvArticulos.AutoGenerateColumns = false;
        }

        public async void CargarGrilla()
        {
            var responseArticulos = await service.ArticuloGetAllAsync();
            listaArticulo = responseArticulos.Value;
            dgvArticulos.DataSource = listaArticulo;

            foreach (DataGridViewRow row in dgvArticulos.Rows)
            {
                string moneda = row.Cells["Moneda"].Value.ToString();
                string estado = row.Cells["Estado"].Value.ToString();
                double stock = Convert.ToDouble(row.Cells["Stock"].Value);

                if (moneda.Equals("S"))
                {
                    row.Cells["MonedaMod"].Value = "Soles";
                }
                else
                {
                    row.Cells["MonedaMod"].Value = "Dólares";
                }

                if(estado.Equals("A"))
                {
                    row.Cells["ModEstado"].Value = "Activo";
                }
                else
                {
                    row.Cells["ModEstado"].Value = "Inactivo";
                }

                row.Cells["Stock"].Value = Math.Round(stock,2);
            }
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idArticulo = Convert.ToInt32(dgvArticulos.CurrentRow.Cells["IdArticulo"].Value.ToString());

            if (e.ColumnIndex == 0)
            {
                Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                Editar_Articulo formArticulo = new Editar_Articulo(articulo);
                formArticulo.ShowDialog();
                CargarGrilla();
            }
            
            else if(e.ColumnIndex == 1)
            {
                var response = service.ArticuloDelete(idArticulo);

                if (response.IsValid)
                {
                    MessageBox.Show("El articulo se eliminó correctamente");
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error: " + response.ErrorMensaje);
                }
            }
        }

        private async void CargarComboArea()
        {
            try
            {
                List<Area> listaArea;

                var responseComboaArea = await service.AreaGetAllAsync();
                listaArea = responseComboaArea.Value;

                Area area = new Area
                {
                    Id_Area = 0,
                    NombreArea = "--- Todos ---"
                };

                listaArea.Insert(0, area);
                cboArea.DataSource = listaArea;
                cboArea.DisplayMember = "NombreArea";
                cboArea.ValueMember = "Id_Area";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvArticulos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvArticulos.Rows)
            {
                if (Convert.ToDecimal(row.Cells["Stock"].Value) == 0)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }

                else if (Convert.ToDecimal(row.Cells["Stock"].Value) < (Convert.ToDecimal(row.Cells["CantidadMinima"].Value)))
                {
                    row.DefaultCellStyle.ForeColor = Color.Blue;
                }
            }             
        }

        private void dgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private async void btnArtBuscar_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                idArea = Convert.ToInt32(cboArea.SelectedValue);
                nombreArticulo = txtNombre.Text.Trim().ToUpper();

                try
                {
                    var responseArticulos = await service.ListarArticuloByStock(idArea, nombreArticulo, chkConsiderar.Checked, chkBajo.Checked, chSinStock.Checked, CurrentSession.Usuario.Id_Puesto);
                    listaArticulo = responseArticulos.Value;
                    dgvArticulos.DataSource = listaArticulo;
                    decimal cantidad = 0;

                    foreach (DataGridViewRow row in dgvArticulos.Rows)
                    {
                        

                        cantidad = cantidad + Convert.ToDecimal(row.Cells["Stock"].Value.ToString());

                        string moneda = row.Cells["Moneda"].Value.ToString();
                        string estado = row.Cells["Estado"].Value.ToString();
                        double stock = Convert.ToDouble(row.Cells["Stock"].Value);

                        if (moneda.Equals("S"))
                        {
                            row.Cells["MonedaMod"].Value = "Soles";
                        }
                        else
                        {
                            row.Cells["MonedaMod"].Value = "Dólares";
                        }

                        if (estado.Equals("A"))
                        {
                            row.Cells["ModEstado"].Value = "Activo";
                        }
                        else
                        {
                            row.Cells["ModEstado"].Value = "Inactivo";
                        }

                        row.Cells["Stock"].Value = Math.Round(stock,2);
                    }

                    lblCantidad.Text = cantidad.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar algún tipo de stock", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            if (chkConsiderar.Checked == false && chkBajo.Checked == false && chSinStock.Checked == false)
                return false;
            return true;
        }
    }
}
