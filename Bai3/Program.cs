using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So sanh chuoi trong C#");
            Console.WriteLine("-------------------------------------");
            Console.Write("Nhập chuoi thu nhat = ");
            string str1 = Console.ReadLine();
            Console.Write("Nhập chuoi thu hai = ");
            string str2 = Console.ReadLine();

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " va " + str2 + " la giong nhau.");
            }
            else
            {
                Console.WriteLine(str1 + " va " + str2 + " la khong giong nhau.");
            }

            Console.ReadKey();
        }
    }
}
