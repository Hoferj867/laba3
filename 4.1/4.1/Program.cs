using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите текст:");
            string Text = Console.ReadLine();
            //1 способ:
            if (Text.EndsWith("."))
            {
                for (int i = 0; i < Text.Length - 1; i++)
                {
                    if (Text.IndexOf(Text[i]) == Text.LastIndexOf(Text[i]))
                    {
                        Console.WriteLine(Text[i]);
                    }
                    else
                    {

                    }
                }
            }
            else

                Console.WriteLine("Ошибка");
            //2 способ:

            for (int i = 0; i < Text.Length-1 ; i++)
            {
                bool check = true;
                if (Text[i] != ' ')
                {
                    if (Text[i] != '.')
                    {
                        for (int q = 0; q < Text.Length - 1; q++)
                        {
                            if (Text[q] == Text[i] && Text[q] != ' ' && i != q)
                            {
                                check = false;
                                if (check)
                                {
                                    break;
                                }
                            }
                        }
                    }
                    
                }
                else
                continue;
                if (check)
                {
                    Console.Write($" {Text[i]} ");

                }
            }
        }
    }
}
