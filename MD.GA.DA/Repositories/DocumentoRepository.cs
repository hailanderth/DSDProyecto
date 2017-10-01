using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MD.GA.DA.Base;
using MD.GA.BE.Entidades;
using MD.GA.DA.Interfaces;
using System.Data.Entity.Validation;

namespace MD.GA.DA.Repositories
{
    public class DocumentoRepository : IDocumentoRepository
    {

        public List<Documento> GetAll()
        {
            return BaseRepository.dataBase.Documentos.Include(x=>x.Documento_Articulo).ToList();
        }

        public Documento GetById(int id)
        {
            Documento Documento = BaseRepository.dataBase.Documentos.Include(x => x.Documento_Articulo).FirstOrDefault(p => p.Id_Documento == id);
            return Documento;
        }

        public Documento GetByTipoNumero(string tipo, int numero)
        {
            Documento documento = BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.NroDocumento == numero && tx.Estado == "A").FirstOrDefault();
            return documento;
        }

        public Documento GetByTipoNumeroSede(string tipo, int numero, int sede)
        {
            Documento documento = BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.NroDocumento == numero && tx.Sede.Id_Sede == sede).FirstOrDefault();
            return documento;
        }
        //Get by tipopresupuesto
        public Documento GetByTipoPresupuesto(string tipo, string tipoPre, int numero)
        {
            Documento documento = BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.TipoPresupuesto == tipoPre && tx.NroDocumento == numero).FirstOrDefault();
            return documento;
        }
        public Documento GetPresupuestoProcesado(string tipo, string tipoPre, int numero) {
            Documento documento = BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.TipoPresupuesto == tipoPre && tx.NroDocumento == numero && tx.Estado == "A").FirstOrDefault();
            return documento;
        }

        public Documento GetByTipoPresupuestoAnu(string tipo, string tipoPre, int numero)
        {
            Documento documento = BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.TipoPresupuesto == tipoPre && tx.NroDocumento == numero && tx.Estado == "I").FirstOrDefault();
            return documento;
        }

        public int GetNumeroPresupuesto(int? idPresupuesto)
        {
            int numeroSiguiente = 0;
            Documento documento = GetById(idPresupuesto);
            numeroSiguiente = documento.NroDocumento;
            return numeroSiguiente;
        }
        //correlativo para tipo presupuesto
        public int GetSiguienteNumeroDocumento(string tipoDocumento, string tipoPre)
        {
            System.Data.Entity.Core.Objects.ObjectParameter output = new System.Data.Entity.Core.Objects.ObjectParameter("nroDocumento", typeof(int));
            BaseRepository.dataBase.DocumentoGetSiguienteNro(tipoDocumento, null, tipoPre, output);
            return Convert.ToInt32(output.Value);
        }
        public int GetSiguienteNumeroDocumento(string tipoDocumento)
        {
            System.Data.Entity.Core.Objects.ObjectParameter output = new System.Data.Entity.Core.Objects.ObjectParameter("nroDocumento", typeof(int));
            BaseRepository.dataBase.DocumentoGetSiguienteNro(tipoDocumento, null, null, output);
            return Convert.ToInt32(output.Value);
        }

        public int GetSiguienteNumeroDocumento(string tipoDocumento, int idSede)
        {
            System.Data.Entity.Core.Objects.ObjectParameter output = new System.Data.Entity.Core.Objects.ObjectParameter("nroDocumento", typeof(int));
            BaseRepository.dataBase.DocumentoGetSiguienteNro(tipoDocumento, idSede, null, output);
            return Convert.ToInt32(output.Value);
        }

        public void Insert(Documento datos)
        {
            BaseRepository.dataBase.Documentos.Add(datos);
            BaseRepository.dataBase.SaveChanges();
        }

        public Documento InsertGetDocument(Documento data)
        {
            BaseRepository.dataBase.Documentos.Add(data);
            BaseRepository.dataBase.SaveChanges();
            return data;
        }

        public void Update(Documento datos)
        {
            try
            {

                BaseRepository.dataBase.Documentos.Attach(datos);
                var entry = BaseRepository.dataBase.Entry(datos);
                entry.State = EntityState.Modified;

                entry.Property(e => e.FechaCreacion).IsModified = false;
                entry.Property(e => e.UsuarioCreacion).IsModified = false;

                BaseRepository.dataBase.SaveChanges();
            }
            catch(DbEntityValidationException ex)
            {
                //var errorMessages = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors)
                //    .Select(x => x.ErrorMessage);

                //var fullErrorMessage = string.Join("; ", errorMessages);

                //var exceptionMessage = string.Concat(ex.Message, "Los errores de validación son");
                //throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);

                List<string> errorMessages = new List<string>();
                foreach (DbEntityValidationResult validationResult in ex.EntityValidationErrors)
                {
                    string entityName = validationResult.Entry.Entity.GetType().Name;
                    foreach (DbValidationError error in validationResult.ValidationErrors)
                    {
                        errorMessages.Add(entityName + "." + error.PropertyName + ": " + error.ErrorMessage);
                    }
                }
            }
        }


        public List<Documento_Articulo> GetDocumentoArticulo(int id)
        {
            return BaseRepository.dataBase.Documento_Articulo.Where(tx => tx.Id_Documento == id).ToList();
        }

        public List<ListaEstadSalida_Resultado> GetlistaEstSalida(DateTime fecIni, DateTime fecFin, int area, int articulo, int sede)
        {
            return BaseRepository.dataBase.ListaEstadSalida(fecIni, fecFin, area, articulo, sede).ToList();
        }
        public List<SP_LISTARREPORENTRADA_Result> GetlistaEntrada(DateTime fecIni, DateTime fecFin, int area, int articulo)
        {
            return BaseRepository.dataBase.ListaEstIngreso(fecIni, fecFin, area, articulo).ToList();
        }

        public List<Documento> DocumentoGetAllReport(string tipo, string estado, DateTime fechaInicio, DateTime fechaFin, int numeroDocumento, string tipoPresu, Sede sede)
        {
            #region validaciones RS
            if (tipo == "RS")
            {
                if (estado != "T")
                {
                    if (sede.Id_Sede != 0)
                    {
                        if (numeroDocumento == 0)
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.Estado == estado && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.Id_Sede == sede.Id_Sede).ToList();
                        }
                        else
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.Estado == estado && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.Id_Sede == sede.Id_Sede && tx.NroDocumento == numeroDocumento).ToList();
                        }
                    }
                    else
                    {
                        if (numeroDocumento == 0)
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo & tx.Estado == estado && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin).ToList();
                        }
                        else
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo & tx.Estado == estado && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin & tx.NroDocumento == numeroDocumento).ToList();
                        }
                    }
                }
                else
                {
                    if (sede.Id_Sede != 0)
                    {
                        if (numeroDocumento == 0)
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.Id_Sede == sede.Id_Sede).ToList();
                        }
                        else
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.Id_Sede == sede.Id_Sede && tx.NroDocumento == numeroDocumento).ToList();
                        }
                    }
                    else
                    {
                        if (numeroDocumento == 0)
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin).ToList();
                        }
                        else
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.NroDocumento == numeroDocumento).ToList();
                        }
                    }
                }
            }

            #endregion validaciones RS
            #region validaciones PR
            else if (tipo == "PR")
            {
                if (estado != "T")
                {
                    if(tipoPresu != "")
                    {
                        if(numeroDocumento == 0)
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.Estado == estado && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.TipoPresupuesto == tipoPresu).ToList();
                        }
                        else
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.Estado == estado && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.TipoPresupuesto == tipoPresu && tx.NroDocumento == numeroDocumento).ToList();
                        }
                    }else
                    {
                        if (numeroDocumento == 0)
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.Estado == estado && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin).ToList();
                        }
                        else
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.Estado == estado && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.NroDocumento == numeroDocumento).ToList();
                        }
                    }
                   
                }
                else
                {
                    if (tipoPresu != "")
                    {
                        if (numeroDocumento == 0)
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.TipoPresupuesto == tipoPresu).ToList();
                        }
                        else
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.TipoPresupuesto == tipoPresu && tx.NroDocumento == numeroDocumento).ToList();
                        }
                    }
                    else
                    {
                        if (numeroDocumento == 0)
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo  && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin).ToList();
                        }
                        else
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo  && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.NroDocumento == numeroDocumento).ToList();
                        }
                    }
                  
                }
            }
            #endregion

            #region Validaciones OD

            else if (tipo == "OC")
            {
                if (estado != "T")
                {
                    if (tipoPresu != "")
                    {
                        if (numeroDocumento == 0)
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.Estado == estado && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.TipoPresupuesto == tipoPresu).ToList();
                        }
                        else
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.Estado == estado && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.TipoPresupuesto == tipoPresu && tx.NroDocumento == numeroDocumento).ToList();
                        }
                    }
                    else
                    {
                        if (numeroDocumento == 0)
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.Estado == estado && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin).ToList();
                        }
                        else
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.Estado == estado && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.NroDocumento == numeroDocumento).ToList();
                        }
                    }

                }
                else
                {
                    if (tipoPresu != "")
                    {
                        if (numeroDocumento == 0)
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.TipoPresupuesto == tipoPresu).ToList();
                        }
                        else
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.TipoPresupuesto == tipoPresu && tx.NroDocumento == numeroDocumento).ToList();
                        }
                    }
                    else
                    {
                        if (numeroDocumento == 0)
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin).ToList();
                        }
                        else
                        {
                            return BaseRepository.dataBase.Documentos.Where(tx => tx.TipoDocumento == tipo && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.NroDocumento == numeroDocumento).ToList();
                        }
                    }

                }
            }
            #endregion
            else if (tipo == "TODOS")
            {
                if (estado != "T")
                {
                    if (numeroDocumento == 0)
                    {
                        return BaseRepository.dataBase.Documentos.Where(tx => tx.Estado == estado && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin).ToList();
                    }
                    else
                    {
                        return BaseRepository.dataBase.Documentos.Where(tx => tx.Estado == estado && tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin & tx.NroDocumento == numeroDocumento).ToList();
                    }
                }
                else
                {
                    if (numeroDocumento == 0)
                    {
                        return BaseRepository.dataBase.Documentos.Where(tx => tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin).ToList();
                    }
                    else
                    {
                        return BaseRepository.dataBase.Documentos.Where(tx => tx.FechaCreacion >= fechaInicio && tx.FechaCreacion <= fechaFin && tx.NroDocumento == numeroDocumento).ToList();
                    }
                }
            }
            return null;
        }

        public Documento GetById(int? id_DocumentoOrigen)
        {
            Documento Documento = BaseRepository.dataBase.Documentos.Include(x => x.Documento_Articulo).FirstOrDefault(p => p.Id_Documento == id_DocumentoOrigen);
            return Documento;
        }

        public Documento Update(Documento datos, List<Documento_Articulo> newLst)
        {
            for (int x = datos.Documento_Articulo.Count - 1; x >= 0; x--)
            {
                BaseRepository.dataBase.Documento_Articulo.Remove(datos.Documento_Articulo.ElementAt(x));
            }
            datos.Documento_Articulo = newLst;
            BaseRepository.dataBase.Documentos.Attach(datos);
            var entry = BaseRepository.dataBase.Entry(datos);
            entry.State = EntityState.Modified;
            entry.Property(e => e.FechaCreacion).IsModified = false;
            entry.Property(e => e.UsuarioCreacion).IsModified = false;
            BaseRepository.dataBase.SaveChanges();
            return datos;
        }
    }
}

