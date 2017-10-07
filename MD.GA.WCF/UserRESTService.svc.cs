using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MD.GA.BE;
using MD.GA.COMMOM.Response;
using MD.GA.BL.BusinessServices;

namespace MD.GA.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserRESTService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserRESTService.svc or UserRESTService.svc.cs at the Solution Explorer and start debugging.
    public class UserRESTService : IUserRESTService
    {
        public Response<UsuarioEntidad> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public UsuarioEntidad GetById(string id)
        {
            UsuarioService oUsuarioService = new UsuarioService();
            var response = oUsuarioService.GetById(int.Parse(id));
            var entidad = response.Value;
            UsuarioEntidad oUsuarioEntidad = new UsuarioEntidad();
            oUsuarioEntidad.Id_Usuario = entidad.Id_Usuario;
            oUsuarioEntidad.Nombres = entidad.Nombres;
            oUsuarioEntidad.Apellidos = entidad.Apellidos;
            oUsuarioEntidad.Password = entidad.Password;
            oUsuarioEntidad.Puesto = entidad.Puesto;
            oUsuarioEntidad.Estado = entidad.Estado;

            return oUsuarioEntidad;
        }

        public Response<UsuarioEntidad> Insert(UsuarioEntidad datos)
        {
            throw new NotImplementedException();
        }

        public Response<UsuarioEntidad> Update(UsuarioEntidad datos)
        {
            throw new NotImplementedException();
        }
    }
}
