using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using MD.GA.DA.Base;
using MD.GA.BE.Entidades;
using MD.GA.DA.Interfaces;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace MD.GA.DA.Repositories
{
    public class ArticuloRepository : IArticuloRepository
    {
        public bool AumentarStock(int idArticulo, double cantidad)
        {
            System.Data.Entity.Core.Objects.ObjectParameter output = new System.Data.Entity.Core.Objects.ObjectParameter("bit", typeof(bool));
            BaseRepository.dataBase.ArticuloAumentarStock(idArticulo, cantidad, output);
            Articulo articulo = BaseRepository.dataBase.Articulos.Where(tx => tx.Id_Articulo == idArticulo).FirstOrDefault();
            BaseRepository.dataBase.Entry(articulo).Reload();
            return Convert.ToBoolean(output.Value);
        }

        public List<Articulo> GetAll()
        {
            return BaseRepository.dataBase.Articulos.Include(a => a.Area).Include(a => a.UnidadMedida).ToList();
        }

        public List<Articulo> GetArticulosByStock(int idArea, string nombreArticulo, bool conStock, bool bajoStock, bool sinStock, int idPuesto)
        {
            return BaseRepository.dataBase.SP_LISTAR_ARTICULOS_BY_STOCK(idArea, nombreArticulo, conStock, bajoStock, sinStock, idPuesto).ToList();
        }

        public Articulo GetById(int id)
        {
            Articulo Articulo = BaseRepository.dataBase.Articulos.Include(a => a.Area).Include(a => a.UnidadMedida).FirstOrDefault(p => p.Id_Articulo == id);
            return Articulo;
        }

        public Articulo GetByName(string name)
        {
            Articulo Articulo = BaseRepository.dataBase.Articulos.Include(a => a.Area).Include(a => a.UnidadMedida).FirstOrDefault(p => p.Descripcion == name);
            return Articulo;
        }

        public Articulo GetByName(string name, int idArticuloOriginal)
        {
            Articulo Articulo = BaseRepository.dataBase.Articulos.Include(a => a.Area).Include(a => a.UnidadMedida).FirstOrDefault(p => p.Descripcion == name && p.Id_Articulo != idArticuloOriginal);
            return Articulo;
        }

        public void Insert(Articulo datos)
        {
            BaseRepository.dataBase.Articulos.Add(datos);
            BaseRepository.dataBase.SaveChanges();        
        }

        public bool ReducirStock(int idArticulo, double cantidad)
        {
            System.Data.Entity.Core.Objects.ObjectParameter output = new System.Data.Entity.Core.Objects.ObjectParameter("bit", typeof(bool));
            BaseRepository.dataBase.ArticuloReducirStock(idArticulo, cantidad, output);
            Articulo articulo = BaseRepository.dataBase.Articulos.Where(tx => tx.Id_Articulo == idArticulo).FirstOrDefault();
            BaseRepository.dataBase.Entry(articulo).Reload();
            return Convert.ToBoolean(output.Value);
        }

        public void Update(Articulo datos)
        {
             BaseRepository.dataBase.Articulos.Attach(datos);
             var entry = BaseRepository.dataBase.Entry(datos);
             entry.State = EntityState.Modified;

             entry.Property(e => e.FechaCreacion).IsModified = false;
             entry.Property(e => e.UsuarioCreacion).IsModified = false;

             BaseRepository.dataBase.SaveChanges();           
        }
    }
}
