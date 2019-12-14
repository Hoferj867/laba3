using System;

namespace Laba_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n-ый член ряда: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonachi(n));
        }
        static int Fibonachi(int n )
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            return (Fibonachi(n - 1) + Fibonachi(n - 2));
        }
    }
}
