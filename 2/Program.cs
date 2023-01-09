using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть рядок");
            string str = Console.ReadLine();

            //якщо рядок менше 20
            if (str.Length > 20)
            {
                str = str.Substring(0, 20);
            }
            //якщо рядок більше 20
            else if (str.Length < 20)
            {
                //заповненними пробілами
                str = str.PadRight(20, '*');
            }
            Console.WriteLine(str);
        }
    }
}