using MD.GA.BE.Entidades;
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

namespace MD.GA.GUI.GA.Configuracion.Usuarios
{
    public partial class CrearUsuario : Form
    {
        IServiceAlmacen servicio = new ServiceAlmacen();

        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void btnCreUsu2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            CargarPuesto();
            cboPuesto.Focus();
        }

        public void CargarPuesto()
        {
            List<Puesto> listaPuesto = new List<Puesto>();

            listaPuesto = servicio.PuestoGetAll();

            cboPuesto.DataSource = listaPuesto;
            cboPuesto.DisplayMember = "NombrePuesto";
            cboPuesto.ValueMember = "Id_Puesto";
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            CreateUsuario();
        }

        public bool ValidarCampos()
        {
            if (Convert.ToInt32(cboPuesto.SelectedValue) == 0)
                return false;
            if (txtNombre.Text.Trim().Equals(string.Empty))
                return false;
            if (txtApellidos.Text.Trim().Equals(string.Empty))
                return false;
            if(txtUsuario.Text.Trim().Equals(string.Empty))
                return false;
            if (txtContraseña.Text.Trim().Equals(string.Empty))
                return false;
            if (txtContraseña2.Text.Trim().Equals(string.Empty))
                return false;
            if (txtContraseña.Text != txtContraseña2.Text)
                return false;
            return true;
        }
        private string encriptar(string encp)
        {
            return servicio.GetPass(encp);
        }
        public void CreateUsuario()
        {
            if (ValidarCampos())
            {
                Usuario usuario = new Usuario()
                {
                    Nombres = txtNombre.Text.ToUpper().Trim(),
                    Apellidos = txtApellidos.Text.ToUpper().Trim(),
                    Usuario1 = txtUsuario.Text.ToUpper().Trim(),
                    Password = encriptar(txtContraseña.Text.ToUpper().Trim()),
                    Puesto = cboPuesto.SelectedItem as Puesto,
                    Id_Puesto = cboPuesto.SelectedIndex,
                    UsuarioCreacion = Session.CurrentSession.Usuario.Usuario1,
                    FechaCreacion = DateTime.Now,
                    UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1,
                    FechaModificacion = DateTime.Now,
                    Estado = "A"
                };

                var response = servicio.UsuarioInsert(usuario);

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
            else
            {
                MessageBox.Show("Completar todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarPass_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar == '*' && txtContraseña2.PasswordChar == '*')
            {
                txtContraseña.PasswordChar = '\0';
                txtContraseña2.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '*';
                txtContraseña2.PasswordChar = '*';
            }
        }
    }
}
