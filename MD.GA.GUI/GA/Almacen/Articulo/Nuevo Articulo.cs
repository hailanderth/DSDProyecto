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
using MD.GA.COMMOM;
using System.Globalization;
using System.Threading;

namespace MD.GA.GUI.GA.Almacen
{
    public partial class Nuevo_Articulo : Form
    {
        IServiceAlmacen servicio = new ServiceAlmacen();

        public Nuevo_Articulo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblNueArt1_Click(object sender, EventArgs e)
        {

        }

        private void BtnNueArt2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nuevo_Articulo_Load(object sender, EventArgs e)
        {
            InitializeCulture();
            SetIndexCombo();
            CargarComboArea();
            CargarComboUnidadMedida();
            cboArea.Focus();
        }

        public void InitializeCulture()
        {
            var culture = CultureInfo.CreateSpecificCulture("es-ES");
            culture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            culture.NumberFormat.NumberDecimalDigits = 2;

        }

        private void SetIndexCombo()
        {
            cboArtMoneda.SelectedIndex = 0;
        }

        private void CargarComboArea()
        {
            try
            {
                List<Area> listaArea;

                listaArea = servicio.ComboArea();
                cboArea.DataSource = listaArea;
                cboArea.DisplayMember = "NombreArea";
                cboArea.ValueMember = "Id_Area";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboUnidadMedida()
        {
            try
            {
                List<UnidadMedida> listaUnidadMedida;

                listaUnidadMedida = servicio.ComboUnidadMedida();
                cboUnidadMedida.DataSource = listaUnidadMedida;
                cboUnidadMedida.DisplayMember = "Descripcion";
                cboUnidadMedida.ValueMember = "Id_UnidadMedida";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNueArt1_Click(object sender, EventArgs e)
        {
            CreateArticulo();
        }

        public bool ValidarCampos()
        {
            if (Convert.ToInt32(cboArea.SelectedValue) == 0)
                return false;
            if (Convert.ToInt32(cboUnidadMedida.SelectedValue) == 0)
                return false;
            if (cboArtMoneda.SelectedIndex == -1 || cboArtMoneda.SelectedIndex == 0)
                return false;
            if (txtMarca.ToString().Trim().Equals(string.Empty))
                return false;
            if (txtDescripcion.ToString().Trim().Equals(string.Empty))
                return false;
            if (txtCantidadMinima.ToString().Trim().Equals(string.Empty))
                return false;
            if (txtStock.ToString().Trim().Equals(string.Empty))
                return false;
            if (txtCosto.ToString().Trim().Equals(string.Empty))
                return false;
            return true;
        }

        public void CreateArticulo()
        {
            if(ValidarCampos())
            {
                try
                {
                    Articulo objArticulo = new Articulo()
                    {
                        Descripcion = txtDescripcion.Text.ToString().ToUpper().Trim(),
                        Moneda = cboArtMoneda.SelectedIndex == 1 ? "S" : "D",
                        Stock = Convert.ToDouble(txtStock.Text.ToString().Trim()),
                        Costo = Convert.ToDecimal(txtCosto.Text.Trim()),
                        Marca = txtMarca.Text.ToUpper().Trim().ToString(),
                        UsuarioCreacion = Session.CurrentSession.Usuario.Usuario1,
                        FechaCreacion = DateTime.Now,
                        UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1,
                        FechaModificacion = DateTime.Now,
                        Estado = "A",
                        Id_Area = Convert.ToInt32(cboArea.SelectedValue),
                        Id_UnidadMedida = Convert.ToInt32(cboUnidadMedida.SelectedValue),
                        Area = cboArea.SelectedItem as Area,
                        UnidadMedida = cboUnidadMedida.SelectedItem as UnidadMedida,
                        CantidadMinima = Convert.ToDouble(txtCantidadMinima.Text.Trim())                
                    };

                    var response = servicio.ArticuloInsert(objArticulo);

                    if (response.IsValid)
                    {
                        MessageBox.Show("Proceso realizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error: " + response.ErrorMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Completar todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
