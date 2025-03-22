using System.Reflection.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;

class User  // Cadastro de clientes
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public int Age { get; set; }
}

class Program {
    static List<User> users = new List<User>(); // Lista em memória para armazenar clientes
    
    static void Main() 
    {
        // Seleção de evento:
        Console.Clear();
        while (true)
        {
            
            Console.WriteLine("------------------");
            Console.WriteLine("  SEJA BEM-VINDO");
            Console.WriteLine("------------------");
            Console.WriteLine("\nMENU PRINCIPAL:");
            Console.WriteLine("\n[1]- Novo Cadastro");
            Console.WriteLine("\n[2]- Pesquisar Cadastro");
            Console.WriteLine("\n[3]- Listar Cadastros");
            Console.WriteLine("\n[4]- Limpar Terminal");
            Console.WriteLine("\n[5]- Finalizar atendimento");
            Console.Write("\nEscolha uma das opções:\t");
            string option = Console.ReadLine();
            

            switch (option) {    // Estrutura de controle baseada na opção escolhida no menu principal
                case "1":
                    Console.Clear();
                    NewRegistration();
                    break;
                case "2":
                    SearchRegistration();
                    break;
                case "3":
                    ListRecords();
                    break;
                case "4":
                    Console.Clear();
                    break;
                case "5":
                    Console.WriteLine("\nFinalizando atendimento...");
                    Console.WriteLine("Atendimento finalizado.");
                    return;
                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                    break;
            }
        }
            
    }
    // Criando os métodos:
    static void NewRegistration() {
        Console.Write("Nome: ");    // Solicitando nome
        string name = Console.ReadLine();

        Console.Write("E-mail: ");  // Solicitando e-mail
        string email = Console.ReadLine();

        Console.Write("Idade: ");   // Solicitando idade
        if (!int.TryParse(Console.ReadLine(), out int age)) {   // Evitando retorno em string
            Console.WriteLine("Idade inválida. Tente novamente.");
            return;
        }

        users.Add(new User { Name = name, Email = email, Age = age });  // Adicionando os dados coletados na lista
        Console.WriteLine("Cadastro realizado com sucesso!");
    }
    static void SearchRegistration() {
        Console.WriteLine("\nPesquisar por: ");
        Console.WriteLine("[1]- Nome");
        Console.WriteLine("[2]- E-mail");
        Console.WriteLine("[3]- Idade");
        Console.Write("\nEscolha uma das opções:");
        string option2 = Console.ReadLine();

        List<User> result = new List<User>();    // Carregando a lista de objetos

        switch (option2) {  // Estrutura de controle baseada na opção escolhida no menu de busca
            case "1":
                Console.Write("Informe o nome: ");
                string byName = Console.ReadLine();
                result = users.Where(search => search.Name.IndexOf(byName, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                break;  
                // Utilizando indexof para encontrar o nome pela cadeia de caracteres com o ordinalignorecase, sem diferenciar as letras maíusculas das
                // minúsculas, maior ou igual a 0 para verificar se o valor informado retorna True. Se retornar False, o valor não existe na lista.
            case "2":
                Console.Write("Informe o E-mail: ");
                string byEmail = Console.ReadLine();
                result = users.Where(search => byEmail.Equals(search.Email, StringComparison.OrdinalIgnoreCase)).ToList();
                break;  // Equals retorna booleano de um comparativo entre os valores informados e os existentes na lista, se forem iguais retorna True.
            case "3":
                Console.Write("Informe a idade: ");
                if (int.TryParse(Console.ReadLine(), out int byAge)) {
                    result = users.Where(search => search.Age == byAge).ToList();
                } else {
                    Console.WriteLine("Idade inválida!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }

        if (result.Any()) {
            Console.WriteLine("\nClientes encontrados: ");
            foreach(var user in result) {
                Console.WriteLine($"Nome {user.Name}, E-mail: {user.Email}, Idade: {user.Age}");
            }
        } else {
            Console.WriteLine("Dados não encontrados.");
        }
    }

    static void ListRecords() {
            if(users.Count == 0) {      // Se a lista estiver vazia
                Console.WriteLine("Nenhum cadastro encontrado.");
                return;
            }

            Console.WriteLine("\nLista de Cadastros: ");    // Caso contrário, retornar a lista.
            foreach(var user in users) {
                Console.WriteLine($"Nome: {user.Name}, E-mail: {user.Email}, Idade: {user.Age}");
            }
    }

}







