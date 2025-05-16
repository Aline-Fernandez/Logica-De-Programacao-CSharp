using System.Globalization;
Console.WriteLine("Digite o raio do círculo: ");
double raio = double.Parse(Console.ReadLine());
double area = 3.14159 * raio * raio;

Console.WriteLine("Area:" + area.ToString("F4", CultureInfo.InvariantCulture));