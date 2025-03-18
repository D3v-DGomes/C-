// OPERADORES DE INCREMENTO E DECREMENTO
using System.Runtime.InteropServices;

int x = 0;
Console.WriteLine($"x = {x}");

// pós-incremento = primeiro resolve e depois incrementa
int resultado1 = x++ + 10;

Console.WriteLine($"pós-incremento ==> {resultado1}");
Console.WriteLine($"valor de x ==> {x} \n");

// pré-incremento = primeiro incrementa e depois resolve
int y = 0;
int resultado2 = ++y + 10;

Console.WriteLine($"pré-incremento ==> {resultado2}");
Console.WriteLine($"valor de y ==> {y} \n");

// -------------------------------------------------------------

Console.WriteLine($"x = {x}");

// pós-decremento = primeiro resolve e depois decrementa
int resultado3 = x-- - 10;

Console.WriteLine($"pós-decremento ==> {resultado3}");
Console.WriteLine($"valor de x ==> {x} \n");

// pré-decremento = primeiro decrementa
// e depois resolve

int resultado4 = --y - 10;

Console.WriteLine($"pré-decremento ==> {resultado4}");
Console.WriteLine($"valor de y ==> {y}");

