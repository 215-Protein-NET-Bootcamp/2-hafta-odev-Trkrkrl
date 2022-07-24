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
            _employeeDal.Add(employee);
            return new SuccessResult("Employee added");
        }

        public IResult Delete(Employee employee)
        {
            return new Result(true, "Employee deleted");
        }
        public IResult Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return new Result(true);    
        }

        public IDataResult<List<Employee>> GetAll()
        {
            return new DataResult<List<Employee>>(_employeeDal.GetAll(), true, "Employees Listed");
        }

        public IDataResult<Employee> GetById(int employeeId)
        {
            var response = _employeeDal.Get(c => c.Id == employeeId);
            return new SuccessDataResult<Employee>(response);
        }

       
    }
}
