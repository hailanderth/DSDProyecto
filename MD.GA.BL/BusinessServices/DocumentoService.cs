using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.DA.Repositories;
using MD.GA.DA.Base;
using MD.GA.BE.Entidades;
using MD.GA.BL.Base;
using MD.GA.BL.Util;
using MD.GA.COMMOM.Response;
using MD.GA.BL.BusinessInterfaces;

namespace MD.GA.BL.BusinessServices
{
    public class DocumentoService : IDocumentoService
    {
        private DocumentoRepository documentoRepository;
        private ArticuloRepository articuloRepository;

        public DocumentoService()
        {
            documentoRepository = new DocumentoRepository();
            articuloRepository = new ArticuloRepository();
        }

        public Response<Documento> Delete(int id)
        {
            Response<Documento> response = new Response<Documento>();
            Documento documento = documentoRepository.GetById(id);
            if (documento == null)
            {
                return response.Error("Documento no encontrado");
            }
            documento.Estado = "I";
            return Update(documento);
        }

        public Response<List<Documento>> GetAll()
        {
            Response<List<Documento>> response = new Response<List<Documento>>();
            response.Value = documentoRepository.GetAll();
            return response;
        }

        public Response<List<ListaEstadSalida_Resultado>> GetlistaEstSalida(DateTime fecIni, DateTime fecFin, int area, int articulo, int sede) {
            Response<List<ListaEstadSalida_Resultado>> response = new Response<List<ListaEstadSalida_Resultado>>();
            response.Value = documentoRepository.GetlistaEstSalida(fecIni,fecFin,area, articulo,sede);
            return response;
        }

        public Response<List<SP_LISTARREPORENTRADA_Result>> GetListaEntrada(DateTime fecIni, DateTime fecFin, int area, int articulo)
        {
            Response<List<SP_LISTARREPORENTRADA_Result>> response = new Response<List<SP_LISTARREPORENTRADA_Result>>();
            response.Value = documentoRepository.GetlistaEntrada(fecIni, fecFin, area, articulo);
            return response;
        }

        public Response<Documento> GetById(int id)
        {
            Response<Documento> response = new Response<Documento>();
            Documento documento = documentoRepository.GetById(id);
            if (documento == null)
            {
                return response.Error("Documento no encontrado");
            }
            response.Value = documento;
            return response;
        }

