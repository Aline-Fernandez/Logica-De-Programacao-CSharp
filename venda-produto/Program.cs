using System;
using System.ComponentModel.Design;

double totalCompra = 0.0; //Acumulador de total da compra
bool continuarComprando = true;

while (continuarComprando)
{
    //Mostrar Menu
    Console.WriteLine("Escolha o item:");
    Console.WriteLine("1 - Cachorro quente | R$ 14,00");
    Console.WriteLine("2 - X-Salada | R$ 18,00");
    Console.WriteLine("3 - X-Bacon | R$ 25,00");
    Console.WriteLine("4 - Torrada simples | R$ 2,00");
    Console.WriteLine("5 - Refrigerante | R$ 5,00");

    //Ler código com válidação
    int codigo;
    while (true)
    {
        Console.WriteLine("Digite o código do item: ");
        if (int.TryParse(Console.ReadLine(), out codigo) && (codigo >= 1 && codigo <= 5))
        {
            break; // Código válido
        }
        else
        { 
           Console.WriteLine("Código inválido. Digite um número entre 1 e 5."); 
        }
    }

    //Ler quantidade do item escolhido
    Console.Write("Digite a quantidade do item: ");
    int quantidade = int.Parse(Console.ReadLine());

    //Definindo o preço do item
    double preco = codigo switch
    {
        1 => 15.00,
        2 => 18.00,
        3 => 10.00,
        4 => 8.00,
        5 => 4.00,
        _ => 0.00 // nunca será atingido, mas necessário
    };

    //Calcular o subTotal
    double subTotal = preco * quantidade;
    totalCompra += subTotal;

    //Exibir o valor total do item
    Console.WriteLine($"Subtotal: R$ {subTotal:F2}");

    // Perguntar se o usuário deseja continuar
    Console.Write("Deseja continuar comprando? (s/n): ");
    string resposta = Console.ReadLine().ToLower();
    if (resposta == "n")
    {
  
       continuarComprando = false; // Sai do loop
    }
}
    Console.WriteLine($"\nO total a pagar é: R$ {totalCompra:F2}");


