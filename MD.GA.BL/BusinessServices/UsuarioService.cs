using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.DA.Repositories;
using MD.GA.DA.Base;
using MD.GA.BE.Entidades;
using MD.GA.COMMOM.Response;
using MD.GA.BL.Util;
using MD.GA.BL.BusinessInterfaces;

namespace MD.GA.BL.BusinessServices
{
    public class UsuarioService : IUsuarioService
    {
        private UsuarioRepository usuarioRepository;
        public UsuarioService()
        {
            usuarioRepository = new UsuarioRepository();
        }
        public Response<Usuario> Delete(int id)
        {
            Response<Usuario> response = new Response<Usuario>();
            try
            {
                Usuario usuario = usuarioRepository.GetById(id);
                if (usuario == null)
                {
                    return response.Error("Usuario no encontrado");
                }
                usuario.Estado = "I";
                return Update(usuario);
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<List<Usuario>> GetAll()
        {
            Response<List<Usuario>> response = new Response<List<Usuario>>();
            try
            {
                response.Value = usuarioRepository.GetAll();
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<Usuario> GetById(int id)
        {
            Response<Usuario> response = new Response<Usuario>();
            try
            {
                Usuario usuario = usuarioRepository.GetById(id);
                if (usuario == null)
                {
                    return response.Error("Usuario no encontrado");
                }
                response.Value = usuario;
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<DateTime> GetServerTime()
        {
            Response<DateTime> response = new Response<DateTime>();
            response.Value = BaseRepository.GetServerDateTime();
            return response;
        }

        public String GetPass(string clave)
        {
            return usuarioRepository.GetPassEn(clave);
        }
        public String GetPassDes(string clave)
        { 
            return usuarioRepository.GetPassDes(clave);
        }

        public Response<Usuario> Insert(Usuario datos)
        {
            Response<Usuario> response = new Response<Usuario>();
            try
            {
                if (datos.Nombres.IsNullOrEmpty())
                {
                    return response.Error("El nombre es obligatorio");
                }
                if (datos.Apellidos.IsNullOrEmpty())
                {
                    return response.Error("El apellido es obligatorio");
                }
                if (datos.Estado.IsNullOrEmpty())
                {
                    return response.Error("El estado es obligatorio");
                }
                if (datos.Usuario1.IsNullOrEmpty())
                {
                    return response.Error("El usuario es obligatorio");
                }
                if (datos.Password.IsNullOrEmpty())
                {
                    return response.Error("El password es obligatorio");
                }
                if (datos.Puesto == null)
                {
                    return response.Error("El puesto es obligatorio");
                }
                if (usuarioRepository.GetByUser(datos.Usuario1) != null)
                {
                    return response.Error("El nombre de usuario ya existe");
                }
                if (datos.Usuario1.Length > 20)
                {
                    return response.Error("La longitud del usuario debe ser maximo de 20 caracteres");
                }

                datos.FechaCreacion = BaseRepository.GetServerDateTime();
                usuarioRepository.Insert(datos);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<Usuario> Login(string usuario, string password)
        {
            Response<Usuario> response = new Response<Usuario>();

            if (usuario.IsNullOrEmpty())
            {
                return response.Error("El campo usuario es requerido");
            }

            if (password.IsNullOrEmpty())
            {
                return response.Error("El campo password es requerido");
            }
            Usuario user = usuarioRepository.ValidarLogin(usuario, password);
            if (user == null)
            {
                return response.Error("Usuario o contraseña incorrecta");
            }
            response.Value = user;
            return response;
        }

        public Response<Usuario> Update(Usuario datos)
        {
            Response<Usuario> response = new Response<Usuario>();
            try
            {
                if (datos.Nombres.IsNullOrEmpty())
                {
                    return response.Error("El nombre es obligatorio");
                }
                if (datos.Apellidos.IsNullOrEmpty())
                {
                    return response.Error("El apellido es obligatorio");
                }
                if (datos.Estado.IsNullOrEmpty())
                {
                    return response.Error("El estado es obligatorio");
                }
                if (datos.Usuario1.IsNullOrEmpty())
                {
                    return response.Error("El usuario es obligatorio");
                }
                if (datos.Password.IsNullOrEmpty())
                {
                    return response.Error("El password es obligatorio");
                }
                if (datos.Puesto == null)
                {
                    return response.Error("El puesto es obligatorio");
                }
                if (usuarioRepository.GetByUser(datos.Usuario1, datos.Id_Usuario) != null)
                {
                    return response.Error("El nombre de usuario ya existe");
                }
                if (datos.Usuario1.Length > 20)
                {
                    return response.Error("La longitud del usuario debe ser maximo de 20 caracteres");
                }

                datos.FechaModificacion = BaseRepository.GetServerDateTime();
                usuarioRepository.Update(datos);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<Usuario> GetByUser(string nombreUsuario)
        {
            Response<Usuario> response = new Response<Usuario>();
            try
            {
                Usuario usuario = usuarioRepository.GetByUser(nombreUsuario);
                if (usuario == null)
                {
                    return response.Error("Usuario no encontrado");
                }
                response.Value = usuario;
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }
    }
}
