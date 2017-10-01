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

namespace MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.RazSocial
{
    public partial class CrearRazSocial : Form
    {
        IServiceAlmacen servicio = new ServiceAlmacen();

        public CrearRazSocial()
        {
            InitializeComponent();
        }

        private void BtnNueArt2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNueArt1_Click(object sender, EventArgs e)
        {
            createEmpresa();
        }

        private bool ValidarCampos()
        {
            if (txtRazonSocial.Text.ToUpper().Trim().Equals(string.Empty))
                return false;
            if (txtRuc.Text.ToUpper().Equals(string.Empty))
                return false;
            return true;
        }

        private void createEmpresa()
        {
            if (ValidarCampos())
            {
                try
                {
                    Empresa objEmpresa = new Empresa()
                    {
                        RazonSocial = txtRazonSocial.Text.ToUpper().Trim(),
                        RUC = txtRuc.Text.ToUpper().Trim(),
                        UsuarioCreacion = Session.CurrentSession.Usuario.Usuario1,
                        FechaCreacion = DateTime.Now,
                        UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1,
                        FechaModificacion = DateTime.Now,
                        Estado = "A"
                    };

                    var response = servicio.EmpresaInsert(objEmpresa);

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

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CrearRazSocial_Load(object sender, EventArgs e)
        {
            txtRazonSocial.Focus();
        }
    }
}
