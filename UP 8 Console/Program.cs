using System;
using System.Text.RegularExpressions;

namespace UP_8_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            while (true)
            {
                Console.Write("Введите строку -> ");
                s = Console.ReadLine();
                if (s.Length == 0)
                {
                    Console.WriteLine("Строка не может быть пустой!");
                    continue;
                }
                break;
            }
            Regex regex = new Regex(@"\b[А-Я]+\w*");
            MatchCollection matches = regex.Matches(s);
            Console.Write("Все слова с заглавной буквы: ");
            foreach (Match m in matches) Console.Write(m.Value + " ");
        }
    }
}
