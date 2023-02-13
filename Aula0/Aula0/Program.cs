using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PopulacaoBarata baratas = new PopulacaoBarata();

            Console.WriteLine("\nA população de baratas é:\n");
            Console.WriteLine(baratas.GetQtdeBaratas());

            baratas.Spray();
            baratas.Spray();

            Console.WriteLine("\nA população de baratas é:\n");
            Console.WriteLine(baratas.GetQtdeBaratas());

            baratas.Procria();

            Console.WriteLine("\nA população de baratas é:\n");
            Console.WriteLine(baratas.GetQtdeBaratas());


        }
    }
}