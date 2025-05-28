/*
1- Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize
as seguintes operações : 

Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora

a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
b- Exiba os nomes da segunda e da penúltima fruta no console
c- Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
d- Ordene a coleção de frutas na ordem ascendente
e- Exiba no console a coleção de nomes de frutas na ordem inversa
*/


string[] frutas = new string[]
{
    "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"
};

// Letra A: Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine($"Laço for - Fruta: {frutas[i]}   \tÍndice: {i}");
}

Console.WriteLine();

foreach (string fruta in frutas)
{
    Console.WriteLine($"Laço foreach - Fruta: {fruta}\tÍndice: {fruta.Length}");
}

Console.WriteLine();

// Letra B: Exiba os nomes da segunda e da penúltima fruta no console
Console.WriteLine($"Primeira fruta: {frutas[0]}");
Console.WriteLine($"Penúltima fruta: {frutas[frutas.Length - 2]}");

Console.WriteLine();

// Letra C: Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
Console.WriteLine("Substituindo a terceira e a última fruta:");
frutas[2] = "Kiwi";
frutas[frutas.Length - 1] = "Caqui";
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

Console.WriteLine();

// Letra D: Ordene a coleção de frutas na ordem ascendente
Console.WriteLine("Em ordem ascendente:");
Array.Sort(frutas);
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

Console.WriteLine();

// Letra E: Exiba no console a coleção de nomes de frutas na ordem inversa
Console.WriteLine("Array em ordem inversa:");
Array.Reverse(frutas);
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}