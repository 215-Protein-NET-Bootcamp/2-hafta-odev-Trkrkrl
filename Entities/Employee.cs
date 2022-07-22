using Core.Entities;
using System;

namespace Entities
{
    public class Employee : IEntity
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string DeptId { get; set; }


    }
}
