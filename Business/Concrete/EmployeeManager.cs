using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public IResult Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Employee>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Employee>> GetById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
