using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Criando instâncias de Carro
            Carro carro1 = new Carro("quatro portas", "Gol", "bolinha");
            Carro carro2 = new Carro("2 portas", "Gol", "bolinha");
            Carro carro3 = new Carro("4.307 portas", "Gol", "bolinha");

            // Criando instâncias de Lancha
            Lancha lancha1 = new Lancha(2, "Gol", "bolinha");
            Lancha lancha2 = new Lancha(47, "Gol", "bolinha");
            Lancha lancha3 = new Lancha(7, "Gol", "bolinha");

            // Criando instâncias de Caminhao
            Caminhao caminhao1 = new Caminhao("não sei o que é isso", "Gol", "bolinha");
            Caminhao caminhao2 = new Caminhao("não sei o que é segmento", "Gol", "bolinha");
            Caminhao caminhao3 = new Caminhao("rocket pocket", "Gol", "bolinha");

            // Criando instâncias de Aviao
            Aviao aviao1 = new Aviao("rocket pocket", "Gol", "bolinha");
            Aviao aviao2 = new Aviao("rocket pocket", "Gol", "bolinha");
            Aviao aviao3 = new Aviao("rocket pocket", "Gol", "bolinha");

            // Chamando os métodos andar(), abastecer() e voar() para alguns dos objetos
            Console.WriteLine("carro1: "); carro1.andar();
            Console.WriteLine("carro1: "); carro1.abastecer();
            Console.WriteLine("caminhao1: "); caminhao1.andar();
            Console.WriteLine("caminhao2: "); caminhao2.abastecer();
            Console.WriteLine("aviao1: "); aviao1.voar();
        }
    }
}
