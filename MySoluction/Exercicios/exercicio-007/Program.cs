/*
Declare e aloque memória para um array de strings chamado alunos com 2 linhas e 5 colunas e a seguir realize 
as seguintes operações:

- Inicializar o array com dados referentes aos nomes dos alunos recebidos via teclado
informando o índice da linha e coluna de cada elemento que está sendo recebido;

- Exibir no console os dados informados no array bem como o índice da linha e coluna de cada elemento;



Usar nomes dos alunos a seguir respeitando a ordem indicada:

- Maria, Paulo, Marta, Pedro, Carlos
- Silvia, Amanda, Manoel, Paula, Alicia
*/

string[,] arrayNames = new string[2, 5];

Console.WriteLine("Usar nomes dos alunos a seguir respeitando a ordem indicada:\n\n" +
                    "- Maria, Paulo, Marta, Pedro, Carlos\n" +
                    "- Silvia, Amanda, Manoel, Paula, Alicia\n");

for (int i = 0; i < arrayNames.GetLength(0); i++)
{
    for (int j = 0; j < arrayNames.GetLength(1); j++)
    {
        Console.WriteLine($"Informe o nome para o elemento na posição [{i}, {j}]");
        arrayNames[i, j] = Console.ReadLine().ToUpper();
    }
}

Console.WriteLine("\nConteúdo do array:\n");

for (int i = 0; i < arrayNames.GetLength(0); i++)
{
    for (int j = 0; j < arrayNames.GetLength(1); j++)
    {
        Console.WriteLine($"[{i},{j}] = {arrayNames[i, j]} \t");
    }
}

Console.ReadKey();