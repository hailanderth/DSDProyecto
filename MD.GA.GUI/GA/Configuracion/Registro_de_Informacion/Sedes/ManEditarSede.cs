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
namespace MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.Sedes
{
    public partial class ManEditarSede : Form
    {
        IServiceAlmacen servicio = new ServiceAlmacen();
        Sede sede = null;

        public ManEditarSede(Sede sede)
        {
            this.sede = sede;
            InitializeComponent();
        }

        private void ManEditarSede_Load(object sender, EventArgs e)
        {
            LoadData();
            txtNombreSede.Focus();
        }

        public void LoadData()
        {
            txtNombreSede.Text = sede.NombreSede;
            txtDireccion.Text = sede.Direccion;
            txtTelefono.Text = sede.TELEFONO.ToString();
            txtCodigo.Text = sede.Codigo;
        }

        public bool ValidarCampos()
        {
            if (txtNombreSede.Text.ToUpper().Trim().Equals(string.Empty))
                return false;
            if (txtDireccion.Text.ToUpper().Equals(string.Empty))
                return false;
            if (txtTelefono.Text.ToUpper().Equals(string.Empty))
                return false;
            if (txtCodigo.Text.ToUpper().Equals(string.Empty))
                return false;
            return true;
        }

        public void EditSede()
        {
            if (ValidarCampos())
            {
                sede.NombreSede = txtNombreSede.Text.ToString().ToUpper().Trim();
                sede.Direccion = txtDireccion.Text.ToString().ToUpper().Trim();
                sede.TELEFONO = txtTelefono.Text.ToString().ToUpper().Trim();
                sede.Codigo = txtCodigo.Text.ToString().ToUpper().Trim();
                sede.UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1;
                sede.FechaModificacion = DateTime.Now;
                sede.Estado = "A";

                var response = servicio.SedeUpdate(sede);

                try
                {
                    if (response.IsValid)
                    {
                        MessageBox.Show("Proceso realizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(response.ErrorMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EditarSedes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCreSede1_Click(object sender, EventArgs e)
        {
            EditSede();
        }

        private void btnCreSede2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
