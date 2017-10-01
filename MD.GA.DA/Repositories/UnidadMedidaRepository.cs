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
    public class UnidadMedidaRepository :  IUnidadMedidaRepository
    {
        public List<UnidadMedida> GetAll()
        {
            return BaseRepository.dataBase.UnidadMedidas.ToList();
        }

        public UnidadMedida GetById(int id)
        {
            UnidadMedida UnidadMedida = BaseRepository.dataBase.UnidadMedidas.FirstOrDefault(p => p.Id_UnidadMedida == id);
            return UnidadMedida;
        }

        public UnidadMedida GetByName(string nombre)
        {
            UnidadMedida UnidadMedida = BaseRepository.dataBase.UnidadMedidas.FirstOrDefault(p => p.Descripcion == nombre);
            return UnidadMedida;
        }

        public UnidadMedida GetByName(string nombre, int idUnidadMedidaOriginal)
        {
            UnidadMedida UnidadMedida = BaseRepository.dataBase.UnidadMedidas.FirstOrDefault(p => p.Descripcion == nombre && p.Id_UnidadMedida != idUnidadMedidaOriginal);
            return UnidadMedida;
        }

        public void Insert(UnidadMedida datos)
        {
            BaseRepository.dataBase.UnidadMedidas.Add(datos);
            BaseRepository.dataBase.SaveChanges();
        }
        public void Update(UnidadMedida datos)
        {
            BaseRepository.dataBase.UnidadMedidas.Attach(datos);
            var entry = BaseRepository.dataBase.Entry(datos);
            entry.State = EntityState.Modified;

            entry.Property(e => e.FechaCreacion).IsModified = false;
            entry.Property(e => e.UsuarioCreacion).IsModified = false;

            BaseRepository.dataBase.SaveChanges();
        }
    }
}
