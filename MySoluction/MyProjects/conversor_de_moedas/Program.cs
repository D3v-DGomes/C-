using System.Globalization;
using System.IO.Pipelines;
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Informe o valor a ser convertido: ");
string? input = Console.ReadLine().Trim();

double value;
bool isDecimal = double.TryParse(input, CultureInfo.InvariantCulture, out value);

if (isDecimal)
{
    Console.WriteLine($"Valor a ser convertido: {((double)value)}");
    Console.WriteLine("Pressione a tecla ENTER para continuar.");
    Console.ReadLine();
}
else
{
    Console.WriteLine($"A entrada: {input} não é válida. Tente novamente.");
}

bool validEntry = false;

do
{
    Console.WriteLine("Informe a moeda de origem de acordo com as opções abaixo:");
    Console.WriteLine("Real - BRL");
    Console.WriteLine("Dólar - USD");
    Console.WriteLine("Euro - EUR");
    Console.Write("Digite umas das opções (BRL, USD ou EUR) ou 'SAIR' para encerrar o programa: ");
    string? menuOptionOrigin = Console.ReadLine().Trim().ToUpper();

    if (menuOptionOrigin == "BRL" || menuOptionOrigin == "USD" || menuOptionOrigin == "EUR")
    {
        Console.WriteLine($"Moeda de origem selecionada: {menuOptionOrigin}");
        Console.WriteLine("Pressione a tecla ENTER para continuar.");
        Console.ReadLine();
    }
    else if (menuOptionOrigin == "SAIR")
    {
        Console.WriteLine("Encerrando o programa...");
        Console.WriteLine("Programa encerrado. \n");        
        break;
    }
    else
    {
        Console.WriteLine("Opção de moeda inválida. Por favor, digite BRL, USD ou EUR.");
    }



    Console.WriteLine("Informe a moeda de destino de acordo com as opções abaixo:");
    Console.WriteLine("Real - BRL");
    Console.WriteLine("Dólar - USD");
    Console.WriteLine("Euro - EUR");
    Console.Write("Digite umas das opções (BRL, USD ou EUR) ou 'SAIR' para encerrar o programa: ");
    string? menuOptionDestination = Console.ReadLine().Trim().ToUpper();

    if (menuOptionDestination == "BRL" || menuOptionDestination == "USD" || menuOptionDestination == "EUR")
    {
        Console.WriteLine($"Moeda de destino selecionada: {menuOptionDestination}");
        Console.WriteLine("Pressione a tecla ENTER para continuar.");
        Console.ReadLine();
    }
    else if (menuOptionDestination == "SAIR")
    {
        Console.WriteLine("Encerrando o programa...");
        Console.WriteLine("Programa encerrado. \n");
        break;
    }
    else
    {
        Console.WriteLine("Opção de moeda inválida. Por favor, digite BRL, USD ou EUR.");
    }

    double currencyOrigin = value;
    double currencyDestination;
    double exchangeRate;

    if (menuOptionOrigin == "BRL")
    {
        if (menuOptionDestination == "USD")
        {
            exchangeRate = 0.20;
            currencyDestination = currencyOrigin * exchangeRate;

            Console.WriteLine($"Convertendo {value} {menuOptionOrigin} para {menuOptionDestination} obtemos um valor de: {currencyDestination} {menuOptionDestination}");
            validEntry = true;
        }
        else if (menuOptionDestination == "EUR")
        {
            exchangeRate = 0.18;
            currencyDestination = currencyOrigin * exchangeRate;

            Console.WriteLine($"Convertendo {value} {menuOptionOrigin} para {menuOptionDestination} obtemos um valor de: {currencyDestination} {menuOptionDestination}");
            validEntry = true;
        }
        else
        {
            Console.WriteLine("As moedas de origem e destino não podem ser iguais. Tente novamente.");
        }
    }

    if (menuOptionOrigin == "USD")
    {
        if (menuOptionDestination == "BRL")
        {
            exchangeRate = 5.00;
            currencyDestination = currencyOrigin * exchangeRate;

            Console.WriteLine($"Convertendo {value} {menuOptionOrigin} para {menuOptionDestination} obtemos um valor de: {currencyDestination} {menuOptionDestination}");
            validEntry = true;
        }
        else if (menuOptionDestination == "EUR")
        {
            exchangeRate = 0.92;
            currencyDestination = currencyOrigin * exchangeRate;

            Console.WriteLine($"Convertendo {value} {menuOptionOrigin} para {menuOptionDestination} obtemos um valor de: {currencyDestination} {menuOptionDestination}");
            validEntry = true;
        }
        else
        {
            Console.WriteLine("As moedas de origem e destino não podem ser iguais. Tente novamente.");
        }
    }

    if (menuOptionOrigin == "EUR")
    {
        if (menuOptionDestination == "BRL")
        {
            exchangeRate = 5.50;
            currencyDestination = currencyOrigin * exchangeRate;

            Console.WriteLine($"Convertendo {value} {menuOptionOrigin} para {menuOptionDestination} obtemos um valor de: {currencyDestination} {menuOptionDestination}");
            validEntry = true;
        }
        else if (menuOptionDestination == "USD")
        {
            exchangeRate = 1.09;
            currencyDestination = currencyOrigin * exchangeRate;

            Console.WriteLine($"Convertendo {value} {menuOptionOrigin} para {menuOptionDestination} obtemos um valor de: {currencyDestination} {menuOptionDestination}");
            validEntry = true;
        }
        else
        {
            Console.WriteLine("As moedas de origem e destino não podem ser iguais. Tente novamente.");
        }
    }
} while (validEntry == false);





