// HERANÇA:
// Console.WriteLine("## Herança ##\n\n");

// Funcionario funcionario = new();
// funcionario.Nome = "Jonas";
// funcionario.Email = "jonas@empresa.com";
// funcionario.Empresa = "Techno Corp";
// funcionario.Cargo = "Desenvolvedor";
// funcionario.Salario = 5000.00m;

// Aluno aluno = new();
// aluno.Nome = "Marta";
// aluno.Email = "marta231092@edu.com";
// aluno.Curso = "Engenharia de Software";
// aluno.Nota = 8;

// public class Pessoa
// {
//     public string? Nome { get; set; }
//     public string? Email { get; set; }
//     public void Identificar()
//     {
//         Console.WriteLine($"{Nome} - {Email}");
//     }
// }

// public class Aluno : Pessoa
// {
//     public string? Curso { get; set; }
//     public int Nota { get; set; }
// }

// public class Funcionario : Pessoa
// {
//     public string? Empresa { get; set; }
//     public string? Cargo { get; set; }
//     public decimal Salario { get; set; }
// }

// Comportamentos:
// using System.Reflection.Metadata.Ecma335;

// Console.WriteLine("## Herança - Comportamentos ##\n");

// public class ClasseDerivada : ClasseBase
// {
//     // Campos:
//     public void VerificarCampos()
//     {
//         Console.WriteLine("Acesso ao campo private: private_var usando uma propriedade GET");
//         int soma = public_var + protected_var + internal_var + Private_var;
//         Console.WriteLine($"Soma dos campos: {soma}");
//     }

//     // Membros:
//     public void VerificarAcesso()
//     {
//         Public_Membro(); // Acesso permitido
//         Protected_Membro(); // Acesso permitido
//         Internal_Membro(); // Acesso permitido
//         ProtectedInternal_Membro(); // Acesso permitido
//         // Private_Membro(); // Acesso negado - não é possível acessar membros privados da classe base
//     }
// }


// public class ClasseBase
// {
//     // Campos:
//     public int public_var = 1;
//     protected int protected_var = 2;
//     internal int internal_var = 3;
//     private int private_var = 4;

//     // Propriedade:
//     public int Private_var
//     {
//         get { return private_var; }
//         set {private_var = value;}
//     }

//     // Membros:
//     public void Public_Membro()
//     {
//         Console.WriteLine("ClasseBase - Método Public");
//     }
//     protected void Protected_Membro()
//     {
//         Console.WriteLine("ClasseBase - Método Protected");
//     }
//     internal void Internal_Membro()
//     {
//         Console.WriteLine("ClasseBase - Método Internal");
//     }
//     protected internal void ProtectedInternal_Membro()
//     {
//         Console.WriteLine("ClasseBase - Método protected internal");
//     }
//     private void Private_Membro()
//     {
//         Console.WriteLine("ClasseBase - Método Private");
//     }
// }


// Palavra-chave "base":
// Console.WriteLine("## Herança - Construtores (Palavra-chave base) ##\n");

// Aluno aluno1 = new(); // Chama o construtor da classe base
// Aluno aluno2 = new("João"); // Chama o Construtor da classe base com parâmetro
// class Pessoa
// {
//     public Pessoa()
//     {
//         Console.WriteLine("Construtor da Classe Base");
//     }

//     public Pessoa(string nome)
//     {
//         Console.WriteLine("Construtor da Classe Base com parâmetro.");
//     }
// }

// class Aluno : Pessoa
// {
//     public Aluno() : base() // Chama o construtor da classe base
//     {
//         Console.WriteLine("Construtor da Classe Derivada");
//     }

//     public Aluno(string nome) : base(nome)    // Chama o Construtor da classe base
//     {
//         Console.WriteLine("Construtor da Classe Derivada com parâmetro.");
//     }
// }

// Palavra-chave "new":
// Console.WriteLine("## Herança - Sobrescrita de Membros (Palavra-chave new) ##\n");

// ClasseDerivada classeDerivada = new();
// classeDerivada.ExibirMensagem(); // Chama o método da classe derivada

// class ClasseBase
// {
//     public virtual void ExibirMensagem()
//     {
//         Console.WriteLine("Mensagem da Classe Base");
//     }
// }

// class ClasseDerivada : ClasseBase
// {
//     public new void ExibirMensagem()    // Sobrescreve o método da classe base por causa da palavra-chave "new"
//     {
//         Console.WriteLine("Mensagem da Classe Derivada");
//     }
// }

// Palavra-chave "override":
Console.WriteLine("## Herança - Sobrescrita de Membros (Palavra-chave override) ##\n");

ClasseDerivadaOverride classeDerivadaOverride = new();
classeDerivadaOverride.ExibirMensagem(); // Chama o método da classe derivada

class ClasseBaseOverride
{
    public virtual void ExibirMensagem()
    {
        Console.WriteLine("Mensagem da Classe Base");
    }
}

class ClasseDerivadaOverride : ClasseBaseOverride
{
    public override void ExibirMensagem() // Sobrescreve o método da classe base por causa da palavra-chave "override"
    {
        Console.WriteLine("Mensagem da Classe Derivada");
    }
}