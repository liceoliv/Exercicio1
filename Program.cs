using System;
using System.Globalization;

namespace Exercicio1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            int codigo = 2732;

            double preco1 = 2100.0;
            double preco2 = 600.85;
            double medida = 64.738292;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R${preco1}.");
            Console.WriteLine($"{produto2}, cujo preço é R${preco2}.\n");

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine(); //chama teclado
            Console.WriteLine("Sua idade: ");
            object idade = Console.ReadLine();
            Console.WriteLine("Seu genero: ");
            string genero = Console.ReadLine();
            Console.WriteLine($"Registro: {nome}, {idade} anos de idade, código {codigo} e genero: {genero}\n");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondando (3 casas decimais): {medida:F3}");
            Console.WriteLine($"Sepadador decimal: {medida.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}