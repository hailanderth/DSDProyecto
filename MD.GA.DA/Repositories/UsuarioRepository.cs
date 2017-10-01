using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MD.GA.DA.Base;
using MD.GA.BE.Entidades;
using MD.GA.DA.Interfaces;

namespace MD.GA.DA.Repositories
{
    public class UsuarioRepository :  IUsuarioRepository
    {
        public List<Usuario> GetAll()
        {
            return BaseRepository.dataBase.Usuarios.Include(u => u.Puesto).ToList();
        }

        public Usuario GetById(int id)
        {
            Usuario Usuario = BaseRepository.dataBase.Usuarios.Include(u => u.Puesto).FirstOrDefault(p => p.Id_Usuario == id);
            return Usuario;
        }

        public Usuario GetByUser(string user)
        {
            Usuario Usuario = BaseRepository.dataBase.Usuarios.Include(u => u.Puesto).FirstOrDefault(p => p.Usuario1 == user);
            return Usuario;
        }

        public Usuario GetByUser(string user, int idUserOriginal)
        {
            Usuario Usuario = BaseRepository.dataBase.Usuarios.Include(u => u.Puesto).FirstOrDefault(p => p.Usuario1 == user && p.Id_Usuario != idUserOriginal);
            return Usuario;
        }

        public void Insert(Usuario datos)
        {
            BaseRepository.dataBase.Usuarios.Add(datos);
            BaseRepository.dataBase.SaveChanges();
        }
        public void Update(Usuario datos)
        {
            Usuario result = BaseRepository.dataBase.Usuarios.Single(p => p.Id_Usuario == datos.Id_Usuario);
            BaseRepository.dataBase.Entry(result).CurrentValues.SetValues(datos);
            BaseRepository.dataBase.SaveChanges();
        }

        public Usuario ValidarLogin(string user, string password)
        {
            Usuario usuario = BaseRepository.dataBase.UsuarioValidarLogin(user, password).FirstOrDefault();
            return usuario;
        }

        public String GetPassEn(string clave)
        {
            System.Data.Entity.Core.Objects.ObjectParameter output = new System.Data.Entity.Core.Objects.ObjectParameter("pass", typeof(string));
            BaseRepository.dataBase.EncriptarPass(clave,output);
            return Convert.ToString(output.Value);
        }

        public String GetPassDes(string clave)
        {
            System.Data.Entity.Core.Objects.ObjectParameter output = new System.Data.Entity.Core.Objects.ObjectParameter("pass", typeof(string));
            BaseRepository.dataBase.DesencriptarPass(clave, output);
            return Convert.ToString(output.Value);
        }
    }
}
