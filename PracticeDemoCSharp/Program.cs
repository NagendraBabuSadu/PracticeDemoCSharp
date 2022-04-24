using PracticeDemoCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee();
            emp.ShowData();
            Employee emp1 = new Employee(121, "Fahad", 12300);
            emp1.ShowData();





            Console.ReadLine();

        }
    }
}
