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
using System.Globalization;
using System.Threading;
namespace MD.GA.GUI.GA.Compras.Ord_Compra
{
    public partial class ConfPresupuesto : Form
    {
        private Documento documento = null;

        public ConfPresupuesto(string valor)
        {
            InitializeComponent();
            this.valor = valor;
        }
        private string valor;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmarPresupuesto();
        }
        private async void ConfirmarPresupuesto()
        {
            if(ValidarCampos())
            {
                string tipoPre = "";
                int numDoc = Convert.ToInt32(txtPresupuesto.Text.Trim());

                if ((string)cboTipoPre.SelectedItem == "VARIOS")
                { tipoPre = "VAR"; }
                if ((string)cboTipoPre.SelectedItem == "PLACAS")
                { tipoPre = "PLA"; }
                if ((string)cboTipoPre.SelectedItem == "LABORATORIOS")
                { tipoPre = "LAB"; }

                IServiceAlmacen servicio = new ServiceAlmacen();

                var response = await servicio.PresupuestoProcesadoAsync("PR", tipoPre, numDoc);

                if (response.IsValid)
                {
                    documento = response.Value;
                    if (valor == "ordenCompra") { 

                    OrdenCompra ordenCompra = new OrdenCompra(documento);
                    ordenCompra.ShowDialog();

                    }else{

                    presupuesto.EditarPresupuesto editarPresupuesto = new presupuesto.EditarPresupuesto(documento);
                    editarPresupuesto.ShowDialog();
                    }
                }
                else
                {
                      MessageBox.Show(response.ErrorMensaje); 
                }
            }
            else
            {
                MessageBox.Show("Seleccione una opcíón válida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public bool ValidarCampos()
        {
            if (cboTipoPre.SelectedIndex == 0)
                return false;
            if (txtPresupuesto.Text.Trim().Equals(string.Empty))
                return false;
            return true;
        }

        private void txtPresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ConfPresupuesto_Load(object sender, EventArgs e)
        {
            cboTipoPre.SelectedIndex = 0;
        }
    }

}
