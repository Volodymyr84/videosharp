using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square__N_x_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.Write("Enter a square size from 1 to 80:  ");
                 N = int.Parse(Console.ReadLine());
            }
            while (N < 1 | N > 80);
                string[] col = new string[N];
                string frame = "";
                for (int i = 0; i < col.Length; i++)
                {
                    frame += "*";
                }
                for (int i = 0; i < col.Length; i++)
                {
                    col[i] = frame;
                    Console.WriteLine(col[i]);
                }
            
        }
    }
}
