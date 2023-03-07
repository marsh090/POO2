namespace ContaBancaria
{
    class Contas
    {
        public string nome;
        public string extrato;
        public string cpf;
        public double saldo;

        public double sacar(double a)
        {
            return this.saldo = this.saldo - a;
        }
        public double depositar(double a)
        {
            return this.saldo = this.saldo + a;
        }
    }
}
