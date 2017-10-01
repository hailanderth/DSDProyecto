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
using MD.GA.GUI.Session;
using System.Threading;
using MD.GA.BE.Entidades;

namespace MD.GA.GUI.GA
{
    public partial class login : Form
    {

        private String user;
        private String pass;
        private Usuario usuario;
        //comentario

        public login()
        {
            InitializeComponent();

        }


        private void capturarDatos() {
            user = txtlogin1.Text;
            pass = txtlogin2.Text;
        }

        private async void iniciarSesion()
        {

            //Primero ejecutar esta sección
            //una vez dentro del programa ir a mantenimientos y crear un usuario
            //de preferencia poner una clave de solo texto
            //luego descomentar la parte B y borrar la parte A
            //probar con el usuario que crearon

            try
            {

                //Parte A
                //usuario = new Usuario();

                //usuario.Usuario1 = "admin";
                //usuario.Password = "pass";

                //if (txtlogin1.Text == "admin" && txtlogin2.Text == "pass")
                //{
                //    CurrentSession.Usuario = usuario;
                //    this.Hide();
                //    GA.Menu_Principal menuprincipal = new Menu_Principal();
                //    menuprincipal.ShowDialog();
                //    this.Show();
                //}

                //else
                //{
                //    MessageBox.Show("Error", "Aviso");
                //}

                //Parte B
                using (IServiceAlmacen service = new ServiceAlmacen())
                {
                    capturarDatos();
                    //var response = await service.UsuarioValidarLoginAsync(user, pass);
                    ProxyUsuario.ServiceUsuarioClient proxy = new ProxyUsuario.ServiceUsuarioClient();
                    var response = await proxy.UsuarioValidarLoginAsync(user, pass);
                    if (response.IsValid)
                    {
                        CurrentSession.Usuario = response.Value;
                        this.Hide();
                        GA.Menu_Principal menuprincipal = new Menu_Principal();
                        menuprincipal.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show(response.Mensaje, "Aviso");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
        }
        private void btnlogin1_Click(object sender, EventArgs e)
        {
            iniciarSesion(); 
        }


        private async void login_Load(object sender, EventArgs e)
        {
            using (IServiceAlmacen service = new ServiceAlmacen())
            {
                var response = await service.UsuarioGetServerDateAsync();
            }
        }

        private void txtlogin2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToString(e.KeyChar) == "\r")
            {
                iniciarSesion();
            }
        }

    }
}
