using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public  interface IEfDal<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//içerisinde ....geçenleri getir fonksiyonu

        T Get(Expression<Func<T, bool>> filter); //yukardakinin null olan hali
        void Update(T entity);
    }
}
