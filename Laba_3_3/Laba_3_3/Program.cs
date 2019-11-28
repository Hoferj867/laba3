using System;

namespace Laba_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("матрица:");
            int[] nums= new int[5];
            Random rand = new Random();
            int n = 5;
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                nums[i]=rand.Next(10);
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Введите число сдивгов:");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k>5)
                k %= 5;
            for (int i = k; i < n; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", nums[i]);
            }

        }

    }

}
