using System;

namespace Laba_3_4_v._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nums_A = new int[3, 3];
            int[,] nums_B = new int[3, 3];
            int[,] nums_sum = new int[3, 3];
            int[,] nums_balance = new int[3, 3];
            Random rand = new Random();
            Console.Write("Массив А:");
            Console.WriteLine("\n\n");
            for (int i = 0; i < nums_A.GetLength(0); i++)
            {
                for (int j = 0; j < nums_A.GetLength(1); j++)
                {
                    nums_A[i, j] = rand.Next(100);

                    Console.Write("{0, 2}  ", nums_A[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("Массив B:");
            Console.WriteLine("\n\n");
            for (int i = 0; i < nums_B.GetLength(0); i++)
            {
                for (int j = 0; j < nums_B.GetLength(1); j++)
                {
                    nums_B[i, j] = rand.Next(100);

                    Console.Write("{0, 2}  ", nums_B[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Сумма Матрицы А и В:");
            for (int i = 0; i < nums_sum.GetLength(0); i++)
            {
                for (int j = 0; j < nums_sum.GetLength(1); j++)
                {
                    nums_sum[i, j] = nums_A[i, j] + nums_B[i, j];
                    Console.Write("{0, 2}  ", nums_sum[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Разницы Матрицы А и В:");
            for (int i = 0; i < nums_balance.GetLength(0); i++)
            {
                for (int j = 0; j < nums_balance.GetLength(1); j++)
                {
                    nums_balance[i, j] = nums_A[i, j] - nums_B[i, j];
                    Console.Write("{0, 2}  ", nums_balance[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
