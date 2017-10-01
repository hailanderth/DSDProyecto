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
    public class ProveedorRepository : IProveedorRepository
    {
        public List<Proveedor> GetAll()
        {
            return BaseRepository.dataBase.Proveedores.ToList();
        }

        public Proveedor GetById(int id)
        {
            Proveedor proveedor = BaseRepository.dataBase.Proveedores.FirstOrDefault(p => p.Id_Proveedor == id);
            return proveedor;
        }

        public Proveedor GetByRazonSocialRUC(string RazonSocial, string RUC)
        {
            Proveedor proveedor = BaseRepository.dataBase.Proveedores.FirstOrDefault(p => p.RazonSocial == RazonSocial || p.RUC == RUC);
            return proveedor;
        }

        public Proveedor GetByRazonSocialRUC(string RazonSocial, string RUC, int idProveedorOriginal)
        {
            Proveedor proveedor = BaseRepository.dataBase.Proveedores.FirstOrDefault(p => (p.RazonSocial == RazonSocial || p.RUC == RUC) && p.Id_Proveedor != idProveedorOriginal);
            return proveedor;
        }

        public void Insert(Proveedor datos)
        {
            BaseRepository.dataBase.Proveedores.Add(datos);
            BaseRepository.dataBase.SaveChanges();
        }

        public void Update(Proveedor datos)
        {
            BaseRepository.dataBase.Proveedores.Attach(datos);
            var entry = BaseRepository.dataBase.Entry(datos);
            entry.State = EntityState.Modified;

            entry.Property(e => e.FechaCreacion).IsModified = false;
            entry.Property(e => e.UsuarioCreacion).IsModified = false;

            BaseRepository.dataBase.SaveChanges();
        }
    }
}
