using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.BE.Entidades;
using MD.GA.BL.Base;
using MD.GA.COMMOM.Response;

namespace MD.GA.BL.BusinessInterfaces
{
    public interface IDocumentoService : IBaseService<Documento>
    {
        Response<Documento> GetByTipoNumero(string tipo, int numeroDocumento);
        Response<Documento> GetByTipoNumeroSede(string tipo, int numeroDocumento, int idSede);
        Response<Documento> Anular(Documento documento);
        Response<Documento> GetByTipoPresupuesto(string tipo, string tipoPre, int numero);
        Response<Documento> GetByTipoPresupuestoAnu(string tipo, string tipoPre, int numero);
        Response<Documento> GetPresupuestoProcesado(string tipo, string tipoPre, int numero);
        List<Documento_Articulo> GetDocumentoArticulo(int idDocumento);
        Response<List<Documento>> DocumentoGetAllReport(string tipo, string estado, DateTime fechaInicio, DateTime fechaFin,int numeroDocumento, string tipoPresu=null, Sede sede = null);
        Response<List<ListaEstadSalida_Resultado>> GetlistaEstSalida(DateTime fecIni, DateTime fecFin, int area, int articulo, int sede);
        Response<List<SP_LISTARREPORENTRADA_Result>> GetListaEntrada(DateTime fecIni, DateTime fecFin, int area, int articulo);
        Response<Documento> GetById(int? id);
        Response<Documento> Update(Documento datos, List<Documento_Articulo> newLst);
    }   
}
