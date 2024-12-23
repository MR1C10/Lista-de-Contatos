using GuardarCont;

namespace Pesquisa
{
    public class PesquisaHelper
    {
        public static void Pesquisar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite o nome do contato:");
                string nomePesquisa = Console.ReadLine().TrimEnd();

                if (ContatoStorage.contatos.ContainsKey(nomePesquisa))
                {
                    string numero = ContatoStorage.contatos[nomePesquisa];
                    Console.WriteLine($"Nome: {nomePesquisa} - Número: {numero}");
                    break;
                }

                else
                {
                    Console.WriteLine("Contato não encontrado.");
                    continue;
                }
            }

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
        }
    }
}
