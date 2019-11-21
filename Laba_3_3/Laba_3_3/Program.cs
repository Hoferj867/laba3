using System;

namespace Laba_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во циклических сдвигов: ");
            int k = Convert.ToInt32(Console.Read());
            Console.WriteLine();
            Console.Write("Введите длину массива: ");
            int m = Convert.ToInt32(Console.Read());
            int[] nums = new int[m];
            Console.WriteLine();
            Random rand = new Random();
            for (int i = 0; i < m; i++)
            {
                nums[i] = rand.Next(100);
                Console.Write ("{0, 2} ", nums[i]);
            }
            Console.Write("\n\n");
            if (k > nums.Length)
                k = k % 10;
            for (int i = k; i < nums.Length; i++)
            {
                Console.Write("{0, 2} ", nums[i]);
            }
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0, 2} ", nums[i]);
            }
            Console.ReadKey();
        }

    }

}
