using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemoCSharp
{
    class Program
    {
        public void Show(params int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

        }


        public void ShowObjects(params object[] a)
        {
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] nums = { 1, 2, 3, 4, 5 };
            // p.Show(nums);
             object[] ob = { "King", 123, 'a', 3.14 };
            p.ShowObjects(ob);



            /*
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[] { 11, 12, 43, 23, 53, 56 };
            jaggedArray[1] = new int[] { 1, 2, 3, 4, 2, 2, 6, 7, 0 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] +" \t");
                   
                }
            }
            Console.WriteLine();
            Console.WriteLine(jaggedArray[0][1]);
            */






            Console.ReadLine();

        }
    }
}
