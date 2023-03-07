using System;

namespace ContaBancaria
{
    class Program
    {
        public static void Main(string[] args)
        {
        Contas conta = new Contas();

        Console.WriteLine("Bem vindo à conta bancaria legal\nqual seu cpf?");
        conta.cpf = Console.ReadLine();
        Console.Clear();
        
        Console.WriteLine("Qual seu nome?");
        conta.nome = Console.ReadLine();
        Console.Clear();
        
        Console.WriteLine("Qual seu saldo inicial?");
        conta.saldo = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        
        Boolean sair = false;
        while (sair == false)
        {
          
            Console.WriteLine("Digite o numero da ação que deseja realizar\nsaque(1)\ndeposito(2)\nextrato(3)?");
            int metodo = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            double valor;
            switch (metodo)
            {
                case 1:
                        Console.WriteLine("Valor a sacar: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        if(valor > conta.saldo){
                            Console.WriteLine("Saldo insuficiente!");
                        }else{
                        conta.extrato += $"Saque: {conta.saldo} - {valor} = {conta.saldo - valor}\n";
                        conta.sacar(valor);
                        Console.WriteLine($"Foi realizado um saque de R${valor}\nNovo saldo de R${conta.saldo}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Valor a depositar: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        conta.extrato += $"Deposito: {conta.saldo} + {valor} = {conta.saldo + valor}\n";
                        conta.depositar(valor);
                        Console.WriteLine($"Foi realizado um deposito de R${valor}\nNovo saldo de R${conta.saldo}");
                        break;
                    case 3:
                        Console.WriteLine($"Extrato:");
                        Console.WriteLine($"{conta.extrato}");
                        break;
                    default:
                        Console.WriteLine("Input Errado");
                        break;
            }

            Console.WriteLine("Deseja realizar outra operação? (sim - 1 | não - 0)");
            int querSair = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            if (querSair == 0){
              sair = true;
              break;
            }

          
        }
    }
}
    
}
