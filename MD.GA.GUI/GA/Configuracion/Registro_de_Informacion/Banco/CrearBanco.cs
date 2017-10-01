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
    public partial class CrearBanco : Form
    {
        IServiceAlmacen servicio = new ServiceAlmacen();    
            
        public CrearBanco()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearBanco_Click(object sender, EventArgs e)
        {
            creaBanco();
        }
        private bool ValidarCampo()
        {
            if (txtBanco.Text.ToUpper().Equals(string.Empty))
                return false;
            return true;
        }
        private void creaBanco()
        {
            if (ValidarCampo())
            {
                try
                {
                    BANCO objBanco = new BANCO()
                    {
                        Nombre = txtBanco.Text.ToString().ToUpper().Trim(),
                        UsuarioCreacion = Session.CurrentSession.Usuario.Usuario1,
                        FechaCreacion = DateTime.Now,
                        UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1,
                        FechaModificacion = DateTime.Now,
                        Estado = "A"
                    };

                    var response = servicio.BancoInsert(objBanco);

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

        private void CrearBanco_Load(object sender, EventArgs e)
        {
            txtBanco.Focus();
        }
    }
}
