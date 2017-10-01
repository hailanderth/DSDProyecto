using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.DA.Base;
using MD.GA.BE.Entidades;

namespace MD.GA.DA.Interfaces
{
    public interface IPuestoRepository : IBaseRepository<Puesto>
    {
        Puesto GetByName(string name);
        Puesto GetByName(string name, int idPuestoOriginal);
    }
}
