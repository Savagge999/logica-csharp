using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Média de Duas Notas;");

        // Solicita ao usuário que insira duas notas
        Console.Write("Qual a primeira nota: ");
        float nota1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Qual a segunda nota: ");
        float nota2 = Convert.ToSingle(Console.ReadLine());

        // Calcula a média das duas notas
        float media = (nota1 + nota2) / 2;

        // Exibe a média calculada
        Console.WriteLine($"A média entre {nota1} e {nota2} é {media}.");
    }
}