using System.Globalization;
Console.WriteLine("Entre com seu nome completo: ");
string nome = Console.ReadLine();

Console.WriteLine("Quantos quartos tem em sua casa? ");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine("Entre com seu último sobrenome, idade e altura (mesma linha): ");
string[] vet = Console.ReadLine().Split(' ');
string Sobrenome = vet[0];
int idade = int.Parse(vet[1]);
double altura  = double.Parse(vet[2], CultureInfo.InvariantCulture);

Console.WriteLine("Você digitou: ");
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Número de quartos: " + quartos);
Console.WriteLine("Preço do produto: " + preco.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Último nome: " + Sobrenome);
Console.WriteLine("Idade: " + idade);
Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));