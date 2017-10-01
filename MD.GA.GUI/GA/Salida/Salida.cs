using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD.GA.GUI.GA.Salida
{
    public partial class Salida : Form
    {
        public Salida()
        {
            InitializeComponent();
        }

        private void btnSalida1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Salida.Registro_de_Salida.RegistrodeSalida registrodesalida = new Registro_de_Salida.RegistrodeSalida();
            registrodesalida.ShowDialog();
            this.Show();
        }
    }
}
