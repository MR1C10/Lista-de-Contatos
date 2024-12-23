using GuardarCont;

namespace Add_Verif;

public class AddHelper
{
    public static void Adicionar()
    {
        string nome;
        int numero;
        Console.Clear();

        while (true)// Pede o nome do contato
        {
            Console.WriteLine("\nNome: ");
            nome = Console.ReadLine().Trim();

            if (nome.Length < 3)
            {
                Console.WriteLine("Nome do contato deve ter ao menos 3 caracteres.");
                continue;
            }

            if (ContatoStorage.contatos.ContainsKey(nome)) // Pede um nome diferente se o contato já existir
            {
                Console.WriteLine("Contato já existe! Insira um nome diferente.");
                continue;
            }
            break;
        }

        while (true)// Pede o número do contato
        {
            Console.WriteLine("\nNúmero: ");
            string numeroInput = Console.ReadLine();

            if (!int.TryParse(numeroInput, out numero) || numeroInput.Length != 9)// Confere se o número é válido
            {
                Console.WriteLine("Número inválido. Digite outro número.");
                continue;
            }
            else { break; }
        }
        
        ContatoStorage.contatos.Add(nome, numero.ToString());// Adiciona o contato ao dicionário

        Console.WriteLine("Contato adicionado!\n");

        while (true)// Pergunta se quer adicionar outro contato
        {
            Console.WriteLine("Adicionar outro contato?\ns/n");
            string resposta = Console.ReadLine();

            if (resposta == "s")
            {
                Adicionar();
                Console.Clear();
                break;
            }

            else if (resposta == "n")
            {
                break;
            }

            else
            {
                Console.WriteLine("Opção invalida!\n");
            }
        }
    }
}