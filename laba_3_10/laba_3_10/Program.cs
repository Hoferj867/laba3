using System;

namespace laba_3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            int max = 0;
            int i = 0;
            Random rand = new Random();
            for ( i = 0; i < A.GetLength(0); i++)
            {
                A[i] = rand.Next(-10, 10);
                Console.Write("{0,2}", A[i]);
            }
            Console.WriteLine();
            Console.WriteLine(maxRevers(A, i, max));
            static int maxRevers(int[] A, int i, int max)
            {
                for (i = 1; i < A.Length; i+=2)
                {
                        if(max < A[i] && A[i]%2!=0)
                        {
                            max = A[i];
                        }
  

                }
                return max;
            }
        }            
    }
}
