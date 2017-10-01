using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.BE.Entidades;
using MD.GA.DA.Base;

namespace MD.GA.DA.Interfaces
{
    public interface IAreaRepository : IBaseRepository<Area>
    {
        Area GetByName(string name);
        Area GetByName(string name, int idAreaOriginal);
        List<Area> GetAreaByEstado();
    }
}
