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
using MD.GA.COMMOM;
using MD.GA.SERVICES;

namespace MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.Proveedores
{
    public partial class CrearProveedor : Form
    {
        IServiceAlmacen servicio = new ServiceAlmacen();
        private List<BANCO> lstBanco;

        public CrearProveedor()
        {
            InitializeComponent();
        }

        private void btnCrePro2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearProveedor_Load(object sender, EventArgs e)
        {
            txtRazonSocial.Focus();
            cboTipoCuenta.SelectedIndex = 0;
            LoadBancos();


        }

        private void LoadBancos()
        {
            var result = servicio.BancoGetAll();
            if (result.IsValid)
            {
                lstBanco = result.Value;
                BindToCombo();
            }
            else
            {
                MessageBox.Show(result.ErrorMensaje, "Error, se cerrara ventana");
                this.Close();
            }
        }

        private void BindToCombo()
        {
            lstBanco.Insert(0, new BANCO()
            {
                Id_Banco = 0,
                Nombre = "[--Seleccione--]"
            });
            cboBanco.DataSource = lstBanco;
            cboBanco.DisplayMember = "Nombre";
        }


        private bool ValidarDatos()
        {
            if (txtRazonSocial.Text.ToUpper().Trim().Equals(string.Empty))
                return false;
            if (txtDireccion.Text.ToUpper().Equals(string.Empty))
                return false;
            if (txtRuc.Text.ToUpper().Equals(string.Empty))
                return false;
            if (txtTelefono.Text.ToUpper().Equals(string.Empty))
                return false;
            if (txtContacto.Text.ToUpper().Equals(string.Empty))
                return false;
            if (cboBanco.SelectedIndex != 0 && txtNumeroCuenta.Equals(string.Empty))
            {
                return false;
            }
            if (cboBanco.SelectedIndex != 0 && cboTipoCuenta.SelectedIndex == 0)
            {
                return false;
            }
            return true;
        }

        private void createProveedor()
        {
            if(ValidarDatos())
            {
                Proveedor objProveedor = new Proveedor()
                {
                    RazonSocial = txtRazonSocial.Text.ToString().Trim(),
                    RUC = txtRuc.Text.ToString().Trim(),
                    Direccion = txtDireccion.Text.ToString().Trim(),
                    Telefono = txtTelefono.Text.ToString().Trim(),
                    Contact = txtContacto.Text.ToString().Trim(),
                    UsuarioCreacion = Session.CurrentSession.Usuario.Usuario1,
                    FechaCreacion = DateTime.Now,
                    UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1,
                    FechaModificacion = DateTime.Now,
                    Estado = "A"
                };

                if (cboBanco.SelectedIndex != 0)
                {
                    objProveedor.BANCO = cboBanco.SelectedItem as BANCO;
                    objProveedor.TipoCuenta = cboTipoCuenta.SelectedIndex == 1 ? "S" : "D";
                    objProveedor.NumeroCuenta = txtNumeroCuenta.Text;
                }
                


                try
                {
                    var response = servicio.ProveedorInsert(objProveedor);

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
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Completar todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrePro1_Click(object sender, EventArgs e)
        {
            createProveedor();
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
