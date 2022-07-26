using Core.DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEmployeeDal: IBaseRepository<Employee>,IEfDal<Employee>
    {
        public List<EmployeeDetailDto> GetDetailsById(Expression<Func<EmployeeDetailDto, bool>> filter = null);

    }
}
