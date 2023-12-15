using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {

        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
 
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você quer criar algo!");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Deletar imediatamente!");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Você quer editar!");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Você quer Listar!");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Você quer atualizar!");
                     break;
                default:
                    Console.WriteLine("Opção não encontrada!");
                    break;
            }

            Console.WriteLine(opcaoSelecionada);


            Console.ReadLine();

        }
    }
}
