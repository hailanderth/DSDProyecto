using MD.GA.BE.Entidades;
using MD.GA.BL.Base;
using MD.GA.COMMOM.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.GA.BL.BusinessInterfaces
{
    public interface IBancoService : IBaseService<BANCO>
    {
        Response<BANCO> GetById(int? id);
        List<BANCO> Listar();
    }
}
