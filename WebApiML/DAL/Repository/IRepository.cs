using System.Collections.Generic;

namespace WebApiML.DAL.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
    }
}
