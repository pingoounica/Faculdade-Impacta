class Program
{
    static void Main(string[] args)
    {        
      for (int i = 10; i <= 10; i++)
        {
            Console.WriteLine(i);
            Console.ReadLine();
        }

        string senha = "123";
        string senhaInformada = string.Empty;

        while (senha != senhaInformada)
        {
            Console.WriteLine("Digite a senha: ");
            senhaInformada = Console.ReadLine();
        }
    }
}