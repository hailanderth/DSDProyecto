using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.DA.Repositories;
using MD.GA.BE.Entidades;
using MD.GA.BL.Base;
using MD.GA.COMMOM.Response;

namespace MD.GA.BL.BusinessInterfaces
{
    public interface IUnidadMedidaService : IBaseService<UnidadMedida>
    {
        List<UnidadMedida> Listar();
    }
}
