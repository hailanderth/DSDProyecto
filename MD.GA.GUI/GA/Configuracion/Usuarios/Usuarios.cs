using MD.GA.BE.Entidades;
using MD.GA.SERVICES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD.GA.GUI.GA.Configuracion.Usuarios
{
    public partial class Usuarios : Form
    {

        IServiceAlmacen servicio = new ServiceAlmacen();

        public Usuarios()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Configuracion.Usuarios.CrearUsuario crearUsuario = new CrearUsuario();
            crearUsuario.ShowDialog();
            this.Show();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            ConfiguracionGrilla();
            CargarComboUsuario();
            //CargarGrilla();
        }

        private async void CargarGrilla()
        {
            try
            {
                List<Usuario> listaUsuario;
                var responseLista = await servicio.UsuarioGetAllAsync();
                listaUsuario = responseLista.Value;
                dgvUsuario.DataSource = listaUsuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataGridViewRow row in dgvUsuario.Rows)
            {
                string estado = row.Cells[8].Value.ToString();
                int puesto = Convert.ToInt32(row.Cells[6].Value);

                if (estado.Equals("A"))
                {
                    row.Cells[9].Value = "Activo";
                }
                else
                {
                    row.Cells[9].Value = "Inactivo";
                }

                if(puesto == 1)
                {
                    row.Cells[7].Value = "Administrador";
                }
                else
                {
                    row.Cells[7].Value = "Operador";
                }
            }
        }

        private void ConfiguracionGrilla()
        {
            dgvUsuario.AutoGenerateColumns = false;
        }

        private async void CargarComboUsuario()
        {
            try
            {
                List<Usuario> listaUsuario;
                var responseLista = await servicio.UsuarioGetAllAsync();
                listaUsuario = responseLista.Value;
                cboUsuario.DataSource = listaUsuario;

                Usuario objUsuario = new Usuario()
                {
                    Id_Usuario = 0,
                    Nombres = "--- Todos ---"
                };

                listaUsuario.Insert(0, objUsuario);
                cboUsuario.DisplayMember = "NombreApellidos";
                cboUsuario.ValueMember = "Id_Usuario";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            List<Usuario> listaUsuario = new List<Usuario>();

            if(cboUsuario.SelectedIndex == 0)
            {
                listaUsuario = servicio.UsuarioGetAll().Value;
            }
            else
            {
                int idUsuario = Convert.ToInt32(cboUsuario.SelectedValue);
                Usuario usuario = servicio.UsuarioGetById(idUsuario).Value;
                listaUsuario.Add(usuario);
            }

            dgvUsuario.DataSource = listaUsuario;

            foreach (DataGridViewRow row in dgvUsuario.Rows)
            {
                string estado = row.Cells[8].Value.ToString();
                int puesto = Convert.ToInt32(row.Cells[6].Value);

                if (estado.Equals("A"))
                {
                    row.Cells[9].Value = "Activo";
                }
                else
                {
                    row.Cells[9].Value = "Inactivo";
                }

                if (puesto == 1)
                {
                    row.Cells[7].Value = "Administrador";
                }
                else
                {
                    row.Cells[7].Value = "Operador";
                }
            }
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idUsuario = Convert.ToInt32(dgvUsuario.CurrentRow.Cells["Id_Usuario"].Value);
            try
            {
                if (e.ColumnIndex == 1)
                {
                    Usuario usuario = (Usuario)dgvUsuario.CurrentRow.DataBoundItem;
                    EditarUsuario editarUsuario = new EditarUsuario(usuario);
                    editarUsuario.ShowDialog();
                    CargarGrilla();
                }
                else if (e.ColumnIndex == 2)
                {
                    if (servicio.UsuarioDelete(idUsuario).IsValid)
                    {
                        MessageBox.Show("El usuario se eliminó correctamente");
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Hubo inconvenientes al eliminar el usuario, por favor intente nuevamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
