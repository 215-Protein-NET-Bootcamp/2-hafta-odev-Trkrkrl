using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;  
using System.Threading.Tasks;

namespace Core.DataAccess.Abstract
{
    public interface IBaseRepository<T> where T : class, IEntity, new()
    {
        //buradaki 2 methodu dalda efdal ve dapper dal a gönderdim
      
       
        void Add(T entity);
        //void Update(T entity);
        void Delete(T entity);
        


    }
}
