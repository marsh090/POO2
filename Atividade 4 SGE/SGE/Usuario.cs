using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE
{
    public class Usuario
    {
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool Habilitado { get; set; }

        public Usuario(string login, string nome, string senha, bool habilitado)
        {
            Login = login;
            Nome = nome;
            Senha = senha;
            Habilitado = habilitado;
        }
    }
}
