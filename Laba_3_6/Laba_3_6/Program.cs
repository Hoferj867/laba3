using System;

namespace Laba_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            int polysum = 0;
            int min = int.MaxValue;
            int sum = 0;
            int polumin = 0;
            Random rand = new Random();
            for(int i=0;i<A.GetLength(0);i++)
            {
                A[i] = rand.Next(-10, 10);
                Console.Write("{0,2}",A[i]);
            }
            Console.WriteLine();
            Console.WriteLine("интерактив сумма:");
            Console.WriteLine(sumIterative(A));
            Console.WriteLine("рекурсивная сумма:");
            Console.WriteLine(sumRecursive(A,sum,polysum));
            Console.WriteLine("интерактивное мин значение:");
            Console.WriteLine(minIterative(A, min));
            Console.WriteLine("рекурсивная мин значение:");
            Console.WriteLine(minRecursive(A, polumin+1,min));
            static int sumIterative(int[]A)
            {
                int nums = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    nums += A[i];
                }
                return nums;
            }
                static int sumRecursive(int[] A, int sum, int polysum)
                {
                    if (polysum >= A.Length)
                    {
                        return sum;
                    }
                    else
                    {
                        sum += A[polysum];
                        polysum++;
                    }
                return sumRecursive(A, sum, polysum);
                }
            static int minIterative(int[] A,int min)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (min > A[i])
                    {
                        min = A[i];
                    }
                }
                return min;
            }
            static int minRecursive(int[] A, int polumin,int min)
            {

                if (polumin == A.Length - 1)
                    return min;
                else
                {
                    return Math.Min(A[polumin], minRecursive(A, polumin+1,min));
                }
            }
        }


        }
    }
