using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    internal class AgendaTelefonica
    {
        private Dictionary<string, string> contatos = new Dictionary<string, string>();

        public void inserir(string nome, string numero)
        {
            contatos[nome] = numero;
        }

        public string buscarNumero(string nome)
        {
            if (contatos.ContainsKey(nome))
            {
                return contatos[nome];
            }
            else
            {
                return "Contato não existe";
            }
        }

        public void remover(string nome)
        {
            Console.WriteLine($"Contato de {nome} apagado");
            contatos.Remove(nome);
        }

        public int tamanho()
        {
            return contatos.Count;
        }
    }
}
