using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк массивов");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов массивов");
            int a = int.Parse(Console.ReadLine());
            int[,] mass1 = new int[a, b];
            Console.WriteLine("Введите данные первого массива");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]: ");

                    mass1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] mass2 = new int[a, b];
            Console.WriteLine("Введите данные второго массива");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]: ");
                    mass2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] mass = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    mass[i, j] = mass1[i, j] + mass2[i, j];
                }
            }
            Console.WriteLine("Полученный третий массив");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
