using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_ML.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
    }
}
