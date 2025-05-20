int a, b;

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine("Numero multiplo");
}
else if (b % a == 0)
{
    Console.WriteLine("Numero multiplo");
}
else
{
    Console.WriteLine("Numero não é multiplo");
}