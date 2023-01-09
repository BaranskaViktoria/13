using System;
namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть силку");
            string url = Console.ReadLine();
            //розділяє рядок на 3 рядки
            var input = url.Split('/', '/', ' ');
            string protocol = input[0];
            string server = input[2];
            string resource = input[3];

            Console.WriteLine("[protocol ] = [" + protocol + " ]");
            Console.WriteLine("[server] = [ " + server + " ]");
            Console.WriteLine("[resource ]= [" + resource + " ]");
        }
    }
}