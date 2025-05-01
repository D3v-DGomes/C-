/*

Exercício - Crie lógica de decisão com instruções if

Escreva código que gera três números aleatórios e os exibe na saída

*/
Random dice = new();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Verificando se há dois dados com o mesmo valor:
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    } else {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }

    Console.WriteLine($"Total points: {total}");
}
// Adicionando instrução if para exibir diferentes prêmios a depender do resultado:
if(total >= 16) {
    Console.WriteLine("Congratulations! You win a new car!");
} else if (total >= 10) {
    Console.WriteLine("Congratulations! You win a new laptop!");
} else if (total == 7) {
    Console.WriteLine("Congratulations! You win a trip for two!");
} else {
    Console.WriteLine("Congratulations! You win a kitten!");
}

