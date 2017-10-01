using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.COMMOM.Response;

namespace MD.GA.BL.Base
{
    public interface IBaseService<TClass> where TClass : class
    {
        Response<List<TClass>> GetAll();
        Response<TClass> GetById(int id);
        Response<TClass> Insert(TClass datos);
        Response<TClass> Update(TClass datos);
        Response<TClass> Delete(int id);
    }
}
