using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemoCSharp.Models
{
    class Employee
    {
        public int empId;
        public string empName;
        public float empSalary;

        public Employee()
        {
            Console.WriteLine("Default constructor is called...");
        }

        public Employee(int id, string name, float salary)
        {
            this.empId = id;
            this.empName = name;
            this.empSalary = salary;
            Console.WriteLine("Parameterized constructor is called");
        }

        public void ShowData()
        {
            Console.WriteLine("ID : " + empId);
            Console.WriteLine("Name : "+ empName);
            Console.WriteLine("Salary : " + empSalary);

        }

    }


}
