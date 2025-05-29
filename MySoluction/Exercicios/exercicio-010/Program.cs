/*
2- Crie um programa em C# que sirva para pesquisar um array de valores inteiros. Para fazer isso, siga estas
etapas a seguir:

a-) Solicite via teclado o número de valores do array (deve ser um número inteiro);
b-) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados;
c-) Solicite ao usuário um valor de um número inteiro a procurar no array;
d-) Exiba se o número informado existe no array de inteiros ou não;
e-) Repita até que o texto ‘fim’ seja inserido via teclado;

*/

Console.Write("Informe o número (inteiro) de valores do array: ");
int input = Convert.ToInt32(Console.ReadLine());

int[] array = new int[input];

Console.WriteLine("Informe os valores do array:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Número[{i}] = ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

string? pesquisa;
bool validEntry = false;

Console.WriteLine("\nPesquise por um número no seu array ( ou digite 'fim' para encerrar o programa): ");
do
{
        pesquisa = Console.ReadLine();

        if (pesquisa != "fim")
        {
            int valor = Convert.ToInt32(pesquisa);

            if (array.Contains(valor))
            {
                Console.WriteLine($"O número {valor} está contido em seu array.");
            }
            else
            {
                Console.WriteLine($"O número {valor} NÃO faz parte do seu array.");
            }
        }
        else
        {
            validEntry = true;
        }

} while (validEntry == false);