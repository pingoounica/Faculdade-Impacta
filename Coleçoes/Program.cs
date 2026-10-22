using System.Collections;

ArrayList lista = new ArrayList();
lista.Add("São Paulo");
lista.Add("Rio de Janeiro");
lista.Add("Santos");

string cidade = Convert.ToString(lista[1]);

foreach (string cidades in lista)
{
    Console.WriteLine(cidades);
}

lista.Remove("Santos");
lista.Insert(0, "Londres");
Console.WriteLine("---------");

foreach (string cidades in lista)
{
    Console.WriteLine(cidades);
}

int tamanho = lista.Count;
Console.WriteLine($"Tamanho da coleçao: {tamanho}");

List<string> city = new List<string>();
city.Add("São Paulo");
city.Add("Rio de Janeiro");
// city.Add(10);

List<int> numeros = new List<int>();
numeros.Add(10);
numeros.Add(3);

foreach (string c in city)
{
    Console.WriteLine(c);
}

foreach (int n in numeros)
{
    Console.WriteLine(n);

}

// fila FIFO first in first out
Queue<string> fila = new Queue<string>();
fila.Enqueue("Processo 1");
fila.Enqueue("Processo 2");
fila.Enqueue("Processo 3");

while (fila.Count > 0)
{
    string item = fila.Dequeue();
    Console.WriteLine(item);
}

fila.Dequeue();

//Pilha - stack FILO first in last out
Stack<string> pilha = new Stack<string>();
pilha.Push("Processo 1");
pilha.Push("Processo 2");
pilha.Push("Processo 3");

while (pilha.Count > 0)
{
    string item = pilha.Pop();
    Console.WriteLine(item);
}

// Dicionario
Dictionary<string, string> dados = new Dictionary<string, string>();
dados.Add("Nome", "José da Silva");
dados.Add("RG", "23.234.1234");
dados.Add("Telefone", "(11) 5555-2323");

Console.WriteLine(dados["Nome"]);
Console.WriteLine(dados["RG"]);
Console.WriteLine(dados["Telefone"]);