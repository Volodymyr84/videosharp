using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Найти значение выражения: 1 - 2 + 3 - 4 + 5-6 + 7 - 8 + 9 - 10 ... 
/// Если в нём N слагаемых.
/// Число N от 1 до 123456789.
/// Начальные данные: первая строка ввода содержит число N.
/// Вывод результата: вывод должен содержать одно число – ответ на задачу.
/// </summary>
namespace Random_1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.Write("Enter number N: ");
            int N = int.Parse(Console.ReadLine());
            int rez = 1;

            for (int i = 2; i <= N; i++)
            {
                if (i % 2 == 0)
                    rez -= i;
                else
                    rez += i;

            }
            Console.WriteLine(rez);
            Console.ReadKey();
        }
    }
}
