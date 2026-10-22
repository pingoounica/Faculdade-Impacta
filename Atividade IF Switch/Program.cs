class Program
{
    static void Main(string[] args)
    {
        //pagamento a ser feito
        //comprou algo 
        //se compra maior que 1000 -> pode parcelar em 3x
        //dar as opçoes de compra

        Console.WriteLine("Digite o valor da compra: "); 
        decimal compra = Convert.ToDecimal(Console.ReadLine());
        int parcelas = 3;
        
        if (compra > 1000)
        {
            Console.WriteLine($"Você pode parcelar em {parcelas}x");
            decimal valorAtual = compra / parcelas;
            Console.WriteLine($"Valor parcelado é de {valorAtual:c}");
        }
        else
        {
            Console.WriteLine("Opção de pagamento: A Vista");
            Console.WriteLine($"Valor a vista é de {compra:c}");
        }
    }
}