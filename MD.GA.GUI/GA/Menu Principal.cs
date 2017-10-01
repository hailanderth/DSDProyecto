using MD.GA.GUI.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MD.GA.GUI.GA.Compras.Consulta_Compra;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD.GA.GUI.GA
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void BtnMpButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Almacen.Almacen almacen = new Almacen.Almacen();
            almacen.ShowDialog();
            this.Show();    
        }

        private void BtnMpButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Compras.Compras compras = new Compras.Compras();
            compras.ShowDialog();
            this.Show();
        }

        private void BtnMpbutton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Salida.Salida salida = new Salida.Salida();
            salida.ShowDialog();
            this.Show();
        }

        private void BtnMpButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GA.Configuracion.Configuracion configuracion = new Configuracion.Configuracion();
            configuracion.ShowDialog();
            this.Show();
        }

        private void Menu_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
          
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            EnableControlsByRol();
        }

        private void EnableControlsByRol()
        {
            if (CurrentSession.Usuario.Id_Puesto == (int)Roles.Administrador)
            {
                BtnMpConfi.Visible = true;
            }
            else if (CurrentSession.Usuario.Id_Puesto == (int)Roles.Operador)
            {
                BtnMpConfi.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsulCompra frmConsultaCompra = new ConsulCompra();
            this.Hide();
            frmConsultaCompra.ShowDialog();
            this.Show();
        }
    }
}
