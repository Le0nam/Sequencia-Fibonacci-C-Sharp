using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorFinal;
            do 
            {
                int iniciaZero = 0, iniciaUm = 1, procimoValor = 0, valorDigitado;
                List<int> valores = new List<int>();
                Console.WriteLine("Digite o valor: \n");
                valorDigitado = Convert.ToInt32(Console.ReadLine());

                do
                {
                    procimoValor = iniciaZero + iniciaUm;
                    iniciaZero = iniciaUm;
                    iniciaUm = procimoValor;
                    valores.Add(procimoValor);
                } while (procimoValor < valorDigitado);

                if (valores.Contains(valorDigitado))
                {
                    Console.WriteLine("\nvalor pertence a sequencia de Fibonacci\n");
                }
                else
                {
                    Console.WriteLine("\nvalor não pertence a sequencia de Fibonacci\n");
                }
                Console.WriteLine("\nDigite 0 para fechar:\n");
                valorFinal = Convert.ToInt32(Console.ReadLine());
            } while (valorFinal != 0);
        }
    }
}
