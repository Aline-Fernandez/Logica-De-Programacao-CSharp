using System.Globalization;
CultureInfo culturaBR = new CultureInfo("pt-BR");

int codigoPeça1 = 12;
int quantidadePeca1 = 2;
double valorUnitarioPeca1 = 5.30;

int codigoPeça2 = 16;
int quantidadePeca2 = 2;
double valorUnitarioPeca2 = 5.10;

double valorTotalPeca1 = quantidadePeca1 * valorUnitarioPeca1;
double valorTotalPeca2 = quantidadePeca2 + valorUnitarioPeca2;
double valorTotal = valorTotalPeca1 + valorTotalPeca2;

Console.WriteLine($"Código de peça 1: {codigoPeça1}");
Console.WriteLine($"Quantidade de peças 1: {quantidadePeca1}");
Console.WriteLine($"Valor unitário da peça 1: {valorUnitarioPeca1}");

Console.WriteLine($"Código da peça 2: {codigoPeça2}");
Console.WriteLine($"Quantidade de peças 2: {quantidadePeca2}");
Console.WriteLine($"Valor unitário da peça 2: {valorUnitarioPeca2}");

Console.WriteLine($"Valor total da peça 1: {valorTotalPeca1}");
Console.WriteLine($"Valor total da peça 2: {valorTotalPeca2}");
Console.WriteLine($"Valor total a pagar: {valorTotal.ToString("C2", culturaBR)}");