using System;

namespace Laba3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[,] A = new int[3, 3];
                int[,] B = new int[3, 3];
                double del = 0;
                Random rand = new Random();
                Console.Write("Массив А:");
                Console.WriteLine("\n\n");
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        A[i, j] = rand.Next(100);
                        Console.Write("{0, 2}  ", A[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.Write("Массив B:");
                Console.WriteLine("\n\n");
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        B[i, j] = rand.Next(100);

                        Console.Write("{0, 2}  ", B[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n\n");
                Sum(A, B, out del);
                Console.WriteLine();
                NoSum(A, B, out del);
                Console.WriteLine();
            }
            static int[,] Sum(int[,] A, int[,] B, out double del)
            {
                int s = 0;
                int[,] sum_1 = new int[3, 3];
                for (int i = 0; i < sum_1.GetLength(0); i++)
                {
                    for (int j = 0; j < sum_1.GetLength(1); j++)
                    {
                        sum_1[i, j] = A[i, j] + B[i, j];
                        Console.Write(" " + sum_1[i, j]);
                        s += sum_1[i, j];
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                del = s / 9.0;
                Console.WriteLine(del);
                return sum_1;
            }
             static int[,] NoSum(int[,] A, int[,] B, out double del)
            {
                int s = 0;
                int[,] Nosum_1 = new int[3, 3];
                for (int i = 0; i < Nosum_1.GetLength(0); i++)
                {
                    for (int j = 0; j < Nosum_1.GetLength(1); j++)
                    {
                        Nosum_1[i, j] = A[i, j] - B[i, j];
                        Console.Write(" " + Nosum_1[i, j]);
                        s += Nosum_1[i, j];
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                del = s / 9.0;
                Console.WriteLine(del);
                return Nosum_1;
            }
        }
    }
}
