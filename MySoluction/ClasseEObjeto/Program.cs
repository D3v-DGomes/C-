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
// Person person = new("João", 32, "masculino");
// Console.WriteLine(person.Name);
// Console.WriteLine(person.Age);
// Console.WriteLine(person.Sex);

// public class Person {
//     public Person(string name) => Name = name;

//     public Person(string name, int age, string sex):this(name) {
//         Age = age;
//         Sex = sex;
//     }

//     public string? Name;
//     public int Age;
//     public string Sex;
// }

// Uso do THIS

// 1- Diferenciando parâmetros dos métodos dos campos:
// using System.Security.Cryptography.X509Certificates;

// public class Cliente {
//     public string? Nome;
//     public int Idade;

//     public Cliente(string? Nome, int Idade) {
//         this.Nome = Nome;
//         this.Idade = Idade;
//     }
// }

// 2- Passar um objeto da instância atual como parâmetro para outros métodos:
// Teste t1 = new Teste();
// t1.Num1 = 10;
// t1.Num2 = 22;
// t1.Exibir();

// Teste t2 = new();
// t2.Num1 = 33;
// t2.Num2 = 88;
// t2.Exibir();


// public class Teste {
//     public int Num1;
//     public int Num2;

//     public void PassarParametros(Teste t) {
//         Console.WriteLine($"this = {this}");
//         Console.WriteLine("Num1: " + t.Num1);
//         Console.WriteLine("Num2: " + t.Num2);
//     }

//     public void Exibir() {
//         // passando this como um parâmetro (a classe Teste)
//         PassarParametros(this);
//     }
// }

// 3- Invocar outro construtor da mesma classe:
// Teste t1 = new(999);
// public class Teste {
//     public Teste(int num1, int num2) {
//         Console.WriteLine($"\nConstrutor com dois parâmetros {num1} e {num2}");
//     }

//     public Teste(int num) : this(777, 888) {
//         Console.WriteLine("\nConstrutor com um parâmetro " + num);
//     }
// }







