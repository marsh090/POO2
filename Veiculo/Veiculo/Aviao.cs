using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    // Declaração de uma classe chamada "Aviao" que herda da classe "Veiculo" e implementa a interface "VeiculoAereo"
    internal class Aviao : Veiculo, VeiculoAereo
    {
        // Propriedade pública para armazenar a companhia aérea do avião
        public String companhia { get; set; }

        // Construtor da classe "Aviao" que recebe três parâmetros para inicializar as propriedades da classe
        public Aviao(string companhia, string marca, string modelo)
        {
            this.companhia = companhia; // Inicializa a propriedade "companhia" com o valor recebido como parâmetro
            base.marca = marca; // Acessa a propriedade "marca" da classe "Veiculo" e a inicializa com o valor recebido como parâmetro
            base.modelo = modelo; // Acessa a propriedade "modelo" da classe "Veiculo" e a inicializa com o valor recebido como parâmetro
        }

        // Implementação do método "voar" da interface "VeiculoAereo"
        public bool voar()
        {
            Console.WriteLine("Aviao Voar\n");
            return true;
        }
    }

}
