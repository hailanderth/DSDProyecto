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
    public partial class EditarRazSocial : Form
    {

        IServiceAlmacen servicio = new ServiceAlmacen();
        Empresa empresa = null;

        public EditarRazSocial(Empresa empresa)
        {
            this.empresa = empresa;
            InitializeComponent();
        }

        private void EditarRazSocial_Load(object sender, EventArgs e)
        {
            LoadData();
            txtRazonSocial.Focus();
        }

        public void LoadData()
        {
            txtRazonSocial.Text = empresa.RazonSocial;
            txtRuc.Text = empresa.RUC;
        }

        private bool ValidarCampos()
        {
            if (txtRazonSocial.Text.ToUpper().Trim().Equals(string.Empty))
                return false;
            if (txtRuc.Text.ToUpper().Equals(string.Empty))
                return false;
            return true;
        }

        public void EditEmpresa()
        {
            if(ValidarCampos())
            {
                try
                {
                    empresa.RazonSocial = txtRazonSocial.Text.ToString().ToUpper().Trim();
                    empresa.RUC = txtRuc.Text.ToString().ToUpper().Trim();
                    empresa.UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1;
                    empresa.FechaModificacion = DateTime.Now;
                    empresa.Estado = "A";

                    var response = servicio.EmpresaUpdate(empresa);

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

        private void BtnNueArt1_Click(object sender, EventArgs e)
        {
            EditEmpresa();
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnNueArt2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
