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

namespace MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.ManArea
{
    public partial class EditarArea : Form
    {
        IServiceAlmacen servicio = new ServiceAlmacen();
        private Area area = null;

        public EditarArea(Area area)
        {
            this.area = area;
            InitializeComponent();
        }

        private void EditarArea_Load(object sender, EventArgs e)
        {
            LoadData();
            txtCodArea.Focus();
        }

        public void LoadData()
        {
            txtCodArea.Text = area.CodArea;
            txtNombreArea.Text = area.NombreArea;
        }

        private bool ValidarDatos()
        {
            if (txtCodArea.Text.Trim().Equals(string.Empty))
                return false;
            if (txtNombreArea.Text.Trim().Equals(string.Empty))
                return false;
            return true;
        }

        public void EditArea()
        {
            if(ValidarDatos())
            {
                area.CodArea = txtCodArea.Text.ToUpper().Trim().ToString();
                area.NombreArea  = txtNombreArea.Text.ToUpper().Trim().ToString();
                area.UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1;
                area.FechaModificacion = DateTime.Now;
                area.Estado = "A";

                
                try
                {
                    var response = servicio.AreaUpdate(area);

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

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            EditArea();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
