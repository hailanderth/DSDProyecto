using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.DA.Repositories;
using MD.GA.BE.Entidades;
using MD.GA.BL.Base;
using MD.GA.BL.Util;
using MD.GA.COMMOM.Response;
using MD.GA.BL.BusinessInterfaces;
using MD.GA.DA.Base;

namespace MD.GA.BL.BusinessServices
{
    public class UnidadMedidaService : IUnidadMedidaService
    {
        private UnidadMedidaRepository unidadMedidaRepository;
        public UnidadMedidaService()
        {
            unidadMedidaRepository = new UnidadMedidaRepository();
        }
        public Response<UnidadMedida> Delete(int id)
        {
            Response<UnidadMedida> response = new Response<UnidadMedida>();
            try
            {
                UnidadMedida unidadMedida = unidadMedidaRepository.GetById(id);
                if (unidadMedida == null)
                {
                    return response.Error("Unidad de medida no encontrada");
                }
                unidadMedida.Estado = "I";
                Update(unidadMedida);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<List<UnidadMedida>> GetAll()
        {
            Response<List<UnidadMedida>> response = new Response<List<UnidadMedida>>();
            try
            {
                response.Value = unidadMedidaRepository.GetAll();
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<UnidadMedida> GetById(int id)
        {
            Response<UnidadMedida> response = new Response<UnidadMedida>();
            try
            {
                UnidadMedida unidadMedida = unidadMedidaRepository.GetById(id);
                if (unidadMedida == null)
                {
                    return response.Error("Unidad de medida no encontrada");
                }
                response.Value = unidadMedida;
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<UnidadMedida> Insert(UnidadMedida datos)
        {
            Response<UnidadMedida> response = new Response<UnidadMedida>();
            try
            {
                if (datos.Descripcion.IsNullOrEmpty())
                {
                    return response.Error("Descripcion es obligatoria");
                }
                if (datos.Estado.IsNullOrEmpty())
                {
                    return response.Error("El estado es obligatorio");
                }
                if (unidadMedidaRepository.GetByName(datos.Descripcion) != null)
                {
                    return response.Error("La descripcion ya existe");
                }

                datos.FechaCreacion = BaseRepository.GetServerDateTime();
                unidadMedidaRepository.Insert(datos);
                return response;
            }
            catch(Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public List<UnidadMedida> Listar()
        {
            List<UnidadMedida> listaUnidadMedidad = unidadMedidaRepository.GetAll().ToList();
            UnidadMedida obj = new UnidadMedida()
            {
                Id_UnidadMedida = 0,
                Descripcion = "Seleccione unidad de medida"
            };
            listaUnidadMedidad.Insert(0, obj);
            return listaUnidadMedidad;
        }

        public Response<UnidadMedida> Update(UnidadMedida datos)
        {
            Response<UnidadMedida> response = new Response<UnidadMedida>();
            try
            {
                if (datos.Descripcion.IsNullOrEmpty())
                {
                    return response.Error("Descripcion es obligatoria");
                }
                if (datos.Estado.IsNullOrEmpty())
                {
                    return response.Error("El estado es obligatorio");
                }
                if (unidadMedidaRepository.GetByName(datos.Descripcion, datos.Id_UnidadMedida) != null)
                {
                    return response.Error("La descripcion ya existe");
                }

                datos.FechaModificacion = BaseRepository.GetServerDateTime();
                unidadMedidaRepository.Update(datos);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }
    }
}
