using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{


    // burdan asagi komek almisam
    internal class Department
    {
        public Employee[] Employees;
        public Department()
        {
            Employees = new Employee[0];
        }


        public void AddEmployee(Employee employer)
        {
            Array.Resize(ref Employees, Employees.Length+1);
            Employees[Employees.Length-1] = employer;
        }


        public void ShowEmployeeInfo(Employee employer)
        {
            Console.WriteLine($"Name: {employer.Name}");
            Console.WriteLine($"Name: {employer.Surname}");
            Console.WriteLine($"Name: {employer.Age}");
            Console.WriteLine($"Name: {employer.DepartmentName}");
            Console.WriteLine($"Name: {employer.Salary}");

        }


        public Employee[] GetAllEmployees()
        {
            return Employees;
        }

        // burani basa duse bilmedim
        public void GetAllEmployeesBySalary(int minSalary,int maxSalary)
        {

        }


    }
}
