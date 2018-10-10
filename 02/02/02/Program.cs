using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = 0;
            double v = 0;
            double t = 0;
            const double giatoc = 9.8;
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.Write("Nhập chiều cao h (m) = ");
                h = double.Parse(Console.ReadLine());
            } while (h < 0);
            h = 3.8;
            t = Math.Sqrt(2 * h/giatoc);
            v = giatoc * t;

           // Console.WriteLine("Chiều cao của h = {0}", h);
            Console.WriteLine("Thời gian của vật khi chạm đất là: t = {0} (s)", t);
            Console.WriteLine("Vận tốc của vật khi chạm đất là: v = {0} (m/s)", v);
            Console.ReadLine();
            
        }
    }
}
