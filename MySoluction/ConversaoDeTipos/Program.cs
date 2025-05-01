// CONVERSÃO DE TIPOS: Implícito, explícito, método ToString() e método de classe Convert:

// Conversão implícita:
/*
Para que ocorra é necessário que o valor original seja menor que o futuro. Caso contrário, não haverá conversão.

byte -> 1 bytes
short -> 2 bytes
int -> 3 bytes
long -> 4 bytes
float -> 5 bytes
double -> 6 bytes
decimal -> 7 bytes

De ->	Para
sbyte ->	short , int, long, float, double, ou decimal
byte ->	short , ushort, int, uint, long, ulong, float, double, ou decimal
short ->	int , long, float, double, ou decimal
ushort ->	int , uint, long, ulong, float, double, ou decimal
int ->	long , float, double, ou decimal
uint ->	long , ulong, float, double, ou decimal
long ->	float , double, ou decimal

*/

// Conversão explícita:
/*
De ->	Para
sbyte ->	byte , ushort, uint, ulong, ou char
byte ->	Sbyte ou char
short ->	sbyte , byte, ushort, uint, ulong, ou char
ushort ->	sbyte , byte, short, ou char
int ->	sbyte , byte, short, ushort, uint, ulong, ou char
uint ->	sbyte , byte, short, ushort, int, ou char
long ->	sbyte , byte, short, ushort, int, uint, ulong, ou char
*/

// ToStrin():
int valorInt = 3;
double valorDouble = 54.23;
decimal valorDecimal = 32.2357m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

// Classe Convert():
/*
Method ->	Description
ToBoolean() ->	converts a type to a Boolean value
ToChar() ->	converts a type to a char type
ToDouble() ->	converts a type to a double type
ToInt16() ->	converts a type to a 16-bit int type
ToString() ->	converts a type to a string
*/

int numInt = 5;
double numDouble = 5.76;
bool valorBoolean = true;

Console.WriteLine(Convert.ToString(numInt));
Console.WriteLine(Convert.ToString(valorBoolean));
Console.WriteLine(Convert.ToDouble(numInt));
Console.WriteLine(Convert.ToInt32(numDouble));