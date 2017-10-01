using MD.GA.BE.Entidades;
using MD.GA.COMMOM.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MD.GA.WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceUsuario
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        Response<Usuario> UsuarioValidarLogin(string usuario, string password);
    }
}
