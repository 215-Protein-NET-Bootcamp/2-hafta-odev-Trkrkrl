using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDapperDal<T> where T : class, IEntity, new()
    {
        //--asagıdakiler de dapper için
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int entityId);
        Task Update(T entity);
    }
}
