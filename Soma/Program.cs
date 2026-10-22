//classe
class Program
{
    // Metodo principal 
    static void Main(string[] args)
    {
        // Somar dois valores
        int n1, n2, resultado;

        // Obter primeiro valor
        Console.Write("Digite o número 1: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        // Obter segundo valor
        Console.Write("Digite o número 2: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        // Processar soma
        resultado = n1 + n2;

        // exibir resultado
        Console.WriteLine($"A soma de {n1} e {n2} é: {resultado}.", n1, n2, resultado);



    }
}



