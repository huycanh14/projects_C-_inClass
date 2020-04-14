using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Data
            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Query syntax
            IEnumerable<int> SoNum = from a in Num
                                     where a%2 == 0
                                     orderby a
                                     select a;
            //Excute
            /*foreach (var item in SoNum)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();*/

            //Mathod syntax
            IEnumerable<int> SoNum2 = Num.Where(num => num % 2 == 0).OrderBy(n => n);

            //sử dụng var khi không biết kiểu trả về ntn
            var numQuery = from num in Num
                           where num % 2 == 0
                           select num;
            /*foreach (var item in SoNum)
                Console.WriteLine(item);
            foreach (var item in SoNum2)
                Console.WriteLine(item);*/
            //foreach (var item in numQuery)
            //    Console.WriteLine(item);

            string[] person = { "Job", "Steven", "Tim", "Johny", "Donnie", "Jet" };
            var pQuery = from p in person
                         //where p == "Job" //tìm phần tử có giá trị la Job
                         //where p.StartsWith("J" )//tìm phần tử có giá trị J đầu tiên
                         where p.EndsWith("j" )//tìm phần tử có giá trị J cuối cùng
                         select p;
            foreach (var item in pQuery)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}
