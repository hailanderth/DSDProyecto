using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.GA.DA.Base
{
    public interface IBaseRepository<TClass> where TClass : class
    {
        List<TClass> GetAll();
        TClass GetById(int id);
        void Insert(TClass datos);
        void Update(TClass datos);
    }
}
