using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Folder : IEntity
    {
        public int Id { get; set; }
        public string AccessType { get; set; }
        public int EmployeeId { get; set; }
      
        public bool IsDeleted { get; set; }=false;  
    }
}
