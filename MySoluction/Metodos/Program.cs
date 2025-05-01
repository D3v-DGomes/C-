// // MÉTODOS COM RETORNO:
// Calculator calc = new();


// var value = calc.Sum(10, 10);
// Console.WriteLine(value);
// Console.WriteLine(calc.Sum(10, 15));


// public class Calculator {
//     public int Sum(int n1, int n2) {
//         return n1 + n2;
//     }

//     public int Sub(int n1, int n2) {
//         return n1 - n2;
//     }

//     public int Mult(int n1, int n2) {
//         return n1  * n2;
//     }

//     public int Div(int n1, int n2) {
//         return n1 / n2;
//     }
// }

// ASSINATURA DE UM MÉTODO:
/*
É formada por:

- Nome do método;
- Número de parâmetros;
- Tipo dos parâmetros;
- Ordem dos parâmetros;

OBS.: o tipo de retorno do método não faz parte da assinatura. E também não é possível 
ter dois métodos com a mesma assinatura.
*/
// public class NewCalculator {
//     public int Sum(int n1, int n2) {
//         return n1 + n2;
//     }

//     public int Sum(int n1, int n2, int n3) {
//         return n1 + n2 + n3;
//     }

//     public double Sum(double d1, double d2) {
//         return d1 + d2;
//     }

//     public double Sum(int n1, double d2) {
//         return n1 + d2;
//     }
// }

/*
No exemplo acima, cada método possui a sua assinatura, seja mudando a quantidade de parâmetros, 
seja mudando o tipo de dados. 

Consequentemente, há uma SOBRECARGA DE MÉTODOS na classe NewCalculator. Uma sobrecarga de métodos
se dá quando:
- Temos métodos com o mesmo nome, mas com parâmetros diferentes;
- Temos métodos com o mesmo nome, mas com tipos de dados diferentes;
- Temos métodos com o mesmo nome, mas com a ordem dos parâmetros diferentes;

Como no exemplo a seguir:
*/
Email email = new();
email.Send("enterprise.com.br");
email.Send("enterprise.com.br", "Commercial proposal");
email.Send("enterprise.com.br", 2000);
email.Send(2000, "enterprise.com.br");


public class Email {
    public void Send(string address) {
        Console.WriteLine(address);
        Console.WriteLine("Default subject.");
    }

    public void Send(string address, string subject) {
        Console.WriteLine(address);
        Console.WriteLine(subject);
    }

    public void Send(string address, decimal value) {
        Console.WriteLine(address);
        Console.WriteLine("Commercial proposal");
        Console.WriteLine(value);
    }

    public void Send(decimal value, string address) {
        Console.WriteLine(address);
        Console.WriteLine("Supplier payment");
        Console.WriteLine(value);
    }
}

