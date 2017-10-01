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

namespace MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.UniMedida
{
    public partial class EditarUniMedida : Form
    {
        IServiceAlmacen servicio = new ServiceAlmacen();
        private UnidadMedida unidadMedida = null;

        public EditarUniMedida(UnidadMedida unidadMedida)
        {
            this.unidadMedida = unidadMedida;
            InitializeComponent();
        }

        private void btnEdiUMed1_Click(object sender, EventArgs e)
        {
            EditUnidadMedida();
        }

        private bool ValidarCampo()
        {
            if (txtUnidadMedida.Text.ToUpper().Equals(string.Empty))
                return false;
            return true;
        }

        public void LoadData()
        {
            txtUnidadMedida.Text = unidadMedida.Descripcion;
        }

        public void EditUnidadMedida()
        {
            if (ValidarCampo())
            {
                try
                {
                    
                    unidadMedida.Descripcion = txtUnidadMedida.Text.ToString().ToUpper().Trim();
                    unidadMedida.UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1;
                    unidadMedida.FechaModificacion = DateTime.Now;
                    unidadMedida.Estado = "A";

                    var response = servicio.UnidadMedidaUpdate(unidadMedida);

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

        private void EditarUniMedida_Load(object sender, EventArgs e)
        {
            LoadData();
            txtUnidadMedida.Focus();
        }

        private void btnEdiUMed2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
