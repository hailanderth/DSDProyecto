using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.DA.Base;
using MD.GA.BE.Entidades;

namespace MD.GA.DA.Interfaces
{
    public interface IDocumentoRepository : IBaseRepository<Documento>
    {
        int GetSiguienteNumeroDocumento(string tipoDocumento, int idSede);
        int GetSiguienteNumeroDocumento(string tipoDocumento, string TipoPre);
        int GetSiguienteNumeroDocumento(string tipoDocumento);
        Documento InsertGetDocument(Documento data);
        Documento GetByTipoNumero(string tipo, int numero);
        Documento GetByTipoNumeroSede(string tipo, int numero, int sede);
        Documento GetByTipoPresupuesto(string tipo, string tipoPre, int numero);
        Documento GetPresupuestoProcesado(string tipo, string tipoPre, int numero);
        Documento Update(Documento datos, List<Documento_Articulo> newLst);
        List<Documento_Articulo> GetDocumentoArticulo(int id);
        List<Documento> DocumentoGetAllReport(string tipo, string estado, DateTime fechaInicio, DateTime fechaFin, int numeroDocumento, string tipoPresu = null,Sede sede = null);
        List<ListaEstadSalida_Resultado> GetlistaEstSalida(DateTime fecIni, DateTime fecFin, int area, int articulo, int sede);
        List<SP_LISTARREPORENTRADA_Result> GetlistaEntrada(DateTime fecIni, DateTime fecFin, int area, int articulo);
        int GetNumeroPresupuesto(int? idPresupuesto);
    }
}
