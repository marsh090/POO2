using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }

        public Produto(int id, string nome, string descricao, int quantidade)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Quantidade = quantidade;
        }
    }

}
