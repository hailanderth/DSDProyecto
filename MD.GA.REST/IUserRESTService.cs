using MD.GA.BE;
using MD.GA.BE.Entidades;
using MD.GA.COMMOM.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MD.GA.REST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserRESTService" in both code and config file together.
    [ServiceContract]
    public interface IUserRESTService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Usuarios", ResponseFormat = WebMessageFormat.Json)]
        Response<Usuario> Insert(Usuario datos);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Usuarios/{id}", ResponseFormat = WebMessageFormat.Json)]
        UsuarioEntidad GetById(string id);


        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Usuarios", ResponseFormat = WebMessageFormat.Json)]
        Response<Usuario> Update(Usuario datos);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Usuarios/{id}", ResponseFormat = WebMessageFormat.Json)]
        Response<Usuario> Delete(string id);
    }
}
