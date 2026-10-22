// criando um objeto da classe calculos 
// ou criando instancia

using Classes;

Calculos calc = new Calculos();
int total = calc.Somar(1, 5);
int resto = calc.Somar(10, 3);

Produto prod = new Produto();
prod.Nome = "Mouse";
prod.Preco = -10;

Console.WriteLine($"Nome: {prod.Nome}");
Console.WriteLine($"Preco: {prod.Preco:c}");


Console.WriteLine($"Total: {total}");
Console.WriteLine($"Resto: {resto}");