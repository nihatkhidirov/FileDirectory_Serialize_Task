using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectorySerialize_Task.Models
{
    internal class Employee
    {
        static int counter = 0;
        public Employee()
        {
            counter++;
            this.ID= counter;
        }
        public int ID { get; set; }
        static int EmployeeID { get; set; }
    
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($" Id:{ID}\n Name:{Name}\n Salary:{Salary}");
        }
    }
}
