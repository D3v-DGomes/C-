/*
- Escreva um programa para calcular a raiz da equação quadrática : ax^2 + bx + c
- Para calcular as raízes use a fórmula de Báskara: x = (-b +/- Vdelta)/2.a ; onde delta = b^2 - 4.a.c 
- Considere a, b e c números inteiros (positivos, negativos e o zero)
- Solicite a entrada de a , b e c e informe se existe ou não raiz real
*/

int a, b, c;
double d, x1, x2;
// Solicitando e verificando se os valores informados são números inteiros:
Console.Write("Equação do Segundo Grau:\n");

Console.Write("Informe o valor de a:\t");
if(!int.TryParse(Console.ReadLine(), out a)) {
    Console.WriteLine("Valor para A é inválido. Informe um número inteiro.");
    return;
}

Console.Write("Informe o valor de b:\t");
if(!int.TryParse(Console.ReadLine(), out b)) {
    Console.WriteLine("Valor para B inválido. Informe um número inteiro.");
    return;
}

Console.Write("Informe o valor de c:\t");
if(!int.TryParse(Console.ReadLine(), out c)) {
    Console.WriteLine("Valor para C é inválido. Informe um número inteiro.");
    return;
}

// Definindo a fórmula de Báskara:
d = (b * b) - 4 * a * c;

// Verificando o valor de Delta e realizando os cálculos:
if(d == 0) {
    Console.Write("As duas raízes são iguais.\n");

    x1 = -b / (2 * a);
    x2 = x1;

    Console.Write($"Primeira raiz x1 = {x1}\n");
    Console.Write($"Segunda raiz x2 = {x2}\n");
} else if(d > 0) {
    Console.Write("Ambas as raízes são reais e diferentes.\n");
    x1 = (-b + Math.Sqrt(d)) / (2 * a);
    x2 = (-b - Math.Sqrt(d)) / (2 * a);

    Console.Write($"Primeira raiz x1 = {x1}\n");
    Console.Write($"Segunda raiz x2 = {x2}\n");
} else {
    Console.Write("As raízes são imaginárias;\n Não há solução para os números rais.\n");
}






