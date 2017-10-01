using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.DA.Base;
using MD.GA.BE.Entidades;

namespace MD.GA.DA.Interfaces
{
    interface IUnidadMedidaRepository : IBaseRepository<UnidadMedida>
    {
        UnidadMedida GetByName(string nombre);
        UnidadMedida GetByName(string nombre, int idUnidadMedidaOriginal);
    }
}
