class Program
{
    static void Main(string[] args)
    {
        int tabuada;
        Console.WriteLine("Qual a tabuada desejada? ");
        tabuada = Convert.ToInt32(Console.ReadLine());
        string valor = string.Empty;
        do
        {
            if (valor != string.Empty)
            {
                tabuada = Convert.ToInt32(valor);
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{tabuada} X {i} = {i * tabuada}");
            }
            Console.WriteLine("Digite outra tabuada ou enter para sair");
            valor = Console.ReadLine();
        
        } while (valor != string.Empty);

    }
}