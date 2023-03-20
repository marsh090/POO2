using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPessoas
{
    public class GerenciadorPessoas
    {
        private Stack<Pessoa> pessoas = new Stack<Pessoa>();

        public void AdicionarPessoa(Pessoa pessoa)
        {
            pessoas.Push(pessoa);
        }

        public Pessoa RemoverUltimaPessoa()
        {
            return pessoas.Pop();
        }

        public bool Vazio()
        {
            return pessoas.Count == 0;
        }

        public void MostrarPessoas()
        {
            foreach(Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.Nome}");
            }
        }
    }

}
