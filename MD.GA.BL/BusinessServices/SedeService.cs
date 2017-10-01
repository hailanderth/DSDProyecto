using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.DA.Repositories;
using MD.GA.BE.Entidades;
using MD.GA.DA.Base;
using MD.GA.BL.Base;
using MD.GA.COMMOM.Response;
using MD.GA.BL.Util;
using MD.GA.BL.BusinessInterfaces;


namespace MD.GA.BL.BusinessServices
{
    public class SedeService : ISedeService
    {
        SedeRepository sedeRepository;
        public SedeService()
        {
            sedeRepository = new SedeRepository();
        }

        public Response<Sede> Delete(int id)
        {
            Response<Sede> response = new Response<Sede>();
            try
            {
                Sede sede = sedeRepository.GetById(id);
                if (sede == null)
                {
                    return response.Error("Sede no encontrada");
                }
                sede.Estado = "I";
                return Update(sede);
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<List<Sede>> GetAll()
        {
            Response<List<Sede>> response = new Response<List<Sede>>();
            try
            {
                response.Value = sedeRepository.GetAll();
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<Sede> GetById(int id)
        {
            Response<Sede> response = new Response<Sede>();
            try
            {
                Sede sede = sedeRepository.GetById(id);
                if (sede == null)
                {
                    return response.Error("Sede no encontrada");
                }
                response.Value = sede;
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<Sede> Insert(Sede datos)
        {
            Response<Sede> response = new Response<Sede>();
            try
            {
                if (datos.NombreSede.IsNullOrEmpty())
                {
                    return response.Error("Nombre de sede es obligatorio");
                }
                if (datos.Codigo.IsNullOrEmpty())
                {
                    return response.Error("El codigo es obligatorio");
                }
                if (datos.Estado.IsNullOrEmpty())
                {
                    return response.Error("El estado es obligatorio");
                }
                if (sedeRepository.GetByName(datos.NombreSede) != null)
                {
                    return response.Error("El nombre de sede ya existe");
                }

                datos.FechaCreacion = BaseRepository.GetServerDateTime();
                sedeRepository.Insert(datos);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public List<Sede> Listar()
        {
            List<Sede> listaSede = sedeRepository.GetAll().ToList();
            Sede obj = new Sede()
            {
                Id_Sede = 0,
                NombreSede = "Seleccione sede"
            };
            listaSede.Insert(0, obj);
            return listaSede;
        }

        public Response<Sede> Update(Sede datos)
        {
            Response<Sede> response = new Response<Sede>();
            try
            {
                if (datos.NombreSede.IsNullOrEmpty())
                {
                    return response.Error("Nombre de sede es obligatorio");
                }
                if (datos.Codigo.IsNullOrEmpty())
                {
                    return response.Error("El codigo es obligatorio");
                }
                if (datos.Estado.IsNullOrEmpty())
                {
                    return response.Error("El estado es obligatorio");
                }
                if (sedeRepository.GetByName(datos.NombreSede, datos.Id_Sede) != null)
                {
                    return response.Error("El nombre de sede ya existe");
                }

                datos.FechaModificacion = BaseRepository.GetServerDateTime();
                sedeRepository.Update(datos);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }
    }
}
