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
    public partial class CrearArea : Form
    {
        IServiceAlmacen servicio = new ServiceAlmacen();

        public CrearArea()
        {
            InitializeComponent();
        }

        private void btnCreArea2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void CrearArea_Load(object sender, EventArgs e)
        {
            txtCod.Focus();
        }
    

        private bool ValidarDatos()
        {
            if (txtCod.Text.ToUpper().Trim().Equals(string.Empty))
                return false;
            if (txtNombre.Text.ToUpper().Equals(string.Empty))
                return false;
            return true;
        }

        private void createArea()
        {
            if (ValidarDatos())
            {
                Area objArea = new Area()
                {
                    CodArea = txtCod.Text.ToString().ToUpper().Trim(),
                    NombreArea = txtNombre.Text.ToString().ToUpper().Trim(),
                    UsuarioCreacion = Session.CurrentSession.Usuario.Usuario1,
                    FechaCreacion = DateTime.Now,
                    UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1,
                    FechaModificacion = DateTime.Now,
                    Estado = "A"
                };

                try
                {
                    var response = servicio.AreaInsert(objArea);

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

        private void btnCreArea1_Click(object sender, EventArgs e)
        {
            createArea();
        }
    }
}
