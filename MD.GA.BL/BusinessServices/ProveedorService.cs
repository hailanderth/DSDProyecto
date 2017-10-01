using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.DA.Repositories;
using MD.GA.DA.Base;
using MD.GA.BE.Entidades;
using MD.GA.BL.Base;
using MD.GA.COMMOM.Response;
using MD.GA.BL.Util;
using MD.GA.BL.BusinessInterfaces;

namespace MD.GA.BL.BusinessServices
{
    public class ProveedorService : IProveedorService
    {
        ProveedorRepository proveedorRepository;

        public ProveedorService()
        {
            proveedorRepository = new ProveedorRepository();
        }

        public Response<Proveedor> Delete(int id)
        {
            Response<Proveedor> response = new Response<Proveedor>();
            try
            {
                Proveedor proveedor = proveedorRepository.GetById(id);
                if (proveedor == null)
                {
                    return response.Error("Proveedor no encontrado");
                }
                proveedor.Estado = "I";
                return Update(proveedor);
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<List<Proveedor>> GetAll()
        {
            Response<List<Proveedor>> response = new Response<List<Proveedor>>();
            try
            {
                response.Value = proveedorRepository.GetAll();
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public Response<Proveedor> GetById(int id)
        {
            Response<Proveedor> response = new Response<Proveedor>();
            try
            {
                Proveedor proveedor = proveedorRepository.GetById(id);
                if (proveedor == null)
                {
                    return response.Error("Proveedor no encontrado");
                }
                response.Value = proveedor;
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }

        }

        public Response<Proveedor> Insert(Proveedor datos)
        {
            Response<Proveedor> response = new Response<Proveedor>();
            try
            {
                if (datos.RazonSocial.IsNullOrEmpty())
                {
                    return response.Error("Razon social es obligatoria");
                }

                if (datos.RUC.IsNullOrEmpty())
                {
                    return response.Error("Ruc es obligatorio");
                }

                if (datos.Estado.IsNullOrEmpty())
                {
                    return response.Error("El estado es obligatorio");
                }

                if (proveedorRepository.GetByRazonSocialRUC(datos.RazonSocial, datos.RUC) != null)
                {
                    return response.Error("RUC / Razon social ya existen");
                }


                datos.FechaCreacion = BaseRepository.GetServerDateTime();
                proveedorRepository.Insert(datos);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }
        }

        public List<Proveedor> Listar()
        {
            List<Proveedor> listaProveedor = proveedorRepository.GetAll().ToList();
            Proveedor obj = new Proveedor()
            {
                Id_Proveedor = 0,
                RazonSocial = "Seleccione proveedor"
            };
            listaProveedor.Insert(0, obj);
            return listaProveedor;
        }

        public Response<Proveedor> Update(Proveedor datos)
        {
            Response<Proveedor> response = new Response<Proveedor>();
            try
            {
                if (datos.RazonSocial.IsNullOrEmpty())
                {
                    return response.Error("Razon social es obligatoria");
                }

                if (datos.RUC.IsNullOrEmpty())
                {
                    return response.Error("Ruc es obligatorio");
                }

                if (datos.Estado.IsNullOrEmpty())
                {
                    return response.Error("El estado es obligatorio");
                }
                if (proveedorRepository.GetByRazonSocialRUC(datos.RazonSocial, datos.RUC, datos.Id_Proveedor) != null)
                {
                    return response.Error("RUC / Razon social ya existen");
                }
                datos.FechaModificacion = BaseRepository.GetServerDateTime();
                proveedorRepository.Update(datos);
                return response;
            }
            catch (Exception e)
            {
                return response.Error(e.Message);
            }

        }
    }
}
