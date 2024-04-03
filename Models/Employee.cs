using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectorySerialize_Task.Models
{
    internal class Employee
    {
      

        public Employee(int iD, string name, decimal salary)
        {
            ID = iD;
            Name = name;
            Salary = salary;
        }

        public int ID { get; set; }
    
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($" Id:{ID}\n Name:{Name}\n Salary:{Salary}");
        }
    }
}
