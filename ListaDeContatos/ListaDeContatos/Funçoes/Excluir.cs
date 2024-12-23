using GuardarCont;

namespace Excluir
{
    public class ExcluirHelper
    {
        public static void Excluir()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Digite o nome do contato que deseja excluir:");
                string exclu = Console.ReadLine().TrimEnd();

                if (ContatoStorage.contatos.ContainsKey(exclu))
                { 
                    while (true)
                    {
                        Console.WriteLine($"Nome: {exclu} - Número: {ContatoStorage.contatos[exclu]}");//Mostra o contato que deseja excluir

                        Console.WriteLine("Tem certeza que deseja excuir esse contato?\ns/n");//confirmação de exlusão
                        string confir = Console.ReadLine();

                        if (confir == "s")//exclui o contato
                        {
                            ContatoStorage.contatos.Remove(exclu);
                            Console.WriteLine("Contato excluido com sucesso!");

                            while (true)
                            {
                                Console.WriteLine("Digite V para voltar ao menu\n");
                                string respo = Console.ReadLine().ToLower();

                                if (respo == "v")
                                {
                                    Console.Clear();
                                    break;
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Opção invalida!");
                                    continue;
                                }
                            }
                                break;
                        }

                        else if (confir == "n")//mantem o contato
                        {
                            Console.WriteLine("Contato não excluido!");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Opção invalida!\n");
                            continue;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Contato não encontrado!");
                    continue;
                }

                break;
            }
        }
    }
}