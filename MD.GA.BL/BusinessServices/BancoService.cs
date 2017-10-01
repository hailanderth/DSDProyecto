using MD.GA.BL.BusinessInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.BE.Entidades;
using MD.GA.COMMOM.Response;
using MD.GA.DA.Repositories;
using MD.GA.BL.Util;
using MD.GA.DA.Base;

namespace MD.GA.BL.BusinessServices
{
    public class BancoService : IBancoService
    {

        private BancoRepository bancoRepository;

        public BancoService()
        {
            bancoRepository = new BancoRepository();

        }
        public Response<BANCO> Delete(int id)
        {
            Response<BANCO> response = new Response<BANCO>();
            try
            {
                BANCO banco = bancoRepository.GetById(id);
                if (banco == null)
                {
                    return response.Error("Banco no encontrado");
                }
                banco.Estado = "I";
                Update(banco);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<List<BANCO>> GetAll()
        {
            Response<List<BANCO>> response = new Response<List<BANCO>>();
            try
            {
                response.Value = bancoRepository.GetAll();
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<BANCO> GetById(int? id_banco)
        {
            Response<BANCO> response = new Response<BANCO>();
            try
            {
                BANCO banco = bancoRepository.GetById(id_banco);

                if (banco == null)
                {
                    return response.Error("Banco no encontrado");
                }

                response.Value = banco;
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<BANCO> GetById(int id)
        {
            Response<BANCO> response = new Response<BANCO>();
            try
            {
                BANCO banco = bancoRepository.GetById(id);

                if (banco == null)
                {
                    return response.Error("Banco no encontrada");
                }

                response.Value = banco;
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<BANCO> Insert(BANCO datos)
        {
            Response<BANCO> response = new Response<BANCO>();
            try
            {
                if (datos.Nombre.IsNullOrEmpty())
                {
                    return response.Error("El nombre es obligatorio");
                }
                if (datos.Estado.IsNullOrEmpty())
                {
                    return response.Error("El estado es obligatorio");
                }                
                datos.FechaCreacion = BaseRepository.GetServerDateTime();
                bancoRepository.Insert(datos);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public List<BANCO> Listar()
        {
            List<BANCO> listaBanco = bancoRepository.GetAll().ToList();
            BANCO obj = new BANCO()
            {
                Id_Banco = 0,
                Nombre = "Seleccione banco"
            };
            listaBanco.Insert(0, obj);
            return listaBanco;
        }

        public Response<BANCO> Update(BANCO datos)
        {
            Response<BANCO> response = new Response<BANCO>();
            try
            {
                if (datos.Nombre.IsNullOrEmpty())
                {
                    return response.Error("El nombre es obligatorio");
                }
                if (datos.Estado.IsNullOrEmpty())
                {
                    return response.Error("El estado es obligatorio");
                }       
                datos.FechaModificacion = BaseRepository.GetServerDateTime();
                bancoRepository.Update(datos);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }
    }
}
