using System;
using System.ComponentModel.Design;

namespace Calculadora
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int result = 0;
            char operacao;
            char resp1 = 'S';
            char resp2 = 's';
            char resposta;

            do
            {
                Console.WriteLine("Qual operação você deseja realizar?");
                Console.WriteLine("Operação (1): adição +");
                Console.WriteLine("Operação (2): subtração -");
                Console.WriteLine("Operação (3): multiplicação *");
                Console.WriteLine("Operação (4): divisão /");

                operacao = char.Parse(Console.ReadLine());
                switch (operacao)
                {
                    case '1':
                        Console.WriteLine("Digite o primeiro número");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("digite o seu segundo número");
                        num2 = int.Parse(Console.ReadLine());

                        result = num1 + num2;

                        break;

                    case '2':
                        Console.WriteLine("Digite o primeiro número");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("digite o seu segundo número");
                        num2 = int.Parse(Console.ReadLine());

                        result = num1 - num2;
                        break;

                    case '3':
                        Console.WriteLine("Digite o primeiro número");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("digite o seu segundo número");
                        num2 = int.Parse(Console.ReadLine());

                        result = num1 * num2;
                        break;

                    case '4':
                        Console.WriteLine("Digite o primeiro número");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("digite o seu segundo número");
                        num2 = int.Parse(Console.ReadLine());

                        result = num1 / num2;
                        break;

                    default:
                        Console.WriteLine("Essa opção não existe! ");

                        break;

                }

                Console.WriteLine("O resultado é: {0}", result);
               
                Console.WriteLine("Deseja continuar calculando? se SIM digite S,caso contrário aperte qualquer tecla para encerrar.");
                resposta = Console.ReadKey().KeyChar;
                resp1 = resposta;
                resp2 = resposta;



            } while (resposta == 's' || resposta == 'S');

            


        }
    }
}