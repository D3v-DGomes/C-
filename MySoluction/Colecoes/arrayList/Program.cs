using System.Collections;

// Formas de inicialização:

// 1-
ArrayList lista;
lista = new ArrayList();

// 2-
ArrayList lista1 = new ArrayList();

// 3-
var lista2 = new ArrayList();

// 4-
ArrayList lista3 = new();

// 5- Especificando o Capacity:
ArrayList lista4 = new(5);


// Adicionando dados ao ArrayList:

// 1-
lista.Add("Kevin");
lista.Add(5.66);
lista.Add(0);
lista.Add(true);
lista.Add(null);

// 2- Com inicializadores de objeto:

var lista5 = new ArrayList() { "Kevin", 5.66, 0, true, null };


// 3- Utilizando o .insert(index, valor):
lista5.Insert(0, "David");

// 4- Com .AddRange():
int[] array1 = { 1, 2, 3, };

lista5.AddRange(array1);


// 5- Com .InsertRange(index, valor):
string[] strings1 = { "teste1", "teste2", };

lista5.InsertRange(3, strings1);

// 6- Removendo um objeto específico usando .Remove():
lista5.Remove(null);

// 7- Removendo um objeto a partir do seu index usando .RemoveAt():
lista5.RemoveAt(0);

// 8- Removendo objetos a partir de um index específico até uma quantidade de Count com .RemoveRange():
lista5.RemoveRange(1, 3);

Console.WriteLine("");

// 9- Verificando a existência de um elemento usando .Contains():
lista5.Contains("teste");

// 10- Ordendando o ArrayList de forma ascendente:
lista5.Sort();  // Só é efetivo se o ArrayList possuir todos os elementos do mesmo tipo.

// 11- Apagando todos os elementos do ArrayList com .Clear():
lista5.Clear();