using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD.GA.GUI.GA.Almacen
{
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }

        private void BtnAlmbutton1_Click(object sender, EventArgs e)
        {
            Hide();
            GA.Almacen.Articulos articulo1 = new Articulos();
            articulo1.ShowDialog();
            Show();
        }

        private void BtnAlmbutton2_Click(object sender, EventArgs e)
        {
            Hide();
            GA.Almacen.Est_Ingreso.RptEstadIngreso rptEstIngreso= new Est_Ingreso.RptEstadIngreso();
            rptEstIngreso.ShowDialog();
            Show();
        }

        private void BtnAlmbutton3_Click(object sender, EventArgs e)
        {
            Hide();
            GA.Almacen.Est_Egreso.RptEstadEgreso rptEstEgreso = new Est_Egreso.RptEstadEgreso();
            rptEstEgreso.ShowDialog();
            Show();
        }
    }
}
