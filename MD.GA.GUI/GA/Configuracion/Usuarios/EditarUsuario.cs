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

namespace MD.GA.GUI.GA.Configuracion.Usuarios
{
    public partial class EditarUsuario : Form
    {
        IServiceAlmacen servicio = new ServiceAlmacen();
        Usuario usuario = null;

        public EditarUsuario(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void LblEdiUsu1_Click(object sender, EventArgs e)
        {

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            CargarPuesto();
            LoadData();
            cboPuesto.Focus();
            txtUsuario.Enabled = false;
        }

        private void LoadData()
        {
            
            cboPuesto.SelectedValue = usuario.Id_Puesto;
            txtNombre.Text = usuario.Nombres;
            txtApellidos.Text = usuario.Apellidos;
            txtContraseña.Text = desencriptar(usuario.Password);
            txtContraseña2.Text = desencriptar(usuario.Password);
            txtUsuario.Text = usuario.Usuario1;
        }

        public void CargarPuesto()
        {
            List<Puesto> listaPuesto = new List<Puesto>();

            listaPuesto = servicio.PuestoGetAll();

            cboPuesto.DataSource = listaPuesto;
            cboPuesto.DisplayMember = "NombrePuesto";
            cboPuesto.ValueMember = "Id_Puesto";
        }

        private String encriptar(string encp)
        {
            return servicio.GetPass(encp);
        }
        private String desencriptar(string encp)
        {
            return servicio.GetPassDes(encp);
        }
        public void UpdateUsuario()
        {
            if (ValidarCampos())
            {

                usuario.Nombres = txtNombre.Text.ToUpper().Trim();
                usuario.Apellidos = txtApellidos.Text.ToUpper().Trim();
                usuario.Usuario1 = txtUsuario.Text.ToUpper().Trim();
                usuario.Password = encriptar(txtContraseña.Text.ToUpper().Trim());
                usuario.Puesto = cboPuesto.SelectedItem as Puesto;
                usuario.Id_Puesto = usuario.Puesto.Id_Puesto;
                usuario.UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1;
                usuario.FechaModificacion = DateTime.Now;
                usuario.Estado = "A";

                var response = servicio.UsuarioUpdate(usuario);
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

        public bool ValidarCampos()
        {
            if (Convert.ToInt32(cboPuesto.SelectedValue)==0)
                return false;
            if (txtNombre.Text.Trim().Equals(string.Empty))
                return false;
            if (txtApellidos.Text.Trim().Equals(string.Empty))
                return false;
            if (txtUsuario.Text.Trim().Equals(string.Empty))
                return false;
            if (txtContraseña.Text.Trim().Equals(string.Empty))
                return false;
            if (txtContraseña2.Text.Trim().Equals(string.Empty))
                return false;
            if (txtContraseña.Text != txtContraseña2.Text)
                return false;
            return true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            UpdateUsuario();
        }

        private void btnEdiUsu2_Click(object sender, EventArgs e)
        {
            this.Close();
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
