using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.BE.Entidades;
using MD.GA.BL.Base;
using MD.GA.COMMOM.Response;

namespace MD.GA.BL.BusinessInterfaces
{
    public interface IUsuarioService : IBaseService<Usuario>
    {
        Response<Usuario> Login(string usuario, string password);
        Response<DateTime> GetServerTime();
        String GetPass(string clave);
        String GetPassDes(string clave);
        Response<Usuario> GetByUser(string nombreUsuario);
    }
}
