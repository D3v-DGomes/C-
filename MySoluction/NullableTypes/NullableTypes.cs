// Saída de dados: Formatação, Concatenação, Interpolação, Sequência de Escapes.
int idade = 25;
string nome = "Maria";

Console.WriteLine(nome);
Console.WriteLine(idade);

// Concatenação com operador +
Console.WriteLine(nome + " tem " + idade + " anos.");

// Interpolação de strings : $ -> {}
Console.WriteLine($"{nome} tem {idade} anos.");

// Placeholders: usa {} com numeração com inicio em zero
Console.WriteLine("{0} tem {1} anos.", nome, idade);

/*
Sequência de Escapes:

\’– Produzir uma aspa simples
\”– Produzir uma aspa dupla
\– Produzir uma barra invertida
\n– Insira uma nova linha
\r– Insira um retorno de carro
\t– Inserir uma aba
\0– Insira um caractere nulo
\b– Insira um backspace

*/