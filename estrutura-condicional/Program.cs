﻿Console.WriteLine("Qual o hora atual?");
int hora = int.Parse(Console.ReadLine());

if (hora < 12){
    Console.WriteLine("Bom dia!");
}

else if (hora < 18){
    Console.WriteLine("Boa tarde!");
}

else {
    Console.WriteLine("Boa noite!");
}