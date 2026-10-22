class Program
{
    static void Main(string[] args)
    {
        int tabuada;
        Console.WriteLine("Qual a tabuada desejada? ");
        tabuada = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{tabuada} X {i} = {i * tabuada}");
        }
        
    }
}