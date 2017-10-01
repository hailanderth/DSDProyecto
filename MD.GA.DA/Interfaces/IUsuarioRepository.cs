using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.DA.Base;
using MD.GA.BE.Entidades;

namespace MD.GA.DA.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario GetByUser(string user);
        Usuario GetByUser(string user, int idUserOriginal);
        Usuario ValidarLogin(String user, String password);
        String GetPassEn(string clave);
        String GetPassDes(string clave);

    }
}
