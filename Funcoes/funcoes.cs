using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoTres
{
    class Funcoes
    {
        public static void ExecutarFuncao(){
           
            Console.WriteLine("Digite 3 números: ");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("O maior é: " + resultado);
        }


        static double Maior(double a, double b, double c)
        {
            double maior;

            if(a > b && a > c )
            {
                maior = a;
            }
            else if(b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }
            return maior;
        }
    }
}