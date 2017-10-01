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
    public class EmpresaRepository :  IEmpresaRepository
    {
        public List<Empresa> GetAll()
        {
            return BaseRepository.dataBase.Empresas.ToList();
        }

        public Empresa GetById(int id)
        {
            Empresa Empresa = BaseRepository.dataBase.Empresas.FirstOrDefault(p => p.Id_Empresa == id);
            return Empresa;
        }

        public Empresa GetByRazonSocialRUC(string RazonSocial, string RUC)
        {
            Empresa empresa = BaseRepository.dataBase.Empresas.FirstOrDefault(p => p.RazonSocial == RazonSocial || p.RUC == RUC);
            return empresa;
        }

        public Empresa GetByRazonSocialRUC(string RazonSocial, string RUC, int idEmpresaOriginal)
        {
            Empresa empresa = BaseRepository.dataBase.Empresas.FirstOrDefault(p => (p.RazonSocial == RazonSocial || p.RUC == RUC) && p.Id_Empresa != idEmpresaOriginal);
            return empresa;
        }

        public void Insert(Empresa datos)
        {
            BaseRepository.dataBase.Empresas.Add(datos);
            BaseRepository.dataBase.SaveChanges();
        }
        public void Update(Empresa datos)
        {
            BaseRepository.dataBase.Empresas.Attach(datos);
            var entry = BaseRepository.dataBase.Entry(datos);
            entry.State = EntityState.Modified;

            entry.Property(e => e.FechaCreacion).IsModified = false;
            entry.Property(e => e.UsuarioCreacion).IsModified = false;

            BaseRepository.dataBase.SaveChanges();
        }

    }
}
