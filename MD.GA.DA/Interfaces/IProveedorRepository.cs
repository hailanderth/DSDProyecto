using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.BE.Entidades;
using MD.GA.DA.Base;

namespace MD.GA.DA.Interfaces
{
    public interface IProveedorRepository : IBaseRepository<Proveedor>
    {
        Proveedor GetByRazonSocialRUC(string RazonSocial, String RUC);
        Proveedor GetByRazonSocialRUC(string RazonSocial, String RUC, int idProveedorOriginal);
    }
}
