using System;

namespace Olá_Fulano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome? ");
            string? nome = Console.ReadLine();
            Console.WriteLine($"Olá {nome}, é um prazer te conhecer!");
        }
    }
}