using System.Globalization;

Console.WriteLine("Entre com seu nome completo:");
string nomeCompleto = Console.ReadLine();
Console.WriteLine("\nQuantos quartos tem na sua casa?");
int numertoQuartos = int.Parse(Console.ReadLine());
Console.WriteLine("\nEntre com o preço do produto:");
double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("\nEntre com seu último nome, idade e altura");

string[] dados = Console.ReadLine().Split(' ');
string ultimoNome = dados[0];
int idade = int.Parse(dados[1]);
double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

Console.WriteLine("\n\nDados digitados:");
Console.WriteLine(nomeCompleto);
Console.WriteLine(numertoQuartos);
Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));