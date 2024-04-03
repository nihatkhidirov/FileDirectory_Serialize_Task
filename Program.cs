using FileDirectorySerialize_Task.Models;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace FileDirectorySerialize_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\hp\\Desktop\\Task\\FileDirectorySerialize_Task\\Files\\database.json";
            Department department = new Department();
            Employee employee1 = new Employee(1, "Nihat", 300);
            Employee employee2 = new Employee(2, "Samir", 400);
            Employee employee3 = new Employee(3, "Senan", 500);
            Employee employee4 = new Employee(4, "Aqil", 600);





            Console.WriteLine("-------------------___________Menu--------------________________");
            Console.WriteLine("1. Add Employee ");
            Console.WriteLine("2. GetEmployeeById");
            Console.WriteLine("3. RemoveEmployee");
            Console.WriteLine("Zehmet Olmazsa,Etmek Istediyiniz Emeliyyati Secin");
            int command = Convert.ToInt32(Console.ReadLine());
            switch (command)
            {
                case 1:
                    department.Employees.Add(employee1);
                    department.Employees.Add(employee2);
                    department.Employees.Add(employee3);
                    department.Employees.Add(employee4);
                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }
                    string employeeList = JsonConvert.SerializeObject(department.Employees);
                    using (FileStream fileStream = new(path, FileMode.Create))
                    {
                        using (StreamWriter streamWriter = new(fileStream))
                        {
                            streamWriter.Write(employeeList);
                        }
                    }
                    break;
                case 2:
                    using (FileStream fileStream = new(path, FileMode.Open))
                    {
                        using (StreamReader streamReader = new(fileStream))
                        {
                            string empListstr = streamReader.ReadToEnd();
                            var employeeListReader = JsonConvert.DeserializeObject<List<Employee>>(empListstr);
                            Console.WriteLine("Id Daxil Edin: ");
                            int Id1 = int.Parse(Console.ReadLine());
                            var existEmpByID = employeeListReader.Find(e => e.ID ==Id1);
                            employeeListReader.Remove(existEmpByID);
                            using (FileStream fileStream1=new(path,FileMode.Create))
                            {
                                using (StreamWriter streamWriter= new(fileStream1))
                                {
                                    streamWriter.Write(employeeListReader);
                                }
                            }

                        }
                    }


                    break;
                case 3:

                    break;


            }

        }
    }
}