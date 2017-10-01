using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MD.GA.SERVICES;
using MD.GA.BE.Entidades;

namespace MD.GA.GUI.GA.Configuracion.Registro_de_Informacion.Proveedores
{
    public partial class EditarProveedor : Form
    {
        IServiceAlmacen servicio = new ServiceAlmacen();
        private Proveedor proveedor = new Proveedor();
        private List<BANCO> lstBanco;
        public EditarProveedor(Proveedor proveedor)
        {
            this.proveedor = proveedor;
            InitializeComponent();
        }

        private void EditarProveedor_Load(object sender, EventArgs e)
        {
            LoadData();
            txtRazonSocial.Focus();
        }

        public void LoadData()
        {
            txtRazonSocial.Text = proveedor.RazonSocial;
            txtRuc.Text = proveedor.RUC;
            txtDireccion.Text = proveedor.Direccion;
            txtTelefono.Text = proveedor.Telefono;
            txtContacto.Text = proveedor.Contact;
            var result = servicio.BancoGetAll();
            if (result.IsValid)
            {
                lstBanco = result.Value;
                lstBanco.Insert(0, new BANCO()
                {
                    Id_Banco = 0,
                    Nombre = "[--Seleccione--]"
                });
                cboBanco.DataSource = lstBanco;
                cboBanco.DisplayMember = "Nombre";
                cboBanco.ValueMember = "Id_Banco";
            }
            else
            {
                MessageBox.Show(result.ErrorMensaje, "Cerrando formulario");
            }
            if (proveedor.Id_Banco != null)
            {
                cboBanco.SelectedValue = proveedor.Id_Banco;
            }
            txtNumeroCuenta.Text = proveedor.NumeroCuenta;
            cboTipoCuenta.SelectedIndex = proveedor.TipoCuenta == "S" ? 1 : proveedor.TipoCuenta == "D"? 2 : 0;
        }

        private void txtEditar_Click(object sender, EventArgs e)
        {
            EditProveedor();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ValidarCampos()
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

        public void EditProveedor()
        {
            if (ValidarCampos())
            {
                proveedor.RazonSocial = txtRazonSocial.Text.ToUpper().Trim();
                proveedor.Direccion = txtDireccion.Text.ToUpper().Trim();
                proveedor.RUC = txtRuc.Text.ToUpper().Trim();
                proveedor.Telefono = txtTelefono.Text.ToUpper().Trim();
                proveedor.Contact = txtContacto.Text.ToUpper().Trim();
                proveedor.UsuarioModificacion = Session.CurrentSession.Usuario.Usuario1;
                proveedor.FechaModificacion = DateTime.Now;
                proveedor.Estado = "A";
                proveedor.NumeroCuenta = txtNumeroCuenta.Text.Trim();
                proveedor.TipoCuenta = cboTipoCuenta.SelectedIndex == 1 ? "S" : cboTipoCuenta.SelectedIndex == 2 ? "D" : null;
                if (cboBanco.SelectedIndex != 0)
                {
                    proveedor.Id_Banco = Convert.ToInt16(cboBanco.SelectedValue.ToString());
                }
                else
                {
                    proveedor.Id_Banco = null;
                }
                try
                {
                    var response = servicio.ProveedorUpdate(proveedor);

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

        private void cboBanco_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboBanco.SelectedIndex == 0)
            {
                cboTipoCuenta.SelectedIndex = 0;
                txtNumeroCuenta.Text = "";
            }
        }
    }
}
