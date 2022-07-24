using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entities
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        
    }
}
