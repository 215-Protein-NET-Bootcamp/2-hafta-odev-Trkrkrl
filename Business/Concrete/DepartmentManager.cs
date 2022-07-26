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
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public IResult Add(Department department)
        {
            try
            {
                _departmentDal.Add(department);
                return new SuccessResult("department Added Successfully");
            }
            catch (Exception ex)
            {

                throw new Exception("department Adding Error");
            }
        }

        public IResult Delete(Department department)
        {
            _departmentDal.Delete(department);
            return new Result(true, "department Deleted");
        }

        public IDataResult<List<Department>> GetAll()
        {
            return new DataResult<List<Department>>(_departmentDal.GetAllAsync().Result, true, "Departments Listed");
        }

        public IDataResult<Department> GetById(int departmentId)
        {
            return new SuccessDataResult<Department>(_departmentDal.GetByIdAsync(departmentId).Result);

        }

        public IResult Update(Department department)
        {
            _departmentDal.Update(department);
            return new Result(true);
        }
    }
}
