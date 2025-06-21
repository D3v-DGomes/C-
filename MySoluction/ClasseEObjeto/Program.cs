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


// MÉTODO COM RETORNO

// using System.Runtime.InteropServices;

// Calculadora calcular = new();

// var somar = calcular.Somar(10, 5);
// var subtrair = calcular.Subtrair(50, 43);
// var multiplicar = calcular.Multiplicar(5, 9);
// var dividir = calcular.Dividir(100, 20);

// Console.WriteLine($"{somar} - {subtrair} - {multiplicar} - {dividir}");

// public class Calculadora
// {
//     public int Somar(int a, int b)
//     {
//         return a + b;
//     }

//     public int Subtrair(int a, int b)
//     {
//         return a - b;
//     }

//     public int Multiplicar(int a, int b)
//     {
//         return a * b;
//     }

//     public int Dividir(int a, int b)
//     {
//         return a / b;
//     }
// }



// SOBRECARGA DE MÉTODOS (ASSINATURA DE UM MÉTODO)

// public class Calculadora
// {
//     // 1- Número de parâmetros diferentes
//     public int Soma(int n1, int n2)
//     {
//         return n1 + n2;
//     }

//     public int Soma(int n1, int n2, int n3)
//     {
//         return n1 + n2 + n3;
//     }

//     // 2- Tipos diferentes
//     public double Divisao(int n4, int n5)
//     {
//         return n4 / n5;
//     }

//     public decimal Divisao(decimal n4, decimal n5)
//     {
//         return n4 / n5;
//     }

//     // 3- Ordem dos parâmetros diferentes
//     public void Exibir(int a, string b)
//     {
//         Console.Write($"{a} {b}");
//     }

//     public void Exibir(string b, int a)
//     {
//         Console.Write($"{a} {b}");
//     }
// }


// PASSAGEM DE ARGUMENTOS POR VALOR E REFERÊNCIA

// Passagem por valor:
// using System.Formats.Asn1;

// int x = 20;
// Console.WriteLine("Valor do argumento x antes de passar o valor: " + x);

// Calculo calc = new();
// calc.Dobrar(x);

// Console.WriteLine("Valor do argumento x após passar por valor: " + x);

// Console.ReadKey();

// // Passagem por referência usando a palavra-chave ref:
// int z = 20;
// Console.WriteLine("\n\nValor do argumento x antes de passar o valor: " + z);

// CalculoRef calcRef = new();
// calcRef.DobrarZ(ref z);

// Console.WriteLine("Valor do argumento x após passar por valor: " + z);


// public class Calculo
// {
//     public void Dobrar(int y)
//     {
//         y *= 2;
//         Console.WriteLine("Valor do parâmetro y no método Dobrar() " + y);
//     }
// }

// public class CalculoRef
// {
//     public void DobrarZ(ref int y)
//     {
//         y *= 2;
//         Console.WriteLine("Valor do parâmetro y no método Dobrar() " + y);
//     }
// }

// Passagem por referência usando a palavra-chave out:
// Console.WriteLine("### Argumentos por referência usando out ###");

// Console.WriteLine("\n\nInforme o raio do círculo:");
// double raio = Convert.ToDouble(Console.ReadLine());

// Circulo circulo = new();
// double perimetro = circulo.CalculaAreaPerimetro(raio, out double area);

// Console.WriteLine("Perímetro do círculo: " + perimetro);
// Console.WriteLine("Área do círculo: " + area);
// public class Circulo
// {
//     public double CalculaAreaPerimetro(double raio, out double area)    // Retornando mais de um valor usando out
//     {
//         area = Math.PI * Math.Pow(raio, 2);
//         double perimetro = 2 * Math.PI * raio;
//         return perimetro;
//     }
// }


// Argumentos nomeados:
// Console.WriteLine("### Argumentos nomeados ###");

// Email email = new();
// email.EnviarEmail(destinatario: "teste@hotmail.com",
//                     mensagem: "Olá, este é um teste de envio de e-mail com argumentos nomeados.",
//                     assunto: "Teste de envio");

// email.EnviarEmail(mensagem: "Teste de ordem dos parâmetros",
//                     assunto: "Ordem aleatória",
//                     destinatario: "example@gmail.com");
// public class Email
// {
//     public void EnviarEmail(string destinatario, string assunto, string mensagem)
//     {
//         Console.WriteLine($"{destinatario}, {assunto}: {mensagem}");
//     }
// }


// Paramêtros opcionais:
// using System.ComponentModel.DataAnnotations;

