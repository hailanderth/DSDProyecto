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

namespace MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.Banco
{
    public partial class EditarBanco : Form
    {
        IServiceAlmacen servicio = new ServiceAlmacen();
        private BANCO banco = null;
        public EditarBanco(BANCO banco)
        {
            this.banco = banco;
            InitializeComponent();
        }
        private bool ValidarCampo()
        {
            if (txtBanco.Text.ToUpper().Equals(string.Empty))
                return false;
            return true;
        }
        public void LoadData()
        {
            txtBanco.Text = banco.Nombre;
        }
        public void editBanco()
        {
            if (ValidarCampo())
            {
                try
                {

                    banco.Nombre = txtBanco.Text.ToString().ToUpper().Trim();
                    banco.UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1;
                    banco.FechaModificacion = DateTime.Now;
                    banco.Estado = "A";

                    var response = servicio.BancoUpdate(banco);

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

        private void EditarBanco_Load(object sender, EventArgs e)
        {
            LoadData();
            txtBanco.Focus();
        }

        private void btnEditarBanco_Click(object sender, EventArgs e)
        {
            editBanco();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
