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
    public class DapperDepartmentDal : IDepartmentDal
    {
        private readonly DapperDbContext _dapperDbContext;

        public DapperDepartmentDal(DapperDbContext dapperDbContext)
        {
            _dapperDbContext = dapperDbContext;
        }

        public void Add(Department entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Department entity)
        {
            throw new NotImplementedException();
        }

        public Department Get(Expression<Func<Department, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll(Expression<Func<Department, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
