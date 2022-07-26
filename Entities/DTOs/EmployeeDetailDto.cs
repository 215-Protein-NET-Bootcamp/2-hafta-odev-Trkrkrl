using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class EmployeeDetailDto:IDto
    {   
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public int CountryId { get; set; }
        public string EmployeeName { get; set; }
        public string CountryName { get; set; }
        public string DepartmentName { get; set; }
        public List<int> FolderList { get; set; }




    }
}
