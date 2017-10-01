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
using MD.GA.DA.Base;
using MD.GA.BL.BusinessInterfaces;

namespace MD.GA.BL.BusinessServices
{
    public class EmpresaService : IEmpresaService
    {
        private EmpresaRepository empresaRepository;

        public EmpresaService()
        {
            empresaRepository = new EmpresaRepository();
        }
        public Response<Empresa> Delete(int id)
        {
            Response<Empresa> response = new Response<Empresa>();
            try
            {
                Empresa empresa = empresaRepository.GetById(id);
                if (empresa == null)
                {
                    return response.Error("Empresa no encontrada");
                }
                empresa.Estado = "I";
                return Update(empresa);
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<List<Empresa>> GetAll()
        {
            Response<List<Empresa>> response = new Response<List<Empresa>>();
            try
            {
                response.Value = empresaRepository.GetAll();
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<Empresa> GetById(int id)
        {
            Response<Empresa> response = new Response<Empresa>();
            try
            {
                Empresa empresa = empresaRepository.GetById(id);
                if (empresa == null)
                {
                    return response.Error("Empresa no encontrada");
                }
                response.Value = empresa;
                return response;
            }
            catch(Exception e)
            {
                return response.Error(e.Message);
            }

        }

        public Response<Empresa> Insert(Empresa datos)
        {
            Response<Empresa> response = new Response<Empresa>();
            try
            {
                if (datos.Estado.IsNullOrEmpty())
                {
                    return response.Error("El estado es obligatorio");
                }

                if (datos.RazonSocial.IsNullOrEmpty())
                {
                    return response.Error("La razon social es obligatoria");
                }
                if (empresaRepository.GetByRazonSocialRUC(datos.RazonSocial, datos.RUC) != null)
                {
                    return response.Error("El nombre de la empresa ya existe");
                }

                datos.FechaCreacion = BaseRepository.GetServerDateTime();
                empresaRepository.Insert(datos);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public List<Empresa> Listar()
        {
            List<Empresa> listaEmpresa = empresaRepository.GetAll().ToList();
            Empresa obj = new Empresa()
            {
                Id_Empresa = 0,
                RazonSocial = "Seleccione Empresa"
            };
            listaEmpresa.Insert(0, obj);
            return listaEmpresa;
        }

        public Response<Empresa> Update(Empresa datos)
        {
            Response<Empresa> response = new Response<Empresa>();
            try
            {
                if (datos.Estado.IsNullOrEmpty())
                {
                    return response.Error("El estado es obligatorio");
                }

                if (datos.RazonSocial.IsNullOrEmpty())
                {
                    return response.Error("La razon social es obligatoria");
                }
                if (empresaRepository.GetByRazonSocialRUC(datos.RazonSocial, datos.RUC, datos.Id_Empresa) != null)
                {
                    return response.Error("El nombre de la empresa ya existe");
                }

                datos.FechaModificacion = BaseRepository.GetServerDateTime();
                empresaRepository.Update(datos);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }
    }
}
