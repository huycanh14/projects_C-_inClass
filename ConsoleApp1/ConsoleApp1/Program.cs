using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m1 = new int[] { 1, 8, 7, 4, 5, 7, 9 };
            Array.Sort(m1);
            foreach(int i in m1)
            {
                Console.Write(i);
                Console.Write("\t");
            }
            Console.ReadLine();
        }
    }
}
