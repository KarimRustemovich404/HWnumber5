using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWnumber5
{
    internal class Program
    {
        static void Lab_UPR_6_2()
        {
            Console.Write("Упражнение 6.2\nПрограмма перемножает две случайные матрицы");
            int[,] myArray = new int[3, 3];

            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    myArray[i, j] = random.Next(-100, 100);
                    Console.Write(myArray[i, j] + ",");
                }
                Console.WriteLine();
            }
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    myArray[x, y] = random.Next(-100, 100);
                    Console.Write(myArray[x, y] + ",");
                }
                Console.WriteLine();


                int[,] myArray1 = new int[3, 3];

                Random random1 = new Random();
                for (int a = 0; a < 3; a++)
                {
                    for (int b = 0; b < 3; b++)
                    {
                        myArray1[a, b] = random1.Next(-100, 100);
                        Console.Write(myArray1[a, b] + ",");
                    }
                    Console.WriteLine();
                }
                for (int c = 0; c < 3; c++)
                {
                    for (int d = 0; d < 3; d++)
                    {
                        myArray[c, d] = random1.Next(-100, 100);
                        Console.Write(myArray1[c, d] + ",");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();

                static void Lab_UPR_6_3()
                {
                    Console.Write("Упражнение 6.3\nПрограмма вычисляет среднюю температуру за год");
                    int[,] temperature = new int[12, 30];

                    Random random2 = new Random();
                    for (int i = 0; i < 12; i++)
                    {
                        for (int j = 0; i < 12; j++)
                        {
                            temperature[i, j] = random2.Next(-40, 40);

                            Console.Write(temperature[i, j] + ",");
                        }
                        Console.WriteLine();
                    }
                    for (int a = 0; a < 30; a++)
                    {
                        for (int b = 0; b < 30; b++)
                        {
                            temperature[a, b] = random2.Next(-40, 40);

                            Console.Write(temperature[a, b] + ",");
                        }
                        Console.WriteLine();

                    }


                    static void Main(string[] args)
                    {
                        Lab_UPR_6_2();
                        Lab_UPR_6_3();

                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
