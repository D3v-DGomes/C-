/*

Desafio: Melhorar a taxa de renovação de subscrições
Foi-lhe solicitado que adicionasse uma funcionalidade ao software da sua empresa.
A funcionalidade destina-se a melhorar a taxa de renovação de subscrições do software. 
Sua tarefa é exibir uma mensagem de renovação quando um usuário fizer login no sistema de software 
e for notificado de que sua assinatura terminará em breve. Precisará de adicionar algumas instruções 
de decisão para adicionar corretamente a lógica de ramificação à aplicação de forma a corresponder 
às condições.

*/

Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if(daysUntilExpiration == 0) {
    Console.WriteLine("Your subscription has expired.");
} else if(daysUntilExpiration == 1) {
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
} else if(daysUntilExpiration <= 5) {
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
} else if(daysUntilExpiration <= 10) {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if(discountPercentage > 0) {
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}