namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            int dias = idade * 365;
            Console.WriteLine("Seu nome é {0} e você viveu {1} dias.", nome, dias);
        }
    }
}