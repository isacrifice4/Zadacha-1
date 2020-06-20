using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int srA = 0;
            int[,] array = new int[5,5];
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    array[i, j] = rnd.Next(-8, 8);
                    if (i + j == 4)
                        srA += array[i, j];
                    Console.Write("{0} \t", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("Среднее арифметическое элементов в побочной диагонали - {0}", srA / 5);
            Console.ReadKey();
        }
    }
}
