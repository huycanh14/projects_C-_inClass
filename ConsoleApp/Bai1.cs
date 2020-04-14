using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Bai1
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            Console.Write("Nhập số n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dãy số nguyên tố đến n là: ");
            for(int i = 1; i <= n; i++)
            {
                if(SoNguyenTo(i) == true)
                {
                    Console.Write(i + "\t");
                }
            }
            Console.ReadKey();
        }
        public static bool SoNguyenTo(int n)
        {
            int bien_dem = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    bien_dem++;
            if (bien_dem == 2)
                return true;
            else return false;
        }
    }
}
