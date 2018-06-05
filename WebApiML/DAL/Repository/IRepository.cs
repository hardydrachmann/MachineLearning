using System.Collections.Generic;

namespace WebApiML.DAL.Repository
{
    //Repository Interface
    public interface IRepository<T>
    {
        List<T> GetAll();
    }
}
