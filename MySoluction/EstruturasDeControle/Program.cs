// // IF
// Console.WriteLine("Informe se o cliente VIP (S/N): \n");
// var resposta = Console.ReadLine();

// if(resposta == "S") {
//     Console.WriteLine("Desconto de 10% concedido.");
// }
// Console.WriteLine("Fim do processamento.");

// // Com Boolean:
// Console.WriteLine("Informe se o cliente VIP (true/false): \n");
// var resposta1 = Convert.ToBoolean(Console.ReadLine());

// if(resposta1) {
//     Console.WriteLine("Desconto de 17% concedido.");
// }

// // Outro exemplo:
// Console.WriteLine("Informe o valor de x \t");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Informe o valor de y \t");
// int y = Convert.ToInt32(Console.ReadLine());

// if(x > y) {
//     Console.WriteLine("X é maior que Y.");
// }

// if(x < y)   // Alternativa de sintaxe correta 
//     Console.WriteLine("X é menor que Y.");

// if(x == y)
//     Console.WriteLine("X é igual a Y.");


// // IF-ELSE
// Console.WriteLine("Informe a nota da prova: ");
// var nota = Convert.ToInt16(Console.ReadLine());

// if(nota >= 7) {
//     Console.WriteLine("Parabéns! Você foi aprovado.");
// } else {
//     Console.WriteLine("Estude um pouco mais. Você foi reprovado.");
// }
// Console.WriteLine("Fim da análise.");


// // IF-ELSE-IF
// Console.WriteLine("Informe a nota do aluno:");
// var notaFinal = Convert.ToDouble(Console.ReadLine());

// if (notaFinal < 5) {
//     Console.WriteLine("Aluno reprovado. \n");
// } else if (notaFinal >= 5 && notaFinal < 6) {
//     Console.WriteLine("Aluno em recuperação. \n");
// } else if (notaFinal >=6 && notaFinal <= 8) {
//     Console.WriteLine("Aluno aprovado. \n");
// } else {
//     Console.WriteLine("Aluno aprovado com distinção! \n");
// }
// Console.WriteLine("Fim da análise.");

// // SWITCH CASE
// Console.WriteLine("Valor total da compra: R$600,00 \n");
// Console.WriteLine("Informe o número de prestações desejado (1 a 3): \t");
// var numeroDeParcelas = Convert.ToInt32(Console.ReadLine());

// switch(numeroDeParcelas) {
//     case 1:
//         Console.WriteLine($"\nValor da prestação: R${600/numeroDeParcelas}");
//         break;
//     case 2:
//         Console.WriteLine($"\nValor da prestação: R${600/numeroDeParcelas}");
//         break;
//     case 3:
//         Console.WriteLine($"\nValor da prestação: R${600/numeroDeParcelas}");
//         break;
//     default:
//         Console.WriteLine("\nOpção inválida. Atendimento encerrado.");
//         return;
// }
// Console.WriteLine("\n Compra finalizada com sucesso. Até a próxima!");

// // Outro exemplo:
// Console.WriteLine("Informe um número inteiro: \n");
// var parImpar = Convert.ToInt32(Console.ReadLine());

// switch (parImpar % 2) {
//     case 0:
//         Console.WriteLine($"O número {parImpar} é par.");
//         break;
//     case 1:
//         Console.WriteLine($"O número {parImpar} é ímpar.");
//         break;

// }

// Usando switch para valores diferentes:
// Console.WriteLine("Informe um dos 12 meses que o ano tem: \t");
// var mes = Console.ReadLine().ToLower();

// switch (mes) {
//     case "janeiro":
//     case "março":
//     case "maio":
//     case "julho":
//     case "agosto":
//     case "outubro":
//     case "dezembro":
//         Console.WriteLine("Este mês tem 31 dias.");
//         break;
//     case "fevereiro":
//         Console.WriteLine("Este mês tem 28 ou 29 dias.");
//         break;
//     default:
//         Console.WriteLine("Este mês tem 30 dias.");
//         break;
// }

// SWITCH ANINHADA
// int cargo = 0;
// int funcao = 0;

// Console.WriteLine("Você é Gerente(1) ou Progamador(2)\t");
// cargo = Convert.ToInt32(Console.ReadLine());

