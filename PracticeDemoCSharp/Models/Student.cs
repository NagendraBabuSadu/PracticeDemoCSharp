using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemoCSharp.Models
{
    class Student
    {
        public int Id;
        public string Name;

        public Student()
        {
            
        }

        public void Insert(string name, int id)
        {
            this.Id = id;
            this.Name = name;
        }

        public void ShowRecord()
        {
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.WriteLine(" " + Id+ ": "+" " + Name);
            Console.WriteLine();

            Console.ForegroundColor = System.ConsoleColor.White;


        }
    }
}
