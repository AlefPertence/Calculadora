using System;
using System.ComponentModel.Design;

using System.Net.NetworkInformation;

namespace CalculoDeMedia
{
    class Program
    {
        public static void Main(string[] args)
        {

            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double nota4 = 0;
            Console.WriteLine("Digite as notas para saber se está áprovado ou reprovado");
            Console.WriteLine("se sua nota for igual ou superior a 6 será considerado: APROVADO. Caso seja inferior a 6 será considerado: REPROVADO");
          
            Console.Write("digite sua 1° nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite sua 2° nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite sua 3° nota: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite sua 4° nota: ");
            nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 6 && media <= 10)
            {
                Console.WriteLine("Sua média é: {0} {1} ", media,". O aluno(a) está aprovado(a)");
                
            }
            
            else if(media <= 6 && media >= 0)
            {
                Console.WriteLine("Sua média é: {0} {1}", media,". O aluno(a) está reporivado(a)");
            }
            
            else
            {
                Console.WriteLine("Média incorreta.");
            }
        }
    }
}