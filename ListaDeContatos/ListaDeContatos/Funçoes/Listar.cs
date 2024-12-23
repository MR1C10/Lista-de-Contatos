using GuardarCont;

namespace Listar
{
    public class ListHelper
    {
        public static void Listar()
        {
            var ordenar = ContatoStorage.contatos.OrderBy(x => x.Key);
            foreach (var contato in ordenar)
            {
                Console.WriteLine($"Nome: {contato.Key} - Número: {contato.Value}\n");
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
