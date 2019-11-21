using System;

namespace Laba_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 1;
            int[,] nums = new int[7,7];
            Random rand = new Random();
            for(int i=0;i < nums.GetLength(0) ;i++)
            {
                for(int j=0;j < nums.GetLength(1);j++)
                {
                    nums[i, j] = rand.Next(100);
                    if (limit > nums.GetLength(0))
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 2}  ", nums[i, j]);
                    

                }
            }
            Console.Write("\n\n");
            
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                { 
                    if (limit > nums.GetLength(0))
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 2}  ", nums[6-j, i]);

                }
            }



        }
    }
}
