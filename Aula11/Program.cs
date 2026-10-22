using Aula11;

var impostos = new Impostos(0.10m);
var impostos1 = new Impostos();

decimal valorIss = impostos.CalcularISS("SP", 500);
decimal valorIssIndividual = impostos.CalcularISS("SP", 500, true);

Console.WriteLine($"Valor do ISS em São Paulo: {valorIss:c}");
Console.WriteLine($"Valor do ISS em São Paulo para empresa individual: {valorIssIndividual:c}");
Console.ReadLine();