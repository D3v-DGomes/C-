using System.Diagnostics;

public class JogoDaForca {
    static void Main(string[] args) {

        Console.WriteLine("------------------------------------");
        Console.WriteLine("  SEJA BEM-VINDO AO JOGO DA FORCA  ");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\nExistem três níveis de dificuldade: \n");
        Console.WriteLine("[1]- FÁCIL");
        Console.WriteLine("[2]- MÉDIO");
        Console.WriteLine("[3]- DIFÍCIL\n");
        Console.Write("Informe o nível desejado: ");

        string answer = Console.ReadLine();

        int number;

        if(int.TryParse(answer, out number)) {
            if(number >= 1 && number <= 3) {
                char escolha;
                do{
                    Console.Clear();
                    Console.WriteLine("------------------");
                    Console.WriteLine("  JOGO DA FORCA  ");
                    Console.WriteLine("------------------");


                    switch(number) {
                        case 1:
                            
                                Console.WriteLine($"Nível escolhido: FÁCIL");

                                string palavraSecretaNFacil = "ROSA";     // 1. Palavra secreta
                                palavraSecretaNFacil = palavraSecretaNFacil.ToUpper();

                                char[] palavraOcultaNFacil = new char[palavraSecretaNFacil.Length];     //2. Palavra oculta
                                for(int i = 0; i < palavraOcultaNFacil.Length; i++){
                                    palavraOcultaNFacil[i] = '_';
                                }

                                int tentativasRestantesNFacil = 5;    //3. Tentativas

                                List<char> letrasTentadasNFacil = new List<char>();   //4. Letras tentadas

                                while(tentativasRestantesNFacil > 0){     // Loop principal do jogo
                
                                     // Exibir palavra oculta e tentativas restantes
                                    Console.WriteLine($"\nPalavra: {string.Join(" ", palavraOcultaNFacil)}");
                                    Console.WriteLine($"Tentativas restantes:{tentativasRestantesNFacil}");

                                    Console.WriteLine("\nDica: É uma cor e também uma flor.");
                                    Console.Write("Digite uma letra: ");    // Solicitar letra do jogador
                                    char letra = Console.ReadKey().KeyChar;
                                    Console.WriteLine();

                                    letra = char.ToUpper(letra);  // Deixando a letra escolhida em maiúsculo

                                    if(letrasTentadasNFacil.Contains(letra)){ // Verificando se a letra já foi tentada
                                        Console.WriteLine("Você já tentou essa letra.");
                                        continue;
                                    }

                                    letrasTentadasNFacil.Add(letra);      // Adicionar letra à lista de tentativas

                                    if(palavraSecretaNFacil.Contains(letra)){     // Verificar se a letra está na palavra secreta

                                        for(int i = 0; i < palavraSecretaNFacil.Length; i++){     // Revelar letras na palavra oculta
                                            if(palavraSecretaNFacil[i] == letra){
                                                palavraOcultaNFacil[i] = letra;
                                            }
                                        }

                                        if(!Array.Exists(palavraOcultaNFacil, c => c == '_' )){   // Verificar se o jogador venceu
                                            Console.WriteLine($"\nParabéns, você venceu! A palavra era: {palavraSecretaNFacil}");
                                            return;
                                        }
                                    } else {
                                        tentativasRestantesNFacil--;      //  Diminuir tentativas restantes
                                        Console.WriteLine("Letra incorreta!");
                                    }
                                }
                        break;
                                

                        case 2:
                                Console.WriteLine($"Nível escolhido: MÉDIO");

                                string palavraSecretaNMedio = "MORCEGO";     // 1. Palavra secreta
                                palavraSecretaNMedio = palavraSecretaNMedio.ToUpper();

                                char[] palavraOcultaNMedio = new char[palavraSecretaNMedio.Length];     //2. Palavra oculta
                                for(int i = 0; i < palavraOcultaNMedio.Length; i++){
                                    palavraOcultaNMedio[i] = '_';
                                }

                                int tentativasRestantesNMedio = 4;    //3. Tentativas

                                List<char> letrasTentadasNMedio = new List<char>();   //4. Letras tentadas

                                while(tentativasRestantesNMedio > 0){     // Loop principal do jogo
                
                                     // Exibir palavra oculta e tentativas restantes
                                    Console.WriteLine($"\nPalavra: {string.Join(" ", palavraOcultaNMedio)}");
                                    Console.WriteLine($"Tentativas restantes:{tentativasRestantesNMedio}");

                                    Console.WriteLine("\nDica: É o único mamífero que voa. \n");
                                    Console.Write("Digite uma letra: ");    // Solicitar letra do jogador
                                    char letra = Console.ReadKey().KeyChar;
                                    Console.WriteLine();

                                    letra = char.ToUpper(letra);  // Deixando a letra escolhida em maiúsculo

                                    if(letrasTentadasNMedio.Contains(letra)){ // Verificando se a letra já foi tentada
                                        Console.WriteLine("Você já tentou essa letra.");
                                        continue;
                                    }

                                    letrasTentadasNMedio.Add(letra);      // Adicionar letra à lista de tentativas

                                    if(palavraSecretaNMedio.Contains(letra)){     // Verificar se a letra está na palavra secreta

                                        for(int i = 0; i < palavraSecretaNMedio.Length; i++){     // Revelar letras na palavra oculta
                                            if(palavraSecretaNMedio[i] == letra){
                                                palavraOcultaNMedio[i] = letra;
                                            }
                                        }

                                        if(!Array.Exists(palavraOcultaNMedio, c => c == '_' )){   // Verificar se o jogador venceu
                                            Console.WriteLine($"Parabéns, você venceu! A palavra era: {palavraSecretaNMedio}");
                                            return;
                                        }
                                    } else {
                                        tentativasRestantesNMedio--;      //  Diminuir tentativas restantes
                                        Console.WriteLine("Letra incorreta!");
                                    }
                                }
                        break;


                        case 3:
                                Console.WriteLine($"Nível escolhido: DIFÍCIL");

                                string palavraSecretaNDificil = "QUINTESSENCIA";     // 1. Palavra secreta
                                palavraSecretaNDificil = palavraSecretaNDificil.ToUpper();

                                char[] palavraOcultaNDificil = new char[palavraSecretaNDificil.Length];     //2. Palavra oculta
                                for(int i = 0; i < palavraOcultaNDificil.Length; i++){
                                    palavraOcultaNDificil[i] = '_';
                                }

                                int tentativasRestantesNDificil = 3;    //3. Tentativas

                                List<char> letrasTentadasNDificil = new List<char>();   //4. Letras tentadas

                                while(tentativasRestantesNDificil > 0){     // Loop principal do jogo
                
                                     // Exibir palavra oculta e tentativas restantes
                                    Console.WriteLine($"\nPalavra: {string.Join(" ", palavraOcultaNDificil)}");
                                    Console.WriteLine($"\nTentativas restantes:{tentativasRestantesNDificil}");

                                    Console.WriteLine("Dica: A essência mais pura de algo.");
                                    Console.Write("Digite uma letra: ");    // Solicitar letra do jogador
                                    char letra = Console.ReadKey().KeyChar;
                                    Console.WriteLine();

                                    letra = char.ToUpper(letra);  // Deixando a letra escolhida em maiúsculo

                                    if(letrasTentadasNDificil.Contains(letra)){ // Verificando se a letra já foi tentada
                                        Console.WriteLine("Você já tentou essa letra.");
                                        continue;
                                    }

                                    letrasTentadasNDificil.Add(letra);      // Adicionar letra à lista de tentativas

                                    if(palavraSecretaNDificil.Contains(letra)){     // Verificar se a letra está na palavra secreta

                                        for(int i = 0; i < palavraSecretaNDificil.Length; i++){     // Revelar letras na palavra oculta
                                            if(palavraSecretaNDificil[i] == letra){
                                                palavraOcultaNDificil[i] = letra;
                                            }
                                        }

                                        if(!Array.Exists(palavraOcultaNDificil, c => c == '_' )){   // Verificar se o jogador venceu
                                            Console.WriteLine($"Parabéns, você venceu! A palavra era: {palavraSecretaNDificil}");
                                            return;
                                        }
                                    } else {
                                        tentativasRestantesNDificil--;      //  Diminuir tentativas restantes
                                        Console.WriteLine("Letra incorreta!");
                                    }
                                }
                        break;
                    }
                            Console.Write("\nDeseja jogar novamente?  (S/N): ");
                            escolha = Console.ReadKey().KeyChar;
                            Console.WriteLine();
                } while(escolha == 's' || escolha == 'S');
            } else {
                Console.WriteLine("Número fora do intervalo permitido (1 a 3).");
            }
        } else {
            Console.WriteLine("Entrada inválida. Digite um número inteiro.");
        }

    }
}

