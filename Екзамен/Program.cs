using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Екзамен
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк массива");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];



            for (int i = 0; i < n; i++)

                for (int j = 0; j < m; j++)
                {

                    Console.WriteLine("Введите X{0},{1} эллемент массива A", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());


                }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", a[i, j]);

                }
            }
            Console.ReadKey();
        }
    
    }
}
