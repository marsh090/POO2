/******************************************************************************

Classe que vai receber dois parametros e retorna um resultado.
Calculadora.
Cada operação vai ser um metodo na calculadora.
Fazer um menu onde o usuario esolhe qual metodo vai ser chamado.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      int sair = 1;
      while(sair == 1){
          Console.WriteLine("Bem vindo à calculadora legal\nqual o primeiro numero?");
            double input1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Agora escolhe uma operação (+ - * /)");
            string simbolo = Console.ReadLine();
            
            Console.WriteLine("E agora o ultimo numero");
            double input2 = Convert.ToDouble(Console.ReadLine());
            
            Calculadora conta = new Calculadora();
            double res;
            switch (simbolo)
                        {
                            case "+":
                                res = conta.soma(input1, input2);
                                Console.WriteLine($"Soma: {res}");
                                break;
                            case "-":
                                res = conta.subt(input1, input2);
                                Console.WriteLine($"Subtração: {res}");
                                break;
                            case "*":
                                res = conta.mult(input1, input2);
                                Console.WriteLine($"Multiplicação: {res}");
                                break;
                            case "/":
                                res = conta.divi(input1, input2);
                                Console.WriteLine($"Divisão: {res}");
                                break;
                            default:
                                Console.WriteLine("Input Errado");
                                break;
                        }
                        
                    Console.WriteLine("Deseja realizar outra conta? (sim - 1 | não - 0)");
                    sair = Convert.ToInt32(Console.ReadLine());
                    
                    if(sair == 0){
                        break;
                     }
      }
    
  }
}