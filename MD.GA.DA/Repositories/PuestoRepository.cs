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
    public class PuestoRepository :  IPuestoRepository
    {
        public List<Puesto> GetAll()
        {
            return BaseRepository.dataBase.Puestos.ToList();
        }

        public Puesto GetById(int id)
        {
            Puesto Puesto = BaseRepository.dataBase.Puestos.FirstOrDefault(p => p.Id_Puesto == id);
            return Puesto;
        }

        public Puesto GetByName(string name)
        {
            Puesto Puesto = BaseRepository.dataBase.Puestos.FirstOrDefault(p => p.NombrePuesto == name);
            return Puesto;
        }

        public Puesto GetByName(string name, int idPuestoOriginal)
        {
            Puesto Puesto = BaseRepository.dataBase.Puestos.FirstOrDefault(p => p.NombrePuesto == name && p.Id_Puesto != idPuestoOriginal);
            return Puesto;
        }

        public void Insert(Puesto datos)
        {
            BaseRepository.dataBase.Puestos.Add(datos);
            BaseRepository.dataBase.SaveChanges();
        }
        public void Update(Puesto datos)
        {
            BaseRepository.dataBase.Puestos.Attach(datos);
            var entry = BaseRepository.dataBase.Entry(datos);
            entry.State = EntityState.Modified;

            entry.Property(e => e.FechaCreacion).IsModified = false;
            entry.Property(e => e.UsuarioCreacion).IsModified = false;

            BaseRepository.dataBase.SaveChanges();
        }
    }
}
