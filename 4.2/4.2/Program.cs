using System;

namespace Lab04_2program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string sent = Console.ReadLine();
            if (sent[sent.Length - 1] != '.')
            {
                if (sent[sent.Length - 1] != '"' && sent[sent.Length - 1] != '.')
                {
                    Console.WriteLine("В конце предложения нужна точка");
                    Program.Main(args);
                }
            }
            string copy = AddNumberWord(sent);
            Console.WriteLine(copy);
            string[] copyS = AddNumberWordStr(sent);
            foreach (string word in copyS)
            {
                Console.Write(word);
            }
            Console.ReadKey();
        }
        static string AddNumberWord(string sent)
        {
            string copySent = String.Empty;
            int meter = 0;

            for (int i = 0; i < sent.Length; i++)
            {
                if (sent[i] != ' ')
                {
                    if (sent[i] == ',')
                    {
                        meter++;
                        copySent += $"({meter})" + sent[i];
                        continue;
                    }
                    else if (sent[i] == '-')
                    {
                        copySent += sent[i];
                        continue;
                    }
                    else if (sent[i] == '.')
                    {
                        meter++;
                        copySent += $"({meter})" + sent[i];
                        continue;
                    }
                    else
                        copySent += sent[i];
                }
                else
                {
                    if (sent[i - 1] != ' ' && sent[i - 1] != '-' && sent[i - 1] != ',' && sent[i - 1] != '.')
                    {
                        meter++;
                        copySent += $"({meter})" + sent[i];
                        continue;
                    }
                    copySent += sent[i];
                }
            }
            return copySent;
        }
        static string[] AddNumberWordStr(string sentence)
        {
            int meter = 0;
            string[] copySent = sentence.Split(' ');

            for (int i = 0; i < copySent.Length; i++)
            {
                if (copySent[i] == "-")
                {
                    copySent[i] += " ";
                    continue;
                }
                else if (copySent[i].EndsWith(","))
                {
                    meter++;
                    copySent[i] = copySent[i].Replace(",", $"({meter}), ");
                    continue;
                }
                else if (copySent[i].EndsWith(".\""))
                {
                    meter++;
                    copySent[i] = copySent[i].Replace(".\"", $"({meter}).\"");
                    continue;
                }
                else if (copySent[i].EndsWith("."))
                {
                    meter++;
                    copySent[i] = copySent[i].Replace(".", $"({meter}). ");
                    continue;
                }
                else
                {
                    meter++;
                    copySent[i] += $"({meter}) ";
                }
            }
            return copySent;
        }
    }
}