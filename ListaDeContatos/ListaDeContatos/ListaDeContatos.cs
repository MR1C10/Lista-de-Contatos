using System;
using System.ComponentModel.DataAnnotations;
using Menu;
using Add_Verif;
using Listar;
using Pesquisa;
using Editar;
using Excluir;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Lista de Contatos ===\n");
            MenuHelper.MostrarMenu();
            Console.Write("\nEscolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("\nAdicionar Contato:");
                    AddHelper.Adicionar();  // Funçao Adicionar contatos
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Contatos Salvos:");
                    ListHelper.Listar(); // Função para mostrar os contatos
                    break;

                case "3":
                    Console.WriteLine("Buscar Contato:");
                    PesquisaHelper.Pesquisar(); // Função para pesquisar contatos
                    break;

                case "4":
                    Console.WriteLine("Editar Contato:");
                    EditHelper.Editar(); // Função para editar contatos
                    break;

                case "5":
                    Console.WriteLine("Excluir Contato:");
                    ExcluirHelper.Excluir(); // Função para excluir contatos
                    break;

                case "6":
                    Console.Clear();
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção invalida!\n");
                    break;
            }
        }
    }
}