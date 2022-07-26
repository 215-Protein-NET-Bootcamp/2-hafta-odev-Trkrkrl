using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee,EfCoreDbContext>, IEmployeeDal
    {
        public List<EmployeeDetailDto> GetDetailsById(Expression<Func<EmployeeDetailDto, bool>> filter = null)//bunun Iemployeedal da daolması lazım yoksa hata verir
        {
            using (EfCoreDbContext context = new EfCoreDbContext())
            {
                var result = from a in context.Employees
                             join b in context.Departments on a.DepartmentId equals b.DepartmentId
                             join r in context.Countries on b.CountryId equals r.Id

                             select new EmployeeDetailDto   
                             {
                                 // Cuntryname, Departmentname,Employeename
                                 EmployeeId = a.Id,
                                 DepartmentId = b.DepartmentId,
                                 CountryId = r.Id,
                                 EmployeeName = a.Name, 
                                 CountryName = r.Name,
                                 DepartmentName = b.DepartmentName,
                                
                                 
                                 //folderList
                                 FolderList = (from f in context.Folders where f.EmployeeId== a.Id select f.Id).ToList()    
                                
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();


            }
        }

    }
}
