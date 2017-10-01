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
    public class AreaService : IAreaService
    {
        private AreaRepository repository;

        public AreaService()
        {
            repository = new AreaRepository();
        }

        public Response<Area> Delete(int id)
        {
            Response<Area> response = new Response<Area>();
            try
            {
                Area area = repository.GetById(id);

                if (area == null)
                {
                    return response.Error("Area no encontrada");
                }
                area.Estado = "I";
                return Update(area);
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<List<Area>> GetAll()
        {
            Response<List<Area>> response = new Response<List<Area>>();
            try
            {
                response.Value = repository.GetAll();
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<Area> GetById(int id)
        {
            Response<Area> response = new Response<Area>();
            try
            {
                Area area = repository.GetById(id);

                if (area == null)
                {
                    return response.Error("Area no encontrada");
                }

                response.Value = area;
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }

        }

        public Response<Area> Insert(Area datos)
        {
            Response<Area> response = new Response<Area>();
            try
            {       
                if (datos.CodArea.IsNullOrEmpty())
                {
                    return response.Error("Codigo de Area obligatorio");
                }

                if (datos.NombreArea.IsNullOrEmpty())
                {
                    return response.Error("Nombre de Area obligatorio");
                }

                if (repository.GetByName(datos.NombreArea) != null)
                {
                    return response.Error("El nombre de Area ingresado ya existe");
                }

                datos.FechaCreacion = BaseRepository.GetServerDateTime();
                repository.Insert(datos);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public List<Area> Listar()
        {
            List<Area> listaArea = repository.GetAll().ToList();
            Area obj = new Area()
            {
                Id_Area = 0,
                NombreArea = "Seleccione área"
            };
            listaArea.Insert(0, obj);
            return listaArea;
        }

        public Response<Area> Update(Area datos)
        {
            Response<Area> response = new Response<Area>();
            try
            {
                if (datos.CodArea.IsNullOrEmpty())
                {
                    return response.Error("Codigo de Area obligatorio");
                }

                if (datos.NombreArea.IsNullOrEmpty())
                {
                    return response.Error("Nombre de Area obligatorio");
                }

                if (repository.GetByName(datos.NombreArea, datos.Id_Area) != null)
                {
                    return response.Error("El nombre de Area ingresado ya existe");
                }

                datos.FechaModificacion = BaseRepository.GetServerDateTime();
                repository.Update(datos);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }
    }
}
