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
    public class AreaRepository : IAreaRepository
    {

        public List<Area> GetAll()
        {
            //return dataBase.SP_GetAllAreaByEstado().ToList();
            return BaseRepository.dataBase.Areas.ToList();
        }

        public List<Area> GetAreaByEstado()
        {
            //return dataBase.SP_GetAllAreaByEstado()ToList();
            throw new NotImplementedException();
        }

        public Area GetById(int id)
        {
            Area area = BaseRepository.dataBase.Areas.FirstOrDefault(p => p.Id_Area == id);
            return area;
        }

        public Area GetByName(string name)
        {
            Area area = BaseRepository.dataBase.Areas.FirstOrDefault(p => p.NombreArea == name);
            return area;
        }

        public Area GetByName(string name, int idAreaOriginal)
        {
            Area area = BaseRepository.dataBase.Areas.FirstOrDefault(p => p.NombreArea == name && p.Id_Area != idAreaOriginal);
            return area;
        }

        public void Insert(Area datos)
        {
            BaseRepository.dataBase.Areas.Add(datos);
            BaseRepository.dataBase.SaveChanges();
        }
        public void Update(Area datos)
        {
            BaseRepository.dataBase.Areas.Attach(datos);
            var entry = BaseRepository.dataBase.Entry(datos);
            entry.State = EntityState.Modified;

            entry.Property(e => e.FechaCreacion).IsModified = false;
            entry.Property(e => e.UsuarioCreacion).IsModified = false;

            BaseRepository.dataBase.SaveChanges();
        }
    }
}
