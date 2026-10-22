class Program
{
    static void Main(string[] args)
    {
        // Arrays
        // preenchendo array
        int[] numeros = new int[] {10, 5, 52, 17, 6, 10};

        // percorrendo array
        foreach(int numero in numeros)
        {
            Console.WriteLine(numero);
        }
        Console.WriteLine("------");
       
        // ordenar
        Array.Sort(numeros);

        //ordenar de tras pra frente
        // Array.Reverse(numeros);
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        // pesquisar
        int indice = Array.IndexOf(numeros, 6);
        if (indice == -1)
        {
            Console.WriteLine("17 não encontrado");
        }
        else
        {
            Console.WriteLine($"Encontrado {numeros[indice]} na posiçao {indice}");
        }
        // tamanho
        int tamanho = numeros.Length;
        Console.WriteLine($"Tamanho: {tamanho}");

        string[] arquivos = Directory.GetFiles(@"C:\windows\web", "*.*", SearchOption.AllDirectories);
        foreach (string arquivo in arquivos)
        {
            Console.WriteLine(arquivo);
        }
    }
}