// Console.WriteLine("### Parâmetros opcionais ###\n\n");

// Mensagem mensagem = new();
// mensagem.EnviarMensagem(remetente: "José Borges", destinatario: "João Estrela");

// mensagem.EnviarMensagem(remetente: "Marina Almeida", destinatario: "Amado Souza",
//     assunto: "Reunião de Projeto", mensagem: "Vamos discutir o andamento do projeto na próxima semana.");

// Console.Write("\n\nInforme o remetente(De): ");
// string? remetente = Console.ReadLine() ?? "Remetente Desconhecido";

// Console.Write("Informe o destinatário(Para): ");
// string? destinatario = Console.ReadLine() ?? "Destinatário Desconhecido";

// Console.Write("Informe o assunto: ");
// string? assunto = Console.ReadLine();

// Console.Write("Digite a mensagem: ");
// string? mensagemTexto = Console.ReadLine();

// mensagem.EnviarMensagem(remetente, destinatario, assunto, mensagemTexto);

// public class Mensagem
// {
//     public void EnviarMensagem(string remetente, string destinatario,
//     string assunto = "Assunto Desconhecido", string mensagem = "Mensagem sem conteúdo")
//     {
//         Console.WriteLine($"De: {remetente} - Para: {destinatario}");
//         Console.WriteLine($"Assunto: {assunto}");
//         Console.WriteLine($"Mensagem: {mensagem}");
//     }
// }


// Métodos estáticos:
// Console.WriteLine("### Métodos estáticos ###\n\n");

// Console.WriteLine($"Soma: {Calculadora.Soma(10, 10)}");
// Console.WriteLine($"Subtração: {Calculadora.Subtracao(10, 10)}");
// Console.WriteLine($"Multiplicação: {Calculadora.Multiplicacao(10, 10)}");
// Console.WriteLine($"Divisão: {Calculadora.Divisao(10, 10)}");
// Métodos estáticos são chamados diretamente pela classe, sem a necessidade de criar uma instância da classe.
// public class Calculadora
// {
//     public static int Soma(int n1, int n2)
//     {
//         return n1 + n2;
//     }
//     public static int Subtracao(int n1, int n2)
//     {
//         return n1 - n2;
//     }
//     public static int Multiplicacao(int n1, int n2)
//     {
//         return n1 * n2;
//     }
//     public static int Divisao(int n1, int n2)
//     {
//         return n1 / n2;
//     }
// }


// Membros estáticos:
Console.WriteLine("### Membros estáticos ###\n\n");

// Campos estáticos:
ContaCorrente conta1 = new();
conta1.Titular = "Angela";
conta1.NumeroConta = 032881;
conta1.TaxaJuros = 2.97f;

ContaCorrente conta2 = new();
conta2.Titular = "Bárbara";
conta2.NumeroConta = 033951;
conta2.TaxaJuros = 3.15f;

Console.WriteLine("## Conta Corrente ## \n");
Console.WriteLine($"Titular: {conta1.Titular}`- Juros Anual: {conta1.TaxaJurosAnual()}%");
Console.WriteLine($"Titular: {conta2.Titular}`- Juros Anual: {conta2.TaxaJurosAnual()}%\n\n");


ContaPoupanca contaPoupanca1 = new();
contaPoupanca1.Titular = "Carlos Magno";
contaPoupanca1.NumeroContaPoupanca = 004592;

ContaPoupanca contaPoupanca2 = new();
contaPoupanca2.Titular = "Diana Prince";
contaPoupanca2.NumeroContaPoupanca = 004495;

ContaPoupanca.TaxaJurosPoupanca = 2.04f;

Console.WriteLine("## Conta Poupança ## \n");
Console.WriteLine($"Titular: {contaPoupanca1.Titular} - Juros Anual: {contaPoupanca1.TaxaJurosPoupancaAnual()}%");
Console.WriteLine($"Titular: {contaPoupanca2.Titular} - Juros Anual: {contaPoupanca2.TaxaJurosPoupancaAnual()}%");
// Membros estáticos são compartilhados entre todas as instâncias da classe.


public class ContaCorrente
{
    public string? Titular;
    public int NumeroConta;
    public float TaxaJuros;

    public float TaxaJurosAnual()
    {
        return TaxaJuros * 12;
    }
}

public class ContaPoupanca
{
    public string? Titular;
    public int NumeroContaPoupanca;
    public static float TaxaJurosPoupanca;

    public float TaxaJurosPoupancaAnual()
    {
        return TaxaJurosPoupanca * 12;
    }
}

