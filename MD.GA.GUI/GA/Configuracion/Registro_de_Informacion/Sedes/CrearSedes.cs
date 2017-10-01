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

namespace MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.Sedes
{
    public partial class CrearSedes : Form
    {
        IServiceAlmacen servicio = new ServiceAlmacen();

        public CrearSedes()
        {
            InitializeComponent();
        }

        private void btnCreSede2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreSede1_Click(object sender, EventArgs e)
        {
            createSede();
        }

        private bool ValidarCampos()
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

        public void createSede()
        {
            if (ValidarCampos())
            {
                try
                {
                    Sede objSede = new Sede()
                    {
                        NombreSede = txtNombreSede.Text.ToString().ToUpper().Trim(),
                        Codigo = txtCodigo.Text.ToString().ToUpper().Trim(),
                        Direccion = txtDireccion.Text.ToString().ToUpper().Trim(),
                        TELEFONO = txtTelefono.Text.ToString().ToUpper().Trim(),
                        UsuarioCreacion = Session.CurrentSession.Usuario.Usuario1,
                        FechaCreacion = DateTime.Now,
                        UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1,
                        FechaModificacion = DateTime.Now,
                        Estado = "A"
                    };

                    var response = servicio.SedeInsert(objSede);

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

        private void CrearSedes_Load(object sender, EventArgs e)
        {
            txtNombreSede.Focus();
        }
    }
}
