using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    // Declaração da classe "Veiculo"
    internal class Veiculo
    {
        // Propriedades públicas para armazenar a marca e o modelo do veículo
        public string marca { get; set; }
        public string modelo { get; set; }

        // Método público que simula o abastecimento do veículo e retorna um valor booleano indicando se foi abastecido com sucesso ou não
        public bool abastecer()
        {
            Console.WriteLine("Abasteceu\n"); // Imprime a mensagem "Abasteceu" no console
            return true; // Retorna "true" indicando que o abastecimento foi realizado com sucesso
        }
    }
}
