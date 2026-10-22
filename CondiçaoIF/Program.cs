namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora = DateTime.Now.Hour;
            if (hora > 17)
            {
                Console.WriteLine("Boa Noite");
            }
            else if (hora > 11)
            {
                Console.WriteLine("Boa Tarde");
            }
            else 
            {
                Console.WriteLine("Bom Dia");
            }
        }
    }
}
    
