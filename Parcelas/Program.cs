using System;
using System.Numerics;
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

            // Pergunta em quantas parcelas
            Console.WriteLine("Quantas parcelas? ");
            int parcelas = Convert.ToInt32(Console.ReadLine());

            // exibe valor total de parcelas
            Console.WriteLine($"Total de parcelas: {parcelas}");

            // Faz o calculo
            decimal valorParcelado = valor / parcelas;

            //exibe valor total
            Console.WriteLine($"O valor total parcelado é: {valorParcelado:c}");
        }
    }
}