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
    public partial class CrearUniMedida : Form
    {
        IServiceAlmacen servicio = new ServiceAlmacen();

        public CrearUniMedida()
        {
            InitializeComponent();
        }

        private void btnCreUMed2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreUMed1_Click(object sender, EventArgs e)
        {
            createUnidadMedida();
        }

        private bool ValidarCampo()
        {
            if (txtUnidadMedida.Text.ToUpper().Equals(string.Empty))
                return false;
            return true;
        }

        private void createUnidadMedida()
        {
            if (ValidarCampo())
            {
                try
                {
                    UnidadMedida objUnidadMedida = new UnidadMedida()
                    {
                        Descripcion = txtUnidadMedida.Text.ToString().ToUpper().Trim(),
                        UsuarioCreacion = Session.CurrentSession.Usuario.Usuario1,
                        FechaCreacion = DateTime.Now,
                        UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1,
                        FechaModificacion = DateTime.Now,
                        Estado = "A"
                    };

                    var response = servicio.UnidadMedidaInsert(objUnidadMedida);

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

        private void CrearUniMedida_Load(object sender, EventArgs e)
        {
            txtUnidadMedida.Focus();
        }
    }
}
