using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Dapper
{
    public class DapperCountryDal:ICountryDal
    {
        private readonly DapperDbContext _dapperDbContext;

        public DapperCountryDal(DapperDbContext dapperDbContext)
        {
            _dapperDbContext = dapperDbContext;
        }

        public void Add(Country entity)
        {
            //var query="INSESSRT INTO dbo."
        }

        public void Delete(Country entity)
        {
            throw new NotImplementedException();
        }

        public Country Get(Expression<Func<Country, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAll(Expression<Func<Country, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
