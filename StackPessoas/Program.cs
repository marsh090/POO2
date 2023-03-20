using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPessoas
{
    using System;

    public class Program
    {
        public static void Main()
        {
            GerenciadorPessoas gerenciador = new GerenciadorPessoas();

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nMENU:");
                Console.WriteLine("[1]Adicionar pessoa");
                Console.WriteLine("[2]Remover última pessoa adicionada");
                Console.WriteLine("[3]Mostrar Lista");
                Console.WriteLine("[4]Sair");

                Console.Write("Digite a opção desejada: ");
                int opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Pessoa novaPessoa = new Pessoa();
                        Console.Write("Digite o nome da pessoa: ");
                        novaPessoa.Nome = Console.ReadLine();
                        Console.Write("Digite o CPF da pessoa: ");
                        novaPessoa.CPF = Console.ReadLine();
                        gerenciador.AdicionarPessoa(novaPessoa);
                        Console.Clear();
                        break;

                    case 2:
                        if (gerenciador.Vazio()){
                            Console.WriteLine("Não há pessoas no Stack!");
                        }
                        else{
                            Pessoa ultimaPessoa = gerenciador.RemoverUltimaPessoa();
                            Console.WriteLine($"Última pessoa adicionada removida: {ultimaPessoa.Nome} - {ultimaPessoa.CPF}");
                        }
                        break;

                    case 3:
                        if (gerenciador.Vazio())
                        {
                            Console.WriteLine("Não há pessoas no Stack!");
                        }
                        else
                        {
                            gerenciador.MostrarPessoas();
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saindo...");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Essa opção não existe");
                        break;
                        
                }

            }
        }
    }
}
