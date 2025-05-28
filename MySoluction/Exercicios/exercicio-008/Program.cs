/*
Dada uma classe Aluno definida com duas propriedades:

1- Nome do tipo string
2- Nota do tipo double

Crie uma lista de objetos do tipo Aluno usando a coleção List<T> com os seguintes dados
que representam o nome e a nota do aluno:

Maria, 8.75
Manoel, 6.95
Amanda, 7.25
Carlos, 6.55
Jaime, 8.50
Debora, 5.95
Alicia, 9.25
Sandra, 5.55
Marta, 7.85
Sueli, 9.15
*/

List<Aluno> alunos = FonteDados.GetAlunos();

ExibirAlunos(alunos);

static void ExibirAlunos(List<Aluno> alunos)
{
    double totalNotas = 0;

    Console.WriteLine("\nRelação de alunos:");
    Console.WriteLine("\nNome\tNota");

    foreach (var aluno in alunos)
    {
        Console.WriteLine($"{aluno.Nome}\t{aluno.Nota:N2}");
        totalNotas += aluno.Nota;
    }

    var mediaAritmetica = totalNotas / alunos.Count;

    Console.WriteLine("\nMédia Aritmética\tQtd de alunos");
    Console.WriteLine($"{mediaAritmetica:N2}\t\t\t{alunos.Count}");

    alunos.AddRange(new Aluno { Nome = "Bia", Nota = 7.75 }, new Aluno { Nome = "Mario", Nota = 0 });

    Console.WriteLine("\nRelação de alunos:");
    Console.WriteLine("\nNome\tNota");

    foreach (var aluno in alunos)
    {
        Console.WriteLine($"{aluno.Nome}\t{aluno.Nota:N2}");
    }

}


public class Aluno
{
    public string Nome { get; set; } = string.Empty;
    public double Nota { get; set; }
}

public class FonteDados
{
    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new()
        {
            new Aluno() {Nome = "Maria", Nota = 8.75},
            new Aluno() {Nome = "Manoel", Nota = 6.95},
            new Aluno() {Nome = "Amanda", Nota = 7.25},
            new Aluno() {Nome = "Carlos", Nota = 8.50},
            new Aluno() {Nome = "Jaime", Nota = 6.55},
            new Aluno() {Nome = "Debora", Nota = 5.95},
            new Aluno() {Nome = "Alicia", Nota = 9.25},
            new Aluno() {Nome = "Sandra", Nota = 5.55},
            new Aluno() {Nome = "Marta", Nota = 7.85},
            new Aluno() {Nome = "Sueli", Nota = 9.15},
        };

        return alunos;
    }
}
