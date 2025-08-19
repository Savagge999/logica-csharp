using System;
class Program
{
    static void Main(string[] args)
    {
        // Chamada do método para somar dois números
        SomarNumeros();
    }
    static void SomarNumeros()
    {
        // Solicita ao usuário dois números inteiros para realizar a soma
        Console.WriteLine("Soma de dois números inteiros");
        Console.Write("Digite o primeiro número: ");
        int numero1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int numero2 = Convert.ToInt16(Console.ReadLine());

        // Exibe o resultado da soma
        // Usando interpolação de strings para formatar a saída
        Console.WriteLine($"A soma entre {numero1} e {numero2} é {numero1 + numero2}.");

        // Outra forma de exibir o resultado é 
        // usando a concatenação de strings com o operador +
        Console.WriteLine("A soma entre " + numero1 + " e " + numero2 + " é " + (numero1 + numero2) + ".");
    }
}