// if(cargo == 2) {
//     Console.WriteLine("Vocé Júnior(1) ou Sênior(2)");
//     funcao = Convert.ToInt32(Console.ReadLine());
// }
// switch(cargo) {
//     case 1:
//         Console.WriteLine("\n Bem-vindo, Gerente!");
//         break;
//     case 2:
//         Console.WriteLine("\n Bem-vindo, Programador");
//         switch(funcao) {
//             case 1:
//                 Console.WriteLine("\nVocé Junior");
//                 break;
//             case 2:
//                 Console.WriteLine("\nVocê é Sênior");
//                 break;
//         }
//         break;
//     default:
//         Console.WriteLine("Função desconhecida.");
//         break;
// }
// Console.WriteLine("Fim do processamento.");


// WHILE
// var i = 1;

// while(i <= 10) {
//     Console.WriteLine($"i = {i}");
//     i++;
// }

// var x = 10;

// while(x > 1) {
//     Console.WriteLine($"\n x = {x}");
//     x--;
// }

// // Tabuada de um número maior que zero
// Console.WriteLine("Informe um número: \t");
// var number = Convert.ToDouble(Console.ReadLine());
// int count = 1;

// if (number > 0) {
//     // loop:
//     Console.WriteLine($"\n ## Tabauada do {number} ##\n");
//     while(count < 11) {
//         Console.WriteLine($"{number} x {count} = {number * count}");
//         count++;
//     }

// } else {
//     Console.WriteLine("O número deve ser maior que zero.");
// }

// LOOP INFINITO:
// while(true) {
//     Console.WriteLine("\nInforme um número inteiro: (Para sair tecle 999)");

//     int newNumber = Convert.ToInt32(Console.ReadLine());

//     if(newNumber == 999) {
//         break;
//     }

//     if(newNumber % 2 == 0) {
//         Console.WriteLine($"{newNumber} é PAR.");
//     } else {
//         Console.WriteLine($"{newNumber} é ÍMPAR.");
//     }
// }
// Console.WriteLine("\nAplicação encerrada.");

// LOOP ANINHADO (Matriz)
// int x = 0;

// while (x < 5) {
//     int y = 0;
//     while (y < 5) {
//         Console.Write($"({x}, {y}) ");
//         y++;
//     }
//     x++;
// }

// DO WHILE:
// using System.IO.Compression;

// var i = 1;

// do {
//     Console.Write($"i = {i}");
//     i++;

//     if (i > 7) {
//         break;
//     }
// }
// while (i <= 10);

// DO WHILE com Matriz:
// var z = 0;

// do {
//     int y = 0;
//     do {
//         Console.Write($"({z}, {y}) ");
//         y++;
//     }
//     while (y < 5);
//     z++;
//     Console.WriteLine();
// }
// while (z < 5);


// FOR
// for(int i = 1; i <= 10; i++) {
//     Console.WriteLine($"i = {i}");
// }
// // tabuada com FOR
// Console.WriteLine("Informe um número inteiro:\t");
// int numeroInteiro = Convert.ToInt32(Console.ReadLine());

// if(numeroInteiro > 0) {
//     for(int i = 1; i <= 10; i++) {
//     int resultadoTabuada = numeroInteiro * i;
//     Console.WriteLine($"{numeroInteiro} x {i} = {resultadoTabuada}");
// }
// } else { 
//     Console.WriteLine("Número inválido.");
// }

// Múltiplas expressões com FOR
for(int m = 0, n = 0; m + n <= 10; m++, n++) {
    Console.WriteLine($"m = {m} e n = {n}");
}

// BREAK e CONTINUE
// for(;;) {
//     Console.WriteLine("Tecle algo (X sai)");
//     var opcao = Console.ReadLine();

//     Console.WriteLine(opcao.ToLower());

//     if (opcao == "x" || opcao == "X") {
//         Console.WriteLine("Tchau!");
//         break;
//     }
// }

for (int i = 1; i <= 20; i++) {
    if (i % 2 == 0) {
        continue;
    }

    Console.WriteLine(i);
}

// CONTINUE com while:
int p = 1;
while(p <= 10) {
    if (p == 5) {
        p++;
        continue;
    }
    Console.WriteLine($"p={p}");
    p++;
}

for(int i = 1; i <= 10; i++) {
    if (i == 5) {
        continue;
    }
    if (i > 8) {
        break;
    }
    Console.WriteLine(i);
}