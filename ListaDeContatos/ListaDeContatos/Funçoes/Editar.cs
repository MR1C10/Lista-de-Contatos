using GuardarCont;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Editar 
{
    public class EditHelper 
    {
        public static void Editar() 
        {
            Console.Clear();
            int numeronovo;

            Console.WriteLine("Digite o nome do contato que deseja editar:"); 
            string nomeedit = Console.ReadLine().TrimEnd();

            if (ContatoStorage.contatos.ContainsKey(nomeedit))
            {
                Console.WriteLine($"Contato encontrado: Nome: {nomeedit}, Telefone: {ContatoStorage.contatos[nomeedit]}");

                string nomenovo;
                while (true)
                {
                    Console.WriteLine("Digite o novo nome do contato:");
                    nomenovo = Console.ReadLine().TrimEnd();

                    if (nomenovo.Length < 3)
                    {
                        Console.WriteLine("Nome do contato deve ter ao menos 3 caracteres.");
                        continue;
                    }

                    if (ContatoStorage.contatos.ContainsKey(nomenovo)) // Pede um nome diferente se o contato já existir
                    {
                        Console.WriteLine("Contato já existe! Insira um nome diferente.");
                        continue;
                    }
                    break;
                }

                string telefonenovo;
                while (true)
                {
                    Console.WriteLine("Digite o novo telefone do contato:");
                    telefonenovo = Console.ReadLine().TrimEnd();

                    if (!int.TryParse(telefonenovo, out numeronovo) || telefonenovo.Length != 9)// Confere se o número é válido
                    {
                        Console.WriteLine("Número inválido. Digite outro número.");
                        continue;
                    }
                    else { break; }
                }

                ContatoStorage.contatos.Remove(nomeedit); // Serve pra remover o contato antigo
                ContatoStorage.contatos[nomenovo] = telefonenovo; // Serve pra adiciona o novo contato

                Console.WriteLine("Contato atualizado com sucesso!");
            }

            else
            {
                Console.WriteLine("Contato não encontrado!");
            }
        }
    }
}