// Definindo as variáveis:
int number1, number2, number3;

// Solicitando os números e verificando se a entrada é um inteiro:
Console.WriteLine("Encontre o maior dentre 3 números: ");

Console.Write("\nInforme o primeiro número: ");
if(!int.TryParse(Console.ReadLine(), out number1)) {
    Console.WriteLine("Resposta inválida. Digite um número inteiro.");
    return;
}

Console.Write("\nInforme o segundo número: ");
if(!int.TryParse(Console.ReadLine(), out number2)) {
    Console.WriteLine("Resposta inválida. Digite um número inteiro.");
    return;
}

Console.Write("\nInforme o terceiro número: ");
if(!int.TryParse(Console.ReadLine(), out number3)) {
    Console.WriteLine("Resposta inválida. Digite um número inteiro.");
    return;
}

// Encontrando o maior número e informando qual é o maior número::
int largestNumber = number1;    // Considerando que o primeiro número seja o maior.

Console.Clear();
Console.WriteLine("Encontre o maior dentre 3 números: ");

if(largestNumber == 0) {
    Console.WriteLine($"\nPrimeiro número: {number1}");
    Console.WriteLine($"Segundo número: {number2}");
    Console.WriteLine($"Terceiro número: {number3}\n");
    Console.WriteLine($"Não houve maior número. Todos foram iguais a 0");    
}

if(largestNumber == number1) {
    Console.WriteLine($"\nPrimeiro número: {number1}");
    Console.WriteLine($"Segundo número: {number2}");
    Console.WriteLine($"Terceiro número: {number3}\n");
    Console.WriteLine($"O primeiro número: {largestNumber} é o maior");
}

if(number2 > largestNumber && number2 > number3) {
    largestNumber = number2;

    Console.WriteLine($"\nPrimeiro número: {number1}");
    Console.WriteLine($"Segundo número: {number2}");
    Console.WriteLine($"Terceiro número: {number3}\n");
    Console.WriteLine($"O segundo número: {largestNumber} é o maior");
} 

if(number3 > largestNumber && number3 > number2) {
    largestNumber = number3;

    Console.WriteLine($"\nPrimeiro número: {number1}");
    Console.WriteLine($"Segundo número: {number2}");
    Console.WriteLine($"Terceiro número: {number3}\n");
    Console.WriteLine($"O terceiro número: {largestNumber} é o maior");
} 





 







