/*
Crie um programa que receba via teclado o nome de cinco alunos e armazene os nomes em um array chamado names,
e, a seguir receba também via teclado a nota, como um double, dos cinco alunos e armazene os valores em um 
array chamado notes.

A seguir realize as seguintes operações:

1- Acessar e exibir no console os nomes dos alunos armazenados no array names;
2- Acessar e exibir no console as notas dos alunos armazenados no array notes;
3- Calcular a média aritmética das notas e exibir no console o valor obtido;
*/

using System.ComponentModel.DataAnnotations;

string?[] names = new string[5];
double[] notes = new double[5];

var sumOfGrades = 0.0;
var totalGrades = notes.Count();

for (int i = 0; i < 5; i++)
{
    Console.Write("Informe o nome do aluno: ");
    string? name = Console.ReadLine();
    names[i] = name;

    Console.Write($"Informe a nota do aluno {name}: ");
    double note = Convert.ToDouble(Console.ReadLine());
    notes[i] = note;
}

Console.WriteLine("Alunos:");
foreach (string? name in names)
{
    Console.Write($"{name} ");
}

Console.WriteLine("Notas:");
foreach (double note in notes)
{
    sumOfGrades += note;
    Console.Write($"{note}   ");
}

Console.WriteLine($"Média Aritmética: {sumOfGrades / totalGrades}");


