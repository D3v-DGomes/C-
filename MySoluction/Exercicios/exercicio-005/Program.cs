/*
3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop
while, do-while e for.
*/

// Usando While:
using System.Runtime.InteropServices;

int count = 1;
int secondCount = 1;
int somaWhile = 0;
int somaFor = 0;
int somaDoWhile = 0;


Console.WriteLine("UTILIZANDO WHILE:\n");
Console.WriteLine("\nOs 10 primeiros números naturais são:");

while(count <= 10) {
    Console.Write($"{count} ");
    somaWhile += count;
    count++;
}
Console.WriteLine($"\n\nA soma dos 10 números é igual a {somaWhile}");
Console.WriteLine("Loop While encerrado.\n");

// --------------------------------------------------------------------------------

// Usando For:
Console.WriteLine("UTILIZANDO FOR:");
Console.WriteLine("\nOs 10 primeiros números naturais são:");

for(int i = 1; i <= 10; i++) {
    Console.Write($"{i} ");
    somaFor+= i;

}

Console.WriteLine($"\n\nA soma dos 10 números é igual a {somaFor}");
Console.WriteLine("Loop For encerrado.\n");

// --------------------------------------------------------------------------------

// Usando do-While:
Console.WriteLine("UTILIZANDO DO-WHILE:");
Console.WriteLine("\nOs 10 primeiros números naturais são:");

do {
    Console.Write($"{secondCount} ");
    somaDoWhile += secondCount;
    secondCount++;
} while(secondCount <= 10);

Console.WriteLine($"\n\nA soma dos 10 números é igual a {somaDoWhile}");
Console.WriteLine("Loop do-While encerrado. \n");
