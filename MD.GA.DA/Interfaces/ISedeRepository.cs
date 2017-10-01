using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.DA.Base;
using MD.GA.BE.Entidades;

namespace MD.GA.DA.Interfaces
{
    public interface ISedeRepository : IBaseRepository<Sede>
    {
        Sede GetByName(string name);
        Sede GetByName(string name, int idSedeOriginal);
        Sede GetByCodigo(string codigo);
        Sede GetByCodigo(string codigo, int idSedeOriginal);
    }
}
