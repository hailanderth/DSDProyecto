using MD.GA.BE.Entidades;
using MD.GA.BL.BusinessInterfaces;
using MD.GA.BL.BusinessServices;
using MD.GA.COMMOM.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
//using System.ServiceModel;
using System.Text;

namespace MD.GA.WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceUsuario" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceUsuario.svc o ServiceUsuario.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceUsuario : IServiceUsuario
    {
        private IUsuarioService usuarioService;
        public ServiceUsuario()
        {
            this.usuarioService = new UsuarioService();
        }

        public void DoWork()
        {
        }

        public Response<Usuario> UsuarioValidarLogin(string usuario, string password)
        {

            try
            {
                var response = usuarioService.Login(usuario, password);
                var valor = response.Value;
                // response.
                Usuario oUsuario = new Usuario();
                bool estado = false;
                string mensaje = "Usuario o clave incorrrecto";
                if (valor != null)
                {
                    mensaje = "";
                    oUsuario.Apellidos = valor.Apellidos;
                    oUsuario.Estado = valor.Estado;
                    oUsuario.FechaCreacion = valor.FechaCreacion;
                    oUsuario.FechaModificacion = valor.FechaModificacion;
                    oUsuario.Id_Puesto = valor.Id_Puesto;
                    oUsuario.Nombres = valor.Nombres;
                    oUsuario.Password = valor.Password;
                    //oUsuario.Puesto = valor.Puesto;
                    oUsuario.Usuario1 = valor.Usuario1;
                    oUsuario.UsuarioCreacion = valor.UsuarioCreacion;
                    oUsuario.UsuarioModificacion = valor.UsuarioModificacion;
                    estado = true;
                }
                response.Value = oUsuario;
                response.IsValid = estado;
                response.Mensaje = mensaje;
                return response;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
