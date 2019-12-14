using System;

namespace Laba_3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Матрица 9 на 9:");
            int[,] nums = new int[9, 9];
            int sum = 0;
            Random rand = new Random();
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = rand.Next(5);
                    Console.Write("{0,3} ", nums[i, j]);
                }
                Console.Write("\n\n");
            }
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {

                    if (i == j)
                    {
                        for (int k = 0; k < 9; k++)
                        {
                            if (k != i)
                            {
                                sum += nums[i, k];
                                nums[i, j] = sum;
                            }
                        }
                    }
                    Console.Write("{0,3}", nums[i, j]);
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
       

