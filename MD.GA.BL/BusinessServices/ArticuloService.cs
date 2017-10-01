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
using System.Data;


namespace MD.GA.BL.BusinessServices
{
    public class ArticuloService : IArticuloService
    {
        private ArticuloRepository articuloRepository;

        public ArticuloService()
        {
            articuloRepository = new ArticuloRepository();

        }

        public Response<Articulo> Delete(int id)
        {
            Response<Articulo> response = new Response<Articulo>();
            try
            {
                Articulo articulo = articuloRepository.GetById(id);
                if (articulo == null)
                {
                    return response.Error("Articulo no encontrado");
                }
                articulo.Estado = "I";
                return Update(articulo);
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }

        }

        public Response<List<Articulo>> GetAll()
        {
            Response<List<Articulo>> response = new Response<List<Articulo>>();
            try
            {
                response.Value = articuloRepository.GetAll();
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }

        }

        public Response<Articulo> GetById(int id)
        {
            Response<Articulo> response = new Response<Articulo>();
            try
            {
                Articulo articulo = articuloRepository.GetById(id);
                if (articulo == null)
                {
                    return response.Error("Articulo no encontrado");
                }
                response.Value = articulo;
                return response;
            }
            catch(Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<Articulo> Insert(Articulo datos)
        {
            Response<Articulo> response = new Response<Articulo>();
            try
            {
                if (datos.Descripcion.IsNullOrEmpty())
                {
                    return response.Error("Descripcion de articulo obligatoria");
                }
                if (datos.Moneda.IsNullOrEmpty())
                {
                    return response.Error("El tipo de moneda es obligatorio");
                }
                if (datos.Area == null)
                {
                    return response.Error("El area es obligatorio");
                }
                if (datos.UnidadMedida == null)
                {
                    return response.Error("La unidad de medida es obligatoria");
                }
                if (datos.Estado.IsNullOrEmpty())
                {
                    return response.Error("El articulo debe tener un estado");
                }
                if (articuloRepository.GetByName(datos.Descripcion) != null)
                {
                    return response.Error("El nombre de articulo ya existe");
                }
                datos.FechaCreacion = BaseRepository.GetServerDateTime();
                articuloRepository.Insert(datos);
                return response;
            }
            catch (Exception e)
            {
                
                return response.Error(e.Message);
            }
            
        }

        public Response<List<Articulo>> ListarArticulosByStock(int idArea, string nombreArticulo, bool conStock, bool bajoStock, bool sinStock, int idPuesto)
        {
            Response<List<Articulo>> response = new Response<List<Articulo>>();

            try
            {
                response.Value = articuloRepository.GetArticulosByStock(idArea, nombreArticulo, conStock, bajoStock, sinStock, idPuesto);
                return response;
            }
            catch (Exception e)
            {
                String innermessage = (e.InnerException != null) ? e.InnerException.Message : "";
                return response.Error(innermessage);
            }
        }

        public Response<Articulo> Update(Articulo datos)
        {
            Response<Articulo> response = new Response<Articulo>();
            try
            {
                if (datos.Descripcion.IsNullOrEmpty())
                {
                    return response.Error("Descripcion de articulo obligatoria");
                }
                if (datos.Moneda.IsNullOrEmpty())
                {
                    return response.Error("El tipo de moneda es obligatorio");
                }
                if (datos.Area == null)
                {
                    return response.Error("El area es obligatorio");
                }
                if (datos.UnidadMedida == null)
                {
                    return response.Error("La unidad de medida es obligatoria");
                }
                if (datos.Estado.IsNullOrEmpty())
                {
                    return response.Error("El articulo debe tener un estado");
                }
                if (articuloRepository.GetByName(datos.Descripcion, datos.Id_Articulo) != null)
                {
                    return response.Error("El nombre de articulo ya existe");
                }

                datos.FechaModificacion = BaseRepository.GetServerDateTime();
                articuloRepository.Update(datos);
                return response;
            }
            catch(Exception e)
            {
                return response.Error(e.Message);
            }
        }
    }
}
