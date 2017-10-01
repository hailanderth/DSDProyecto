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
    public partial class Editar_Articulo : Form
    {
        Articulo articulo = null;
        IServiceAlmacen service = new ServiceAlmacen();

        public Editar_Articulo(Articulo articulo)
        {
            this.articulo = articulo;
            InitializeComponent();
        }

        private void Editar_Articulo_Load(object sender, EventArgs e)
        {
            InitializeCulture();
            SetIndexCombo();
            CargarComboArea();
            CargarComboUnidadMedida();
            LoadData();
            cboArea.Focus();
            EnableControlsByRol();
        }

        public void InitializeCulture()
        {
            var culture = CultureInfo.CreateSpecificCulture("es-ES");
            culture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            culture.NumberFormat.NumberDecimalDigits = 2;

        }

        private void BtnEdiArt2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnableControlsByRol()
        {
            if (CurrentSession.Usuario.Id_Puesto == (int)Roles.Administrador)
            {
                HabilitarControles();
            }
            else if (CurrentSession.Usuario.Id_Puesto == (int)Roles.Operador)
            {
                DeshabilitarControles();
            }
        }

        public void LoadData()
        {
            cboArea.SelectedValue = articulo.Id_Area;
            cboUnidadMedida.SelectedValue = articulo.Id_UnidadMedida;
            txtDescripcion.Text = articulo.Descripcion;
            txtMarca.Text = articulo.Marca.ToString(); ;
            txtCantidadMinima.Text = articulo.CantidadMinima.ToString();
            txtCosto.Text = articulo.Costo.ToString();
            txtStock.Text = articulo.Stock.ToString();
            cboArtMoneda.SelectedIndex = articulo.Moneda == "S" ? 1 : 2;
        }

        private void CargarComboArea()
        {
            try
            {
                List<Area> listaArea;

                listaArea = service.ComboArea();
                cboArea.DataSource = listaArea;
                cboArea.DisplayMember = "NombreArea";
                cboArea.ValueMember = "Id_Area";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetIndexCombo()
        {
            cboArtMoneda.SelectedIndex = 0;
        }

        private void CargarComboUnidadMedida()
        {
            try
            {
                List<UnidadMedida> listaUnidadMedida;

                listaUnidadMedida = service.ComboUnidadMedida();
                cboUnidadMedida.DataSource = listaUnidadMedida;
                cboUnidadMedida.DisplayMember = "Descripcion";
                cboUnidadMedida.ValueMember = "Id_UnidadMedida";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdiArt1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {

                    articulo.Descripcion = txtDescripcion.Text.ToString().ToUpper().Trim();
                    articulo.Moneda = cboArtMoneda.SelectedIndex == 1 ? "S" : "D";
                    articulo.Stock = Convert.ToDouble(txtStock.Text.ToString().Trim());
                    articulo.Costo = Convert.ToDecimal(txtCosto.Text.Trim());
                    articulo.Marca = txtMarca.Text.ToUpper().Trim().ToString();
                    articulo.UsuarioCreacion = Session.CurrentSession.Usuario.Usuario1;
                    articulo.FechaCreacion = DateTime.Now;
                    articulo.UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1;
                    articulo.FechaModificacion = DateTime.Now;
                    articulo.Estado = "A";
                    articulo.Id_Area = Convert.ToInt32(cboArea.SelectedValue);
                    articulo.Id_UnidadMedida = Convert.ToInt32(cboUnidadMedida.SelectedValue);
                    articulo.Area = cboArea.SelectedItem as Area;
                    articulo.UnidadMedida = cboUnidadMedida.SelectedItem as UnidadMedida;
                    articulo.CantidadMinima = Convert.ToDouble(txtCantidadMinima.Text.Trim());

                    var response = service.ArticuloUpdate(articulo);

                    if (response.IsValid)
                    {
                        MessageBox.Show("Proceso realizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error" + response.ErrorMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void DeshabilitarControles()
        {
            cboArea.Enabled = false;
            cboUnidadMedida.Enabled = false;
            cboArtMoneda.Enabled = false;
            txtMarca.Enabled = false;
            txtDescripcion.Enabled = false;
            txtCantidadMinima.Enabled = false;
            txtStock.Enabled = false;
            txtCosto.Enabled = false;
            BtnEdiArt1.Enabled = false;
        }

        public void HabilitarControles()
        {
            cboArea.Enabled = true;
            cboUnidadMedida.Enabled = true;
            cboArtMoneda.Enabled = true;
            txtMarca.Enabled = true;
            txtDescripcion.Enabled = true;
            txtCantidadMinima.Enabled = true;
            txtStock.Enabled = true;
            txtCosto.Enabled = true;
            BtnEdiArt1.Enabled = true;
        }
    }
}
