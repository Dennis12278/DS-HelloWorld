using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine($"Seu nome tem {nome.Length} caracteres");

            Console.WriteLine("Digite a data do seu nascimento");
            
            DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

            int qtdDiasVividos = DateTime.Now.Subtract(dtNascimento).Days;

            Console.WriteLine("Dias Vividos: " + qtdDiasVividos);

            Console.ReadKey();
        }
    }
}