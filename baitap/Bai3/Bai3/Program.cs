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
            Console.OutputEncoding = Encoding.UTF8;
            int[,] mang = new int[6,5];
            mang = nhapgiatrivaomang(mang);
            int max = mang[0, 0];
            int min = mang[0, 0];
            int tong = 0; int dem = 0;
            Console.WriteLine("Giá trị trong mảng là:");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0}\t", mang[i,j]);
                    tong += mang[i, j];
                    dem++;
                    if(max < mang[i, j])
                    {
                        max = mang[i, j];
                    }
                    if (min > mang[i, j])
                    {
                        min = mang[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Giá trị lớn nhất trong mảng là {0}:", max);
            Console.WriteLine("Giá trị nhỏ nhất trong mảng là {0}:", min);
            Console.WriteLine("Tổng các giá trị trong mảng là {0}:", tong);
            Console.WriteLine("Giá trị trung bình trong mảng là {0}:", (double)tong/dem);
            Console.Read();
        }

        private static int[,] nhapgiatrivaomang(int[,] mang)
        {
            for(int i = 0; i< 6; i++)
            {
                for(int j = 0; j< 5; j++)
                {
                    mang[i, j] = i+j+2;
                }
            }
            return mang;
        }
    }
}
