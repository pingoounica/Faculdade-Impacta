using System;
namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pergunta o valor da compra
            Console.WriteLine("Digite o valor total da compra: ");

            // le o valor da compra
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            //pergunta quantos produtos foram comprados
            Console.WriteLine("Quantas unidade foram compradas ?");

            int quantidade = Convert.ToInt32(Console.ReadLine());

            // Faz a multiplicação
            decimal valorTotal = valor * quantidade;

            // Exibe o resultado
            Console.WriteLine($"O valor total da compra é {valorTotal:c}");
        }
    }
}