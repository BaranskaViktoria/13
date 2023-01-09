using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть пошту");
            string email = Console.ReadLine();
            //розділяє рядок на декілька
            var input = email.Split('@');
            string username = input[0];
            string domain = input[1];

            string newEmail = null;
            for (int i = 0; i < username.Length; i++)
            {
                newEmail += "*";
            }
            newEmail = newEmail + '@' + domain;
            Console.WriteLine(newEmail);
            Console.WriteLine("Введiть текст про користувача пошти");
            string text = Console.ReadLine();
            //Повертає новий рядок, у якому всі входження зазначеного символу Unicode або String у поточному рядку замінено іншим.
            text = text.Replace(email, newEmail);
            Console.WriteLine("\n" + text);
        }
    }
}