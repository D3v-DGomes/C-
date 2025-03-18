// ENTRADA DE DADOS: Console.ReadLine(), Console.Read() e Console.ReadKey()

// ReadLine() só aceita caractere do tipo string:
Console.WriteLine("\n Informe o seu nome: ");
string name = Console.ReadLine();



// Convertendo o valor int para str:
Console.WriteLine("\n Informe a sua idade:");
int old = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O seu nome é {name} e você tem {old} anos.");

// Read() só é indicado para ler 1 caractere pois ele retorna o seu código ASC:
Console.WriteLine("\n Informe a sua idade:");
int old1 = Convert.ToInt32(Console.Read());
Console.WriteLine($"O seu nome é {name} e você tem {old1} anos.");
