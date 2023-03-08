using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica agenda = new AgendaTelefonica();

            agenda.inserir("lucas", "(27) 9999-8851");
            agenda.inserir("roberto soca fofo", "(22) 2196-9845");
            agenda.inserir("pedro", "(25) 9856-2564");
            agenda.inserir("clicia", "(30) 2480-2258");
            agenda.inserir("henrique", "(69) 1672-2003");

            Console.WriteLine("Lista de contatos:");
            Console.WriteLine($"Número de telefone de roberto soca fofo: {agenda.buscarNumero("roberto soca fofo")}");
            Console.WriteLine($"Número de telefone de clicia: {agenda.buscarNumero("clicia")}");
            Console.WriteLine($"Número de telefone de pedro: {agenda.buscarNumero("pedro")}");
            Console.WriteLine($"Número de telefone de gotica: {agenda.buscarNumero("goticaRabuda")}");

            agenda.remover("clicia");
            Console.WriteLine($"\nNúmero de telefone de clicia: {agenda.buscarNumero("clicia")}");

            Console.WriteLine($"\nTamanho da agenda: {agenda.tamanho()}");
        }
    }
}
