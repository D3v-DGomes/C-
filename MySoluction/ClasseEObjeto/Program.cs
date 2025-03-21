// using System.Data;

// Pessoa p1 = new Pessoa();
// p1.nome = "David";
// p1.idade = 24;
// p1.sexo = "masculino";

// Pessoa p2 = new Pessoa();
// p2.nome = "Kevin";
// p2.idade = 25;
// p2.sexo = "masculino";

// Console.WriteLine($"{p2.nome} e {p1.nome}");

// class Pessoa {
//     public string? nome;
//     public int idade;
//     public string? sexo;
// }

// Sintaxe mínima para criar métodos
/*
Tipo de retorno -> determina o tipo de valor que o método retorna. Se o método não retornar nenhum valor o tipo usado é void

Nome -> Define o nome do método (Pascal Case)

Lista de parâmetros -> Indica o tipo de dados e o valor das variáveis ou objetos que o método pode receber entre parênteses.

Corpo do método -> Consiste das instruções definidas entre chaves no corpo do método.
*/


// objeto:
// MinhaClasse minhaClasse = new MinhaClasse();

// minhaClasse.Saudacao();
// minhaClasse.ExibirDataAtual();


// // método:
// class MinhaClasse {
//     public void Saudacao() {
//         Console.WriteLine("Bem-vindo!");
//     }

//     public void ExibirDataAtual() {
//         Console.WriteLine(DateTime.Now.ToShortTimeString());
//     }
// }





// var aluno = new Aluno();

// Console.WriteLine("Nome : ");
// aluno.Nome = Console.ReadLine();
// Console.WriteLine("Idade : ");
// aluno.Idade = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Sexo : ");
// aluno.Sexo = Console.ReadLine();
// Console.WriteLine("Aprovado (S)im : (N)ão");
// aluno.Aprovado = Console.ReadLine();

// Curso curso = new();
// curso.Resultado(aluno);

// public class Aluno {
//     public string? Nome;
//     public int Idade;
//     public string? Sexo;
//     public string? Aprovado;
// }


// public class Curso {
//     public void Resultado(Aluno aluno){
//         Console.WriteLine($"\nO aluno {aluno.Nome}, sexo {aluno.Sexo} com {aluno.Idade} anos.");
//         if(aluno.Aprovado == "S") {
//             Console.WriteLine("\nFoi Aprovado.");
//         } else {
//             Console.WriteLine($"\n foi Reprovado.");
//         }
//     }

// }




// CONSTRUTOR PADRÃO
//  public class Aluno2 {      // class com construtor automático
//     public string? Name;
//     public int Age;
//     public string? Sex;
//  }

// CONSTRUTOR PADRÃO COM PARÂMETROS

// Homem homem = new Homem("Jorge", 29, "masculino");

// public class Homem {
//     public Homem(string name, int age, string sex){
//         Name = name;
//         Age = age;
//         Sex = sex;
//     }

//     public string Name;
//     public int Age;
//     public string Sex;
// }

// CHAMANDO UM CONSTRUTOR DENTRO DE OUTRO
Person person = new("João", 32, "masculino");
Console.WriteLine(person.Name);
Console.WriteLine(person.Age);
Console.WriteLine(person.Sex);

public class Person {
    public Person(string name) => Name = name;

    public Person(string name, int age, string sex):this(name) {
        Age = age;
        Sex = sex;
    }

    public string? Name;
    public int Age;
    public string Sex;
}