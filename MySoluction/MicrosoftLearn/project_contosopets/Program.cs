// The ourAnimals array will store the following:
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry:
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data:
string[,] ourAnimals = new string[maxPets, 6];

// Create some initial ourAnimals array entries:
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "Golden retriever fêmea de tamanho médio, cor creme, pesando cerca de 26 quilos. Adestrada.";
            animalPersonalityDescription = "adora que lhe façam carinho na barriga e gosta de perseguir o próprio rabo. dá muitos beijinhos.";
            animalNickname = "Lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "Grande golden retriever macho marrom-avermelhado, pesando cerca de 39 quilos. Domado.";
            animalPersonalityDescription = "adora que lhe façam carinho nas orelhas quando te cumprimenta na porta, ou a qualquer momento! adora se inclinar e dar abraços de cachorro.";
            animalNickname = "Loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "pequena fêmea branca pesando cerca de 3,6 kg. treinada para usar caixa de areia.";
            animalPersonalityDescription = "amigável";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}
do
{
    // Display the top-level menus options:
    Console.Clear();

    Console.WriteLine("Bem-vindo ao aplicativo Contoso PetFriends. As principais opções do menu são:");
    Console.WriteLine("[1] - Listar todas as nossas informações atuais sobre animais de estimação");
    Console.WriteLine("[2] - Adicione um novo amigo animal ao array ourAnimals");
    Console.WriteLine("[3] - Garantir que as idades dos animais e as descrições físicas estejam completas");
    Console.WriteLine("[4] - Certifique-se de que os apelidos dos animais e as descrições de personalidade estejam completos");
    Console.WriteLine("[5] - Editar a idade de um animal");
    Console.WriteLine("[6] - Editar a descrição da personalidade de um animal");
    Console.WriteLine("[7] - Exibir todos os gatos com uma característica específica");
    Console.WriteLine("[8] - Exibir todos os cães com uma característica específica");
    Console.WriteLine();
    Console.WriteLine("Digite seu número de seleção (ou digite Sair para sair do programa)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information:
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPressione ENTER para continuar.");
            readResult = Console.ReadLine();

            break;

        case "2":
            // Add a new animal friend to the ourAnimals array:
            string anotherPet = "s";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"Atualmente temos {petCount} animais de estimação que precisam de um lar. Podemos gerenciar mais {(maxPets - petCount)} animais.");
            }

            while (anotherPet == "s" && petCount < maxPets)
            {
                bool validEntry = false;

                // Get species (cat or dog) - string animalSpecies is a required field:
                do
                {
                    Console.WriteLine("\n\rDigite 'cachorro' ou 'gato' para iniciar uma nova entrada:");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "cachorro" && animalSpecies != "gato")
                        {
                            Console.WriteLine($"Você digitou: {animalSpecies}");
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // Build the animal ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Cat 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // Get the pet's age. Can be? at initial entry:
                do
                {
                    int petAge;
                    Console.WriteLine("Digite a idade do pet ou digite ? se desconhecido.");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // Get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Digite a descrição física do pet (tamanho, cor, genero, peso, domesticação)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");

                // Get a description of the pet's personality - animalPersonalityDescription can be blank:
                do
                {
                    Console.WriteLine("Digite a descrição da personalidade do pet (gostos ou desgostos, truques, nível de energia)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");

                // Get the pet's nickname. animalNickname can be blank:
                do
                {
                    Console.WriteLine("Digite o nome do pet:");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");

                // Store the pet information in the ourAnimals array (zero based):
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                // Increment petCount (the array is zero-based, so we increment the counter after adding to the array):
                petCount = petCount + 1;

                // Check maxPet limit:
                if (petCount < maxPets)
                {
                    // Another pet?
                    Console.WriteLine("Você deseja inserir informações para outro pet (s/n)?");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }
                    } while (anotherPet != "s" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("Atingimos o limite do número de aniumais de estimação que podemos gerenciar.");
                Console.WriteLine("Pressione ENTER para continuar.");
                readResult = Console.ReadLine();
            }

            break;

        case "3":
            // Ensure animal ages and physical descriptions are complete
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();

            break;

        case "4":
            // Ensure animal ages and physical descriptions are complete
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();

            break;

        case "5":
            // Display all dogs with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();

            break;

        case "6":
            // Display all dogs with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();

            break;

        case "7":
            // Display all dogs with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();

            break;

        case "8":
            // Display all dogs with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();

            break;

        default:
            break;
    }

} while (menuSelection != "sair");


// TESTE