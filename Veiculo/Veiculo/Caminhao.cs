using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    // Declaração de uma classe chamada "Caminhao" que herda da classe "Veiculo" e implementa a interface "VeiculoTerrestre"
    internal class Caminhao : Veiculo, VeiculoTerrestre
    {
        // Propriedade pública para armazenar o seguimento do caminhão
        public String seguimento { get; set; }

        // Construtor da classe "Caminhao" que recebe três parâmetros para inicializar as propriedades da classe
        public Caminhao(string seguimento, string marca, string modelo)
        {
            this.seguimento = seguimento; // Inicializa a propriedade "seguimento" com o valor recebido como parâmetro
            base.marca = marca; // Acessa a propriedade "marca" da classe "Veiculo" e a inicializa com o valor recebido como parâmetro
            base.modelo = modelo; // Acessa a propriedade "modelo" da classe "Veiculo" e a inicializa com o valor recebido como parâmetro
        }

        // Implementação do método "andar" da interface "VeiculoTerrestre"
        public bool andar()
        {
            Console.WriteLine("Caminhao Andar\n");
            return true;
        }
    }

}
