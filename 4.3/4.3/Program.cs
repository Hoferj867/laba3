using System;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            String text = Console.ReadLine();
            if (text.EndsWith("."))
            {
                //метод 1
                text = text.Remove(text.Length - 1);
                String[] wordsOriginal = text.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Array.Reverse(wordsOriginal);
                foreach (String word in wordsOriginal)
                    Console.Write(word + " ");
            }
            Console.WriteLine();
            //метод 2
            string[] words = new string[text.Length];
                char[] trigger = { ' ' };
                int counter = 0;
                for (int i = 0; i < text.Length; i = text.IndexOfAny(trigger, i) + 1)
                {
                    if (counter == 0)
                    {
                        text += " ";
                    }
                    for (int j = i; j != text.IndexOfAny(trigger, i) && j < text.Length; j++)
                    {
                        words[counter] += text[j];
                    }
                    counter++;
                }
                Array.Resize(ref words, counter);
                Array.Reverse(words);
                foreach (string word in words)
                {
                    Console.Write(word + " ");
                }
        }
    }
}
