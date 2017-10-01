using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD.GA.GUI.GA.Compras
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void BtnAlmbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Compras.presupuesto.Presupuesto presupuesto = new presupuesto.Presupuesto();
            presupuesto.ShowDialog();
            this.Show();
        }

        private void BtnAlmbutton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Compras.Ord_Compra.ConfPresupuesto confPresupuesto = new Ord_Compra.ConfPresupuesto("ordenCompra");
            confPresupuesto.ShowDialog();
            this.Show();
        }

        private void BtnAlmbutton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Compras.Consulta_Compra.ConsulCompra consulcompra = new Consulta_Compra.ConsulCompra();
            consulcompra.ShowDialog();
            this.Show();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            GA.Compras.Ord_Compra.ConfPresupuesto confPresupuesto = new Ord_Compra.ConfPresupuesto("editarPresupuesto");
            confPresupuesto.ShowDialog();
            this.Show();
        }
    }
}
