using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD.GA.GUI.GA.Configuracion
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void BtnConfi1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Configuracion.Registro_de_Informacion.Registrodeinformacion registroInfo = new Registro_de_Informacion.Registrodeinformacion();

            registroInfo.ShowDialog();
            this.Show();
        }

        private void BtnConfi2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Configuracion.Usuarios.Usuarios usuarios = new Usuarios.Usuarios();
            usuarios.ShowDialog();
            this.Show();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {

        }
    }
}
