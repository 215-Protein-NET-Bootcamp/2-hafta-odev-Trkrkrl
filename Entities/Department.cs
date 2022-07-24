﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Department : IEntity
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int CountryId { get; set; }
       
        public bool IsDeleted { get; set; }
    }
}
