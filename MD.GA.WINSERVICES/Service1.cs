using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Messaging;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MD.GA.WINSERVICES
{
    public partial class MedicalCompras : ServiceBase
    {
        Timer timer;
        public MedicalCompras()
        {
            InitializeComponent();
            InitializeComponent();
            timer = new Timer(30000);
            timer.AutoReset = true;
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Enabled = true;
            timer.Start();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
            timer.Stop();
            timer = null;
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            NotificarOrdenCompra();
        }

        private void NotificarOrdenCompra()
        {
            try
            {
                string rutaCola = @".\private$\wmorales";
                if (!MessageQueue.Exists(rutaCola))
                    MessageQueue.Create(rutaCola);

                MessageQueue cola = new MessageQueue(rutaCola);
                cola.Formatter = new XmlMessageFormatter(new Type[] { typeof(List<Pedido>) });
                var mensajes = cola.GetAllMessages();
                if (mensajes != null && mensajes.Length > 0)
                {
                    foreach (var mensaje in mensajes)
                    {
                        List<Pedido> ListaPedido = (List<Pedido>)mensaje.Body;
                    }
                }
                cola.Purge();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
