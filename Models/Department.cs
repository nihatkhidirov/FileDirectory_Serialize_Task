using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectorySerialize_Task.Models
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Employee>Employees { get; set; }
        public Department()
        {
            Employees=new List<Employee>();
        }
       
        
    }
}
