using System;

namespace Salário_Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chama o método para solicitar os dados do funcionário
            SolicitarDadosFuncionario();
        }

        static void SolicitarDadosFuncionario()
        {
            // Solicita o nome e o salário do funcionário
            Console.Write("Digite seu nome: ");
            string? nome = Console.ReadLine();
            Console.Write("Digite o seu Salário: ");
            string? salario = Console.ReadLine();
            
            // Exibe os dados informados
            Console.WriteLine($"O funcionário {nome}, tem um salário de R${salario} em Junho.");
        }
    }
}