        public Response<Documento> Insert(Documento datos)
        {
            Response<Documento> response = new Response<Documento>();
            Response<Documento> responseUpdate = new Response<Documento>();
            try
            {

                #region Validaciones General

                if (datos == null)
                {
                    return response.Error("No se recibieron datos");
                }

                if (datos.TipoDocumento.IsNullOrEmpty())
                {
                    return response.Error("El tipo de documento es obligatorio");
                }
                #endregion

                #region Validaciones Especificas
                datos.FechaCreacion = BaseRepository.GetServerDateTime();
                switch (datos.TipoDocumento)
                {
                    #region Validaciones Presupuesto
                    case "PR":

                        if (datos.Sede != null || datos.Id_Sede != null)
                        {
                            return response.Error("El tipo de documento no acepta sedes");
                        }
                        if (datos.Id_DocumentoOrigen != null)
                        {
                            return response.Error("El tipo de documento no acepta documento origen");
                        }
                        if (!datos.FormaPago.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de documento no acepta forma de pago");
                        }
                        if (datos.Moneda.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de moneda es obligatorio");
                        }
                        //Tipopresupuesto
                        if (datos.TipoPresupuesto.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de presupuesto es obligatorio");
                        }
                        if (datos.MontoTotal == null) // Pensa!!
                        {
                            return response.Error("El monto total es obligatorio");
                        }
                        if(!datos.Encargado.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de documento no acepta encargado");
                        }

                        foreach (Documento_Articulo doc_art in datos.Documento_Articulo)
                        {
                            if (!doc_art.NombreArea.IsNullOrEmpty())
                            {
                                return response.Error("El documento no acepta nombre de area");
                            }

                            if (doc_art.Articulo == null || doc_art.Id_Articulo == default(int))
                            {
                                return response.Error("El codigo de articulo es requerido");
                            }
                            if (doc_art.Empresa == null || doc_art.Id_Empresa == default(int))
                            {
                                return response.Error("La empresa es obligatoria");
                            }
                            if (doc_art.RazonSocial.IsNullOrEmpty())
                            {
                                return response.Error("La razón social es obligatoria");
                            }
                            if (doc_art.RUC.IsNullOrEmpty())
                            {
                                return response.Error("El numero de RUC es obligatorio");
                            }
                            if (doc_art.DescripcionArticulo.IsNullOrEmpty())
                            {
                                return response.Error("La descripción de articulo es obligatoria");
                            }
                            if (doc_art.CodArea.IsNullOrEmpty())
                            {
                                return response.Error("El codigo de area del articulo es obligatorio");
                            }
                            if (doc_art.UnidadMedida.IsNullOrEmpty())
                            {
                                return response.Error("La unidad de medida es obligatoria");
                            }
                            if (doc_art.Cantidad == default(double))
                            {
                                return response.Error("La cantidad es obligatoria");
                            }
                            if (doc_art.PrecioUnitario == null)
                            {
                                return response.Error("El precio unitario es obligatorio");
                            }
                            if (doc_art.Importe == null)
                            {
                                return response.Error("El Importe es obligatorio");
                            }
                            //if (doc_art.Proveedor != null || doc_art.Id_Proveedor != null/*default(int)*/)
                            //{
                            //    return response.Error("El tipo de documento no acepta proveedor");
                            //}

                            //if (!doc_art.RazonSocialProveedor.IsNullOrEmpty())
                            //{
                            //    return response.Error("El tipo de documento no acepta razón social proveedor");
                            //}

                            //if (!doc_art.RUCProveedor.IsNullOrEmpty())
                            //{
                            //    return response.Error("El tipo de documento no acepta RUC proveedor");
                            //}
                            doc_art.UsuarioCreacion = datos.UsuarioCreacion;
                            doc_art.FechaCreacion = datos.FechaCreacion;

                        }
                        datos.NroDocumento = documentoRepository.GetSiguienteNumeroDocumento(datos.TipoDocumento, datos.TipoPresupuesto);
                        datos.Estado = "A";
                        if (datos.NroDocumento.HasDefaultValue())
                        {
                            return response.Error("No se asigno numero de documento");
                        }
                        //articuloRepository.BeginTransaction();
                        response.Value = documentoRepository.InsertGetDocument(datos);
                        //articuloRepository.CommitTransaction();
                        break;
                    #endregion

                    #region Validaciones Orden de compra
                    case "OC":

                        if (datos.Sede != null || datos.Id_Sede != null)
                        {
                            return response.Error("El tipo de documento no acepta sede");
                        }
                        if (datos.Id_DocumentoOrigen == null)
                        {
                            return response.Error("El documento origen es obligatorio");
                        }
                        if (datos.FormaPago.IsNullOrEmpty())
                        {
                            return response.Error("La forma de pago es obligatoria");
                        }
                        if (datos.Moneda.IsNullOrEmpty())
                        {
                            return response.Error("La Moneda es obligatoria");
                        }
                        if (datos.MontoTotal == null)
                        {
                            return response.Error("El monto total es obligatorio");
                        }
                        if (!datos.Encargado.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de documento no acepta encargado");
                        }

                        foreach (Documento_Articulo doc_art in datos.Documento_Articulo)
                        {
                            if (!doc_art.NombreArea.IsNullOrEmpty())
                            {
                                return response.Error("El documento no acepta nombre de area");
                            }
                            if (doc_art.Articulo == null || doc_art.Id_Articulo == default(int))
                            {
                                return response.Error("El codigo de articulo es requerido");
                            }
                            if (doc_art.Empresa == null || doc_art.Id_Empresa == default(int))
                            {
                                return response.Error("La empresa es obligatoria");
                            }
                            if (doc_art.RazonSocial.IsNullOrEmpty())
                            {
                                return response.Error("La razón social es obligatoria");
                            }
                            if (doc_art.RUC.IsNullOrEmpty())
                            {
                                return response.Error("El número de RUC es obligatorio");
                            }
                            if (doc_art.DescripcionArticulo.IsNullOrEmpty())
                            {
                                return response.Error("La descripción de articulo es obligatoria");
                            }
                            if (doc_art.CodArea.IsNullOrEmpty())
                            {
                                return response.Error("El codigo de area del articulo es obligatorio");
                            }
                            if (doc_art.UnidadMedida.IsNullOrEmpty())
                            {
                                return response.Error("La unidad de medida es obligatoria");
                            }
                            if (doc_art.Cantidad == default(double))
                            {
                                return response.Error("La cantidad es obligatoria");
                            }
                            if (doc_art.PrecioUnitario == null)
                            {
                                return response.Error("El precio unitario es obligatorio");
                            }
                            if (doc_art.Importe == null)
                            {
                                return response.Error("El Importe es obligatorio");
                            }
                            if (doc_art.Proveedor == null || doc_art.Id_Proveedor == /*null*/default(int))
                            {
                                return response.Error("El proveedor es obligatorio");
                            }

                            if (doc_art.RazonSocialProveedor.IsNullOrEmpty())
                            {
                                return response.Error("La razón social del proveedor es obligatoria");
                            }

                            if(doc_art.NombreBanco.IsNullOrEmpty())
                            {
                                return response.Error("El banco es obligatorio");
                            }

                            if(doc_art.CuentaBanco.IsNullOrEmpty())
                            {
                                return response.Error("El número de cuenta es obligatorio");
                            }

                            if (doc_art.RUCProveedor.IsNullOrEmpty())
                            {
                                return response.Error("El número de RUC del proveedor es obligatorio");
                            }
                            doc_art.UsuarioCreacion = datos.UsuarioCreacion;
                            doc_art.FechaCreacion = datos.FechaCreacion;
                        }

                        #region Validacion numero documento OC

                        //datos.NroDocumento = documentoRepository.GetSiguienteNumeroDocumento(datos.TipoDocumento, datos.TipoPresupuesto);

                        datos.NroDocumento = documentoRepository.GetNumeroPresupuesto(datos.Id_DocumentoOrigen);
                        datos.Estado = "A";

                        if (datos.NroDocumento.HasDefaultValue())
                        {
                            return response.Error("No se asigno numero de documento");
                        }

                        BaseRepository.BeginTransaction();

                        foreach (Documento_Articulo doc in datos.Documento_Articulo)
                        {
                            if (!articuloRepository.AumentarStock(doc.Articulo.Id_Articulo, doc.Cantidad))
                            {
                                BaseRepository.RollBackTransaction();
                                return response.Error("Error - " + doc.Articulo.Descripcion);
                            }
                        }

                        response.Value = documentoRepository.InsertGetDocument(datos);

                        try
                        {
                            Documento docPresupeusto = documentoRepository.GetById(datos.Id_DocumentoOrigen);
                            DocumentoService service = new DocumentoService();
                            
                            responseUpdate = service.Update(docPresupeusto);

                            if (responseUpdate.IsValid)
                                BaseRepository.CommitTransaction();
                            else
                                BaseRepository.RollBackTransaction();
                        }
                        catch(Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        #endregion

                        break;
                    #endregion

                    #region Validaciones Registro de salidas
                    case "RS":
                        if (datos.Sede == null && datos.Id_Sede == null)
                        {
                            return response.Error("La sede es obligatoria");
                        }
                        if (datos.Id_DocumentoOrigen != null)
                        {
                            return response.Error("El tipo de documento no acepta documento origen");
                        }
                        if (!datos.FormaPago.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de documento no acepta forma de pago");
                        }
                        if (!datos.Moneda.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de documento no acepta moneda");
                        }
                        if (datos.MontoTotal != null)
                        {
                            return response.Error("El tipo de documento no acepta monto total");
                        }
                        if (datos.Encargado.IsNullOrEmpty())
                        {
                            return response.Error("El encargado es obligatorio");
                        }

                        foreach (Documento_Articulo doc_art in datos.Documento_Articulo)
                        {
                            if (doc_art.NombreArea.IsNullOrEmpty())
                            {
                                return response.Error("Nombre de area es requerido");
                            }
                            if (doc_art.Articulo == null && doc_art.Id_Articulo == default(int))
                            {
                                return response.Error("El codigo de articulo es requerido");
                            }
                            if (doc_art.Empresa != null || doc_art.Id_Empresa != null)
                            {
                                return response.Error("El tipo de documento no acepta Empresa");
                            }
                            if (!doc_art.RazonSocial.IsNullOrEmpty())
                            {
                                return response.Error("El tipo de documento no acepta razón social");
                            }
                            if (!doc_art.RUC.IsNullOrEmpty())
                            {
                                return response.Error("El tipo de documento no acepta RUC");
                            }
                            if (doc_art.DescripcionArticulo.IsNullOrEmpty())
                            {
                                return response.Error("La descripción de articulo es obligatoria");
                            }
                            if (doc_art.CodArea.IsNullOrEmpty())
                            {
                                return response.Error("El codigo de area de articulo es obligatorio");
                            }
                            if (doc_art.UnidadMedida.IsNullOrEmpty())
                            {
                                return response.Error("La unidad de medida es obligatoria");
                            }
                            if (doc_art.Cantidad == default(double))
                            {
                                return response.Error("La cantidad es obligatoria");
                            }
                            if (doc_art.PrecioUnitario != null)
                            {
                                return response.Error("El tipo de documento no acepta precio unitario");
                            }
                            if (doc_art.Importe != null)
                            {
                                return response.Error("El tipo de documento no acepta importe");
                            }
                            if (doc_art.Proveedor != null || doc_art.Id_Proveedor != null)
                            {
                                return response.Error("El tipo de documento no acepta proveedor");
                            }

                            if (!doc_art.RazonSocialProveedor.IsNullOrEmpty())
                            {
                                return response.Error("El tipo de documento no acepta razón social proveedor");
                            }

                            if (!doc_art.RUCProveedor.IsNullOrEmpty())
                            {
                                return response.Error("El tipo de documento no acepta ruc proveedor");
                            }
                            doc_art.UsuarioCreacion = datos.UsuarioCreacion;
                            doc_art.FechaCreacion = datos.FechaCreacion;
                        }

                        #region Validacion Numero documento


                        datos.NroDocumento = documentoRepository.GetSiguienteNumeroDocumento(datos.TipoDocumento, datos.Sede.Id_Sede);
                        datos.Estado = "A";
                        if (datos.NroDocumento.HasDefaultValue())
                        {
                            return response.Error("No se asigno numero de documento");
                        }

                        //Modificar stock
                        BaseRepository.BeginTransaction();
                        foreach (Documento_Articulo doc in datos.Documento_Articulo)
                        {
                            if (!articuloRepository.ReducirStock(doc.Articulo.Id_Articulo, doc.Cantidad))
                            {
                                BaseRepository.RollBackTransaction();
                                return response.Error("Stock insuficiente - " + doc.Articulo.Descripcion);
                            }
                        }
                        response.Value = documentoRepository.InsertGetDocument(datos);
                        BaseRepository.CommitTransaction();
                        #endregion

                        break;
                    #endregion

                    default: return response.Error("Tipo de documento incorrecto");
                }
         
                #endregion


                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<Documento> Update(Documento datos)
        {
            Response<Documento> response = new Response<Documento>();
            try
            {


                #region Validaciones

                #region Validaciones General


                if (datos == null)
                {
                    return response.Error("No se recibieron datos");
                }

                if (datos.TipoDocumento.IsNullOrEmpty())
                {
                    return response.Error("El tipo de documento es obligatorio");
                }
                #endregion

                #region Validaciones Especificas
                switch (datos.TipoDocumento)
                {
                    #region Validaciones Presupuesto
                    case "PR":

                        //if (datos.Sede != null || datos.Id_Sede != null)
                        //{
                        //    return response.Error("El tipo de documento no acepta sedes");
                        //}
                        //if (datos.Id_DocumentoOrigen != null)
                        //{
                        //    return response.Error("El tipo de documento no acepta documento origen");
                        //}
                        //if (!datos.FormaPago.IsNullOrEmpty())
                        //{
                        //    return response.Error("El tipo de documento no acepta forma de pago");
                        //}
                        //if (datos.Moneda.IsNullOrEmpty())
                        //{
                        //    return response.Error("El tipo de moneda es obligatorio");
                        //}
                        //if (datos.MontoTotal == null) // Pensa!!
                        //{
                        //    return response.Error("El monto total es obligatorio");
                        //}
                        //if (!datos.Encargado.IsNullOrEmpty())
                        //{
                        //    return response.Error("El tipo de documento no acepta encargado");
                        //}

                        //foreach (Documento_Articulo doc_art in datos.Documento_Articulo)
                        //{
                        //    if (doc_art.Articulo == null || doc_art.Id_Articulo == default(int))
                        //    {
                        //        return response.Error("El codigo de articulo es requerido");
                        //    }
                        //    if (doc_art.Empresa == null || doc_art.Id_Empresa == default(int))
                        //    {
                        //        return response.Error("La empresa es obligatoria");
                        //    }
                        //    if (doc_art.RazonSocial.IsNullOrEmpty())
                        //    {
                        //        return response.Error("La razón social es obligatoria");
                        //    }
                        //    if (doc_art.RUC.IsNullOrEmpty())
                        //    {
                        //        return response.Error("El numero de RUC es obligatorio");
                        //    }
                        //    if (doc_art.DescripcionArticulo.IsNullOrEmpty())
                        //    {
                        //        return response.Error("La descripción de articulo es obligatoria");
                        //    }
                        //    if (doc_art.CodArea.IsNullOrEmpty())
                        //    {
                        //        return response.Error("El codigo de area del articulo es obligatorio");
                        //    }
                        //    if (doc_art.UnidadMedida.IsNullOrEmpty())
                        //    {
                        //        return response.Error("La unidad de medida es obligatoria");
                        //    }
                        //    if (doc_art.Cantidad == default(double))
                        //    {
                        //        return response.Error("La cantidad es obligatoria");
                        //    }
                        //    if (doc_art.PrecioUnitario == null)
                        //    {
                        //        return response.Error("El precio unitario es obligatorio");
                        //    }
                        //    if (doc_art.Importe == null)
                        //    {
                        //        return response.Error("El Importe es obligatorio");
                        //    }
                        //    if (doc_art.Proveedor != null || doc_art.Id_Proveedor != default(int))
                        //    {
                        //        return response.Error("El tipo de documento no acepta proveedor");
                        //    }

                        //    if (!doc_art.RazonSocialProveedor.IsNullOrEmpty())
                        //    {
                        //        return response.Error("El tipo de documento no acepta razón social proveedor");
                        //    }

                        //    if (!doc_art.RUCProveedor.IsNullOrEmpty())
                        //    {
                        //        return response.Error("El tipo de documento no acepta RUC proveedor");
                        //    }


                        //}
                        if (datos.Sede != null || datos.Id_Sede != null)
                        {
                            return response.Error("El tipo de documento no acepta sedes");
                        }
                        if (datos.Id_DocumentoOrigen != null)
                        {
                            return response.Error("El tipo de documento no acepta documento origen");
                        }
                        if (!datos.FormaPago.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de documento no acepta forma de pago");
                        }
                        if (datos.Moneda.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de moneda es obligatorio");
                        }
                        //Tipopresupuesto
                        if (datos.TipoPresupuesto.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de presupuesto es obligatorio");
                        }
                        if (datos.MontoTotal == null) // Pensa!!
                        {
                            return response.Error("El monto total es obligatorio");
                        }
                        if (!datos.Encargado.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de documento no acepta encargado");
                        }

                        foreach (Documento_Articulo doc_art in datos.Documento_Articulo)
                        {
                            if (!doc_art.NombreArea.IsNullOrEmpty())
                            {
                                return response.Error("El documento no acepta nombre de area");
                            }

                            if (doc_art.Articulo == null || doc_art.Id_Articulo == default(int))
                            {
                                return response.Error("El codigo de articulo es requerido");
                            }
                            if (doc_art.Empresa == null || doc_art.Id_Empresa == default(int))
                            {
                                return response.Error("La empresa es obligatoria");
                            }
                            if (doc_art.RazonSocial.IsNullOrEmpty())
                            {
                                return response.Error("La razón social es obligatoria");
                            }
                            if (doc_art.RUC.IsNullOrEmpty())
                            {
                                return response.Error("El numero de RUC es obligatorio");
                            }
                            if (doc_art.DescripcionArticulo.IsNullOrEmpty())
                            {
                                return response.Error("La descripción de articulo es obligatoria");
                            }
                            if (doc_art.CodArea.IsNullOrEmpty())
                            {
                                return response.Error("El codigo de area del articulo es obligatorio");
                            }
                            if (doc_art.UnidadMedida.IsNullOrEmpty())
                            {
                                return response.Error("La unidad de medida es obligatoria");
                            }
                            if (doc_art.Cantidad == default(double))
                            {
                                return response.Error("La cantidad es obligatoria");
                            }
                            if (doc_art.PrecioUnitario == null)
                            {
                                return response.Error("El precio unitario es obligatorio");
                            }
                            if (doc_art.Importe == null)
                            {
                                return response.Error("El Importe es obligatorio");
                            }
                            //if (doc_art.Proveedor == null || doc_art.Id_Proveedor == null/*default(int)*/)
                            //{
                            //    return response.Error("El tipo de documento requiere proveedor");
                            //}

                            //if (doc_art.RazonSocialProveedor.IsNullOrEmpty())
                            //{
                            //    return response.Error("El tipo de documento requiere razón social proveedor");
                            //}

                            //if (doc_art.RUCProveedor.IsNullOrEmpty())
                            //{
                            //    return response.Error("El tipo de documento requiere RUC proveedor");
                            //}
                            doc_art.UsuarioCreacion = datos.UsuarioCreacion;
                            doc_art.FechaCreacion = datos.FechaCreacion;

                        }

                        datos.Estado = "P";
                        break;
                    #endregion

                    #region Validaciones Orden de compra
                    case "OC":

                        if (datos.Sede != null || datos.Id_Sede != null)
                        {
                            return response.Error("El tipo de documento no acepta sede");
                        }
                        if (datos.Id_DocumentoOrigen == null)
                        {
                            return response.Error("El documento origen es obligatorio");
                        }
                        if (datos.FormaPago.IsNullOrEmpty())
                        {
                            return response.Error("La forma de pago es obligatoria");
                        }
                        if (datos.Moneda.IsNullOrEmpty())
                        {
                            return response.Error("La Moneda es obligatoria");
                        }
                        if (datos.MontoTotal == null)
                        {
                            return response.Error("El monto total es obligatorio");
                        }
                        if (!datos.Encargado.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de documento no acepta encargado");
                        }

                        foreach (Documento_Articulo doc_art in datos.Documento_Articulo)
                        {
                            if (doc_art.Articulo == null || doc_art.Id_Articulo == default(int))
                            {
                                return response.Error("El codigo de articulo es requerido");
                            }
                            if (doc_art.Empresa == null || doc_art.Id_Empresa == default(int))
                            {
                                return response.Error("La empresa es obligatoria");
                            }
                            if (doc_art.RazonSocial.IsNullOrEmpty())
                            {
                                return response.Error("La razón social es obligatoria");
                            }
                            if (doc_art.RUC.IsNullOrEmpty())
                            {
                                return response.Error("El numero de RUC es obligatorio");
                            }
                            if (doc_art.DescripcionArticulo.IsNullOrEmpty())
                            {
                                return response.Error("La descripción de articulo es obligatoria");
                            }
                            if (doc_art.CodArea.IsNullOrEmpty())
                            {
                                return response.Error("El codigo de area del articulo es obligatorio");
                            }
                            if (doc_art.UnidadMedida.IsNullOrEmpty())
                            {
                                return response.Error("La unidad de medida es obligatoria");
                            }
                            if (doc_art.Cantidad == default(double))
                            {
                                return response.Error("La cantidad es obligatoria");
                            }
                            if (doc_art.PrecioUnitario == null)
                            {
                                return response.Error("El precio unitario es obligatorio");
                            }
                            if (doc_art.Importe == null)
                            {
                                return response.Error("El Importe es obligatorio");
                            }
                            if (doc_art.Proveedor == null || doc_art.Id_Proveedor == default(int))
                            {
                                return response.Error("El proveedor es obligatorio");
                            }

                            if (doc_art.RazonSocialProveedor.IsNullOrEmpty())
                            {
                                return response.Error("La razón social proveedor es obligatoria");
                            }

                            if (doc_art.RUCProveedor.IsNullOrEmpty())
                            {
                                return response.Error("El RUC Proveedor es obligatorio");
                            }
                        }

                        break;
                    #endregion

                    #region Validaciones Registro de salidas
                    case "RS":
                        if (datos.Sede == null || datos.Id_Sede == null)
                        {
                            return response.Error("La sede es obligatoria");
                        }
                        if (datos.Id_DocumentoOrigen != null)
                        {
                            return response.Error("El tipo de documento no acepta documento origen");
                        }
                        if (!datos.FormaPago.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de documento no acepta forma de pago");
                        }
                        if (!datos.Moneda.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de documento no acepta moneda");
                        }
                        if (datos.MontoTotal != null)
                        {
                            return response.Error("El tipo de documento no acepta monto total");
                        }
                        if (datos.Encargado.IsNullOrEmpty())
                        {
                            return response.Error("El encargado es obligatorio");
                        }

                        foreach (Documento_Articulo doc_art in datos.Documento_Articulo)
                        {
                            if (doc_art.Articulo == null || doc_art.Id_Articulo == default(int))
                            {
                                return response.Error("El codigo de articulo es requerido");
                            }
                            if (doc_art.Empresa != null || doc_art.Id_Empresa != null)
                            {
                                return response.Error("El tipo de documento no acepta Empresa");
                            }
                            if (!doc_art.RazonSocial.IsNullOrEmpty())
                            {
                                return response.Error("El tipo de documento no acepta razón social");
                            }
                            if (!doc_art.RUC.IsNullOrEmpty())
                            {
                                return response.Error("El tipo de documento no acepta RUC");
                            }
                            if (doc_art.DescripcionArticulo.IsNullOrEmpty())
                            {
                                return response.Error("La descripción de articulo es obligatoria");
                            }
                            if (doc_art.CodArea.IsNullOrEmpty())
                            {
                                return response.Error("El codigo de area de articulo es obligatorio");
                            }
                            if (doc_art.UnidadMedida.IsNullOrEmpty())
                            {
                                return response.Error("La unidad de medida es obligatoria");
                            }
                            if (doc_art.Cantidad == default(double))
                            {
                                return response.Error("La cantidad es obligatoria");
                            }
                            if (doc_art.PrecioUnitario != null)
                            {
                                return response.Error("El tipo de documento no acepta precio unitario");
                            }
                            if (doc_art.Importe != null)
                            {
                                return response.Error("El tipo de documento no acepta importe");
                            }
                            if (doc_art.Proveedor != null || doc_art.Id_Proveedor != null)
                            {
                                return response.Error("El tipo de documento no acepta proveedor");
                            }

                            if (!doc_art.RazonSocialProveedor.IsNullOrEmpty())
                            {
                                return response.Error("El tipo de documento no acepta razón social proveedor");
                            }

                            if (!doc_art.RUCProveedor.IsNullOrEmpty())
                            {
                                return response.Error("El tipo de documento no acepta ruc proveedor");
                            }
                        }





                        break;

                    default: return response.Error("Tipo de documento incorrecto");
                        #endregion
                }
                #endregion

                #region Validacion Numero documento


                if (datos.NroDocumento.HasDefaultValue())
                {
                    return response.Error("Error en numero de documento");
                }

                #endregion

                #endregion

                datos.FechaModificacion = BaseRepository.GetServerDateTime();
                documentoRepository.Update(datos);

                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<Documento> GetByTipoNumero(string tipo, int numeroDocumento)
        {
            Response<Documento> response = new Response<Documento>();
            Documento documento = documentoRepository.GetByTipoNumero(tipo, numeroDocumento);
            if (documento != null)
            {
                response.Value = documento;
            }
            else
            {
                return response.Error("Documento no encontrado");
            }


            return response;
        }

        public Response<Documento> GetByTipoNumeroSede(string tipo, int numeroDocumento, int idSede)
        {
            Response<Documento> response = new Response<Documento>();
            Documento documento = documentoRepository.GetByTipoNumeroSede(tipo, numeroDocumento, idSede);
            if (documento != null)
            {
                response.Value = documento;
            }
            else
            {
                return response.Error("Documento no encontrado");
            }

            return response;
        }

        //Get by TipoPresupuesto
        public Response<Documento> GetByTipoPresupuesto(string tipo, string tipoPre, int numero) {
            Response<Documento> response = new Response<Documento>();
            Documento documento = documentoRepository.GetByTipoPresupuesto(tipo, tipoPre, numero);
            if (documento != null)
            {
                response.Value = documento;
            }
            else
            {
                return response.Error("Documento no encontrado");
            }

            return response;
        }

        public Response<Documento> GetPresupuestoProcesado(string tipo, string tipoPre, int numero)
        {
            Response<Documento> response = new Response<Documento>();
            Documento documento = documentoRepository.GetPresupuestoProcesado(tipo, tipoPre, numero);
            if (documento != null)
            {
                response.Value = documento;
            }
            else
            {
                documento = documentoRepository.GetByTipoPresupuesto(tipo, tipoPre, numero);
                if(documento != null)
                {
                    if(documento.Estado != "A")
                        return response.Error("El presupuesto ya fue generado.");
                }         
                return response.Error("Documento no encontrado");
            }

            return response;
        }
        public Response<Documento> GetByTipoPresupuestoAnu(string tipo, string tipoPre, int numero) {
            Response<Documento> response = new Response<Documento>();
            Documento documento = documentoRepository.GetByTipoPresupuestoAnu(tipo, tipoPre, numero);
            if (documento != null)
            {
                response.Value = documento;
            }
            else
            {
                return response.Error("Documento no encontrado");
            }

            return response;
        }

        public Response<Documento> Anular(Documento documento)
        {
            Response<Documento> response = new Response<Documento>();
            if (documento.TipoDocumento.IsNullOrEmpty())
            {
                return response.Error("Tipo de documento no especificado");
            }
            if (documento.Estado != "A" && documento.Estado !="P")
            {
                return response.Error("Documento no activo para anulación");
            }
            switch (documento.TipoDocumento)
            {
                case "RS":
                    BaseRepository.BeginTransaction();
                    foreach (Documento_Articulo dart in documento.Documento_Articulo)
                    {
                        if (!articuloRepository.AumentarStock(dart.Id_Articulo, dart.Cantidad))
                        {
                            BaseRepository.RollBackTransaction();
                            return response.Error("No se pudo modificar el stock de: " + dart.DescripcionArticulo);
                        }
                    }
                    documento.Estado = "I";
                    documento.FechaModificacion = BaseRepository.GetServerDateTime();
                    documentoRepository.Update(documento);
                    BaseRepository.CommitTransaction();
                    return response;
               
                case "PR":
                    documento.Estado = "I";
                    documento.FechaModificacion = BaseRepository.GetServerDateTime();
                    documentoRepository.Update(documento);
                    return response;

                case "OC":
                    BaseRepository.BeginTransaction();
                    foreach (Documento_Articulo dart in documento.Documento_Articulo)
                    {
                        if (!articuloRepository.ReducirStock(dart.Id_Articulo, dart.Cantidad))
                        {
                            BaseRepository.RollBackTransaction();
                            return response.Error("No se pudo modificar el stock de: " + dart.DescripcionArticulo);
                        }
                    }
                    documento.Estado = "I";
                    documento.FechaModificacion = BaseRepository.GetServerDateTime();
                    documentoRepository.Update(documento);
                    BaseRepository.CommitTransaction();
                    return response;
                default: return response.Error("Documento no identificado para anulación");

            }
            
        }

        public List<Documento_Articulo> GetDocumentoArticulo(int idDocumento)
        {
            List<Documento_Articulo> listaDocumento_articulo = new List<Documento_Articulo>();
            listaDocumento_articulo = documentoRepository.GetDocumentoArticulo(idDocumento);
            return listaDocumento_articulo;
        }


        public Response<List<Documento>> DocumentoGetAllReport(string tipo, string estado, DateTime fechaInicio, DateTime fechaFin,int numeroDocumento, string tipoPresu=null, Sede sede = null)
        {
            Response<List<Documento>> response = new Response<List<Documento>>();
            response.Value = documentoRepository.DocumentoGetAllReport(tipo, estado, fechaInicio, fechaFin,numeroDocumento,tipoPresu, sede);
            return response;
        }

        public Response<Documento> GetById(int? id)
        {
            Response<Documento> response = new Response<Documento>();
            Documento documento = documentoRepository.GetById(id);
            if (documento == null)
            {
                return response.Error("Documento no encontrado");
            }
            response.Value = documento;
            return response;
        }

        public Response<Documento> Update(Documento datos, List<Documento_Articulo> newLst)
        {
            Response<Documento> response = new Response<Documento>();

            try
            {
                if (datos == null)
                {
                    return response.Error("No se recibieron datos");
                }

                if (datos.TipoDocumento.IsNullOrEmpty())
                {
                    return response.Error("El tipo de documento es obligatorio");
                }

                switch (datos.TipoDocumento)
                {
                    case "PR":

                        if (datos.Sede != null || datos.Id_Sede != null)
                        {
                            return response.Error("El tipo de documento no acepta sedes");
                        }
                        if (datos.Id_DocumentoOrigen != null)
                        {
                            return response.Error("El tipo de documento no acepta documento origen");
                        }
                        if (!datos.FormaPago.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de documento no acepta forma de pago");
                        }
                        if (datos.Moneda.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de moneda es obligatorio");
                        }
                        //Tipopresupuesto
                        if (datos.TipoPresupuesto.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de presupuesto es obligatorio");
                        }
                        if (datos.MontoTotal == null) // Pensa!!
                        {
                            return response.Error("El monto total es obligatorio");
                        }
                        if (!datos.Encargado.IsNullOrEmpty())
                        {
                            return response.Error("El tipo de documento no acepta encargado");
                        }

                        foreach (Documento_Articulo doc_art in newLst)
                        {
                            if (!doc_art.NombreArea.IsNullOrEmpty())
                            {
                                return response.Error("El documento no acepta nombre de area");
                            }

                            if (doc_art.Articulo == null || doc_art.Id_Articulo == default(int))
                            {
                                return response.Error("El codigo de articulo es requerido");
                            }
                            if (doc_art.Empresa == null || doc_art.Id_Empresa == default(int))
                            {
                                return response.Error("La empresa es obligatoria");
                            }
                            if (doc_art.RazonSocial.IsNullOrEmpty())
                            {
                                return response.Error("La razón social es obligatoria");
                            }
                            if (doc_art.RUC.IsNullOrEmpty())
                            {
                                return response.Error("El numero de RUC es obligatorio");
                            }
                            if (doc_art.DescripcionArticulo.IsNullOrEmpty())
                            {
                                return response.Error("La descripción de articulo es obligatoria");
                            }
                            if (doc_art.CodArea.IsNullOrEmpty())
                            {
                                return response.Error("El codigo de area del articulo es obligatorio");
                            }
                            if (doc_art.UnidadMedida.IsNullOrEmpty())
                            {
                                return response.Error("La unidad de medida es obligatoria");
                            }
                            if (doc_art.Cantidad == default(double))
                            {
                                return response.Error("La cantidad es obligatoria");
                            }
                            if (doc_art.PrecioUnitario == null)
                            {
                                return response.Error("El precio unitario es obligatorio");
                            }
                            if (doc_art.Importe == null)
                            {
                                return response.Error("El Importe es obligatorio");
                            }
                            //if (doc_art.Proveedor != null || doc_art.Id_Proveedor != null/*default(int)*/)
                            //{
                            //    return response.Error("El tipo de documento no acepta proveedor");
                            //}

                            //if (!doc_art.RazonSocialProveedor.IsNullOrEmpty())
                            //{
                            //    return response.Error("El tipo de documento no acepta razón social proveedor");
                            //}

                            //if (!doc_art.RUCProveedor.IsNullOrEmpty())
                            //{
                            //    return response.Error("El tipo de documento no acepta RUC proveedor");
                            //}
                            doc_art.UsuarioCreacion = datos.UsuarioCreacion;
                            doc_art.FechaCreacion = datos.FechaCreacion;
                            doc_art.FechaModificacion = BaseRepository.GetServerDateTime();

                        }
                        datos.FechaModificacion = BaseRepository.GetServerDateTime();
                        documentoRepository.Update(datos, newLst);
                        return response;
                    default:
                        return response.Error("Tipo de documento no disponible para actualizar");
                }
            }
            catch (Exception ex)
            {
                return response.Error(ex.Message);
            }

            //catch (DbEntityValidationException e)
            //{
            //    foreach (var eve in e.EntityValidationErrors)
            //    {
            //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
            //                ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }
            //    throw;
            //}






        }
    }
}