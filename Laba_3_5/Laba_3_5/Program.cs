using System;

namespace Laba_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[,] A = new int[5, 5];
                int[,] B = new int[5, 5];
                Random rand = new Random();
                Console.Write("Массив А:");
                Console.WriteLine("\n\n");
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        A[i, j] = rand.Next(10);
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
                        B[i, j] = rand.Next(10);

                        Console.Write("{0, 2}  ", B[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n\n");
                int[,] output = Product1(A,B);
                for (int i = 0; i < output.GetLength(0); i++)
                {
                    for (int j = 0; j < output.GetLength(1); j++)
                    {
                        Console.Write("{0, 3}  ", output[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            static int[,] Product1(int[,] A, int[,] B)
            {
                int[,] product = new int[5, 5];
                for (int i = 0; i < product.GetLength(0); i++)
                {
                    for (int j = 0; j < product.GetLength(0); j++)
                    {
                        product[i, j] = 0;
                        for (int k = 0; k < product.GetLength(0); k++)
                        {
                            product[i, j] += A[i, k] * B[k, j];
                        }
                        
                    }
                }
                Console.WriteLine();
                return product;
            }
        }
    }
}