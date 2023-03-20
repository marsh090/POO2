namespace StackPessoas
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
    }
}