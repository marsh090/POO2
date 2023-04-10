using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    // Declaração de uma classe chamada "Carro" que herda da classe "Veiculo" e implementa a interface "VeiculoTerrestre"
    internal class Carro : Veiculo, VeiculoTerrestre
    {
        // Propriedade pública para armazenar o tipo de carro
        public string tipo { get; set; }

        // Construtor da classe "Carro" que recebe três parâmetros para inicializar as propriedades da classe
        public Carro(string tipo, string marca, string modelo)
        {
            this.tipo = tipo; // Inicializa a propriedade "tipo" com o valor recebido como parâmetro
            base.marca = marca; // Acessa a propriedade "marca" da classe "Veiculo" e a inicializa com o valor recebido como parâmetro
            base.modelo = modelo; // Acessa a propriedade "modelo" da classe "Veiculo" e a inicializa com o valor recebido como parâmetro
        }

        // Implementação do método "andar" da interface "VeiculoTerrestre"
        public bool andar()
        {
            Console.WriteLine("Carro Andar\n"); // Imprime a mensagem "Carro Andar" no console
            return true; // Retorna "true" indicando que o carro conseguiu andar
        }
    }

}
