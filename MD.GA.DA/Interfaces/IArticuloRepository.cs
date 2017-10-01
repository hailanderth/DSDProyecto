using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.BE.Entidades;
using MD.GA.DA.Base;

namespace MD.GA.DA.Interfaces
{
    public interface IArticuloRepository : IBaseRepository<Articulo>
    {
        Articulo GetByName(string name);
        Articulo GetByName(string name, int idArticuloOriginal);
        bool ReducirStock(int idArticulo, double cantidad);
        bool AumentarStock(int idArticulo, double cantidad);
        List<Articulo> GetArticulosByStock(int idArea, string nombreArticulo, bool conStock, bool bajoStock, bool sinStock, int idPuesto);
    }
}
