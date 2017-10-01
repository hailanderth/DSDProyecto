using MD.GA.BE.Entidades;
using MD.GA.DA.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.GA.DA.Interfaces
{
    interface IBancoRepository : IBaseRepository<BANCO>
    {
        BANCO GetById(int? id_banco);
    }
}
