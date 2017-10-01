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
    public class PuestoService : IPuestoService
    {
        PuestoRepository puestoRepository;

        public PuestoService()
        {
            puestoRepository = new PuestoRepository();
        }

        public Response<Puesto> Delete(int id)
        {
            Response<Puesto> response = new Response<Puesto>();
            try
            {
                Puesto puesto = puestoRepository.GetById(id);
                if (puesto == null)
                {
                    return response.Error("Puesto no encontrada");
                }
                puesto.Estado = "I";
                return Update(puesto);
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<List<Puesto>> GetAll()
        {
            Response<List<Puesto>> response = new Response<List<Puesto>>();
            try
            {
                response.Value = puestoRepository.GetAll();
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<Puesto> GetById(int id)
        {
            Response<Puesto> response = new Response<Puesto>();
            try
            {
                Puesto puesto = puestoRepository.GetById(id);
                if (puesto == null)
                {
                    return response.Error("Puesto no encontrada");
                }
                response.Value = puesto;
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<Puesto> Insert(Puesto datos)
        {
            Response<Puesto> response = new Response<Puesto>();

            try
            {
                if (datos.NombrePuesto.IsNullOrEmpty())
                {
                    return response.Error("Nombre es obligatorio");
                }
                if (datos.NombrePuesto.IsNullOrEmpty())
                {
                    return response.Error("Nombre es obligatorio");
                }
                if (puestoRepository.GetByName(datos.NombrePuesto) != null)
                {
                    return response.Error("El nombre ya existe");
                }

                datos.FechaCreacion = BaseRepository.GetServerDateTime();
                puestoRepository.Insert(datos);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<Puesto> Update(Puesto datos)
        {
            Response<Puesto> response = new Response<Puesto>();

            try
            {
                if (datos.NombrePuesto.IsNullOrEmpty())
                {
                    return response.Error("Nombre es obligatorio");
                }

                if (datos.NombrePuesto.IsNullOrEmpty())
                {
                    return response.Error("Nombre es obligatorio");
                }

                if (puestoRepository.GetByName(datos.NombrePuesto, datos.Id_Puesto) != null)
                {
                    return response.Error("El nombre ya existe");
                }

                datos.FechaModificacion = BaseRepository.GetServerDateTime();
                puestoRepository.Update(datos);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }
    }
}
