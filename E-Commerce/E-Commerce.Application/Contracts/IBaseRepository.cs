using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Applications.Contracts
{
    public interface IBaseRepository<T>
    {
        T Create(T entity);
        bool Update(T entity,int id);
        bool Delete(T entity,int id);
        IQueryable<T> GetAll();
        T GetById(int id);
        int Complete();
    }
}
