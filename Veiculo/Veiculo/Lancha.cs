using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    // Declaração de uma classe chamada "Lancha" que herda da classe "Veiculo"
    internal class Lancha : Veiculo
    {
        // Propriedade pública para armazenar o tamanho da lancha
        public int tamanho { get; set; }

        // Construtor da classe "Lancha" que recebe três parâmetros para inicializar as propriedades da classe
        public Lancha(int tamanho, string marca, string modelo)
        {
            this.tamanho = tamanho; // Inicializa a propriedade "tamanho" com o valor recebido como parâmetro
            base.marca = marca; // Acessa a propriedade "marca" da classe "Veiculo" e a inicializa com o valor recebido como parâmetro
            base.modelo = modelo; // Acessa a propriedade "modelo" da classe "Veiculo" e a inicializa com o valor recebido como parâmetro
        }
    }

}
