using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MD.GA.DA.Base;
using MD.GA.BE.Entidades;
using MD.GA.DA.Interfaces;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace MD.GA.DA.Repositories
{
    public class SedeRepository :  ISedeRepository
    {
        public List<Sede> GetAll()
        {
            return BaseRepository.dataBase.Sedes.ToList();
        }

        public Sede GetByCodigo(string codigo)
        {
            Sede sede = BaseRepository.dataBase.Sedes.FirstOrDefault(p => p.Codigo == codigo);
            return sede;
        }

        public Sede GetByCodigo(string codigo, int idSedeOriginal)
        {
            Sede sede = BaseRepository.dataBase.Sedes.FirstOrDefault(p => p.Codigo == codigo && p.Id_Sede == idSedeOriginal);
            return sede;
        }

        public Sede GetById(int id)
        {
            Sede sede = BaseRepository.dataBase.Sedes.FirstOrDefault(p => p.Id_Sede == id);
            return sede;
        }

        public Sede GetByName(string name)
        {
            Sede sede = BaseRepository.dataBase.Sedes.FirstOrDefault(p => p.NombreSede == name);
            return sede;
        }

        public Sede GetByName(string name, int idSedeOriginal)
        {
            Sede sede = BaseRepository.dataBase.Sedes.FirstOrDefault(p => p.NombreSede == name && p.Id_Sede != idSedeOriginal);
            return sede;
        }

        public void Insert(Sede datos)
        {
            BaseRepository.dataBase.Sedes.Add(datos);
            BaseRepository.dataBase.SaveChanges();
        }

        public void Update(Sede datos)
        {
            BaseRepository.dataBase.Sedes.Attach(datos);
            var entry = BaseRepository.dataBase.Entry(datos);
            entry.State = EntityState.Modified;

            entry.Property(e => e.FechaCreacion).IsModified = false;
            entry.Property(e => e.UsuarioCreacion).IsModified = false;

            BaseRepository.dataBase.SaveChanges();
        }
    }
}
