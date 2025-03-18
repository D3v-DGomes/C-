Console.WriteLine("Verificando o DateTime");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

// Criando data específica:
DateTime dateToDay = new DateTime(2024, 01, 10);
Console.WriteLine(dateToDay);

// Definindo as horas:
DateTime dateToDay1 = new DateTime(2024, 01, 10, 17, 10, 02);
Console.WriteLine(dateToDay1);

// Extraindo informações:
Console.WriteLine(dateToDay1.Year);     
Console.WriteLine(dateToDay.Day);
Console.WriteLine(dateToDay.Month);

// Informando a data no formato longo e curto:
Console.Write(dateToDay.ToLongDateString());
Console.WriteLine(dateToDay.ToShortDateString());

