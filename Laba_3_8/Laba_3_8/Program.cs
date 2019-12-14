using System;

namespace Laba_3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк и столбцов:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] massive = new int[n, n];
            Random rand = new Random();
            Console.Write("Массив:");
            Console.WriteLine("\n\n");
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    massive[i, j] = rand.Next(10);
                    Console.Write("{0, 3} ", massive[i, j]);
                }
                Console.WriteLine();
                Console.Write(DetMassive(massive,n));
            }
            static int DetMassive(int[,] massive, int n)
            {
                int Det = 0;

                if (n == 2)
                {
                    Det = (massive[0, 0] * massive[1, 1]) - (massive[1, 0] * massive[0, 1]);
                    return Det;
                }
                else
                {
                    int i = 0;
                        for (int j = 0; j < n; j++)
                        {
                            if (i + j % 2 == 0)
                            {
                                Det += massive[i, j] * Minor(massive, i, j, n);
                            }
                            else
                            {
                                Det -= massive[i, j] * Minor(massive, i, j, n);
                            }
                        }
                }

                return Det;
            }

            static int Minor(int[,] array, int n, int m, int N)
            {
                int num = N - 1;
                int[,] arr_minor = new int[num, num];

                for (int i = 0, q = 0; q < num; i++, q++)
                {
                    for (int j = 0, p = 0; p < num; j++, p++)
                    {
                        if (i == n) i++;
                        if (j == m) j++;
                        arr_minor[q, p] = array[i, j];
                    }
                }
                return DetMassive(arr_minor, num);
            }
        }
    }
}
