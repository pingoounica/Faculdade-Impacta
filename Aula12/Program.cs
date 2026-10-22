// enviroment
string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
string arquivo = "teste.txt";
string path = Path.Combine(pasta, arquivo);

// escrevendo o arquivo
StreamWriter writer = new StreamWriter(path);
writer.WriteLine("Escrevendo no arquivo de texto.");
writer.WriteLine("Outra linha.");
writer.Close();

// ler arquivo
StreamReader reader = new StreamReader(path);
while (!reader.EndOfStream)
{ 
    string linha = reader.ReadLine();
    Console.WriteLine(linha);
}
Console.ReadLine();
