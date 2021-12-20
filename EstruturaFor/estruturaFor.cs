using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoTres
{
    class EstruturaFor
    {
        public static void ExecutarEstruturaFor()
        {
            Console.Write("Quantos número inteiros você vai digitar? ");
            int totalNumerosInteiros = int.Parse(Console.ReadLine());
            
            int soma = 0;
            for(int contador = 1 ; contador <= totalNumerosInteiros; contador++)
            {
                Console.Write($"Digite o valor #{contador}: ");
                soma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"O valor da soma é: {soma}");
        }

        public static void ExecutarMostarNumerosImpares()
        {
            Console.Write("Digite um número inteiro: ");
            int numeroInteiro = int.Parse(Console.ReadLine());

            for( int contador = 0; contador <= numeroInteiro; contador++)
            {
                int resto = contador % 2;
                if(resto != 0 )
                {
                    Console.WriteLine($"Saída ímpar é: {contador}");
                }                
            }
        }

        public static void ExecutarExercicioForIntervalo()
        {
            Console.WriteLine("Digite um valor inteiro: ");
            int valorInteiro = int.Parse(Console.ReadLine());

            int contadorIn = 0;
            int contadorOut = 0;
            for(int contador = 0; contador < valorInteiro; contador++)
            {
                
                Console.WriteLine("Digite um número: ");
                int numeroInterno = int.Parse(Console.ReadLine());

                if(numeroInterno >= 10 && numeroInterno <= 20)
                {
                    contadorIn++;
                }
                else{
                
                    contadorOut++;
                }
            }
            Console.WriteLine($"Quantidades IN: {contadorIn}");
            Console.WriteLine($"Quantidades OUT: {contadorOut}");
        }
        public static void ExecutarExercicioFatorial()
        {
            Console.WriteLine("Digite um número: ");
            int numeroPrincipal = int.Parse(Console.ReadLine());
            
            int fatorial = 1;
            for(int contador =1; contador <= numeroPrincipal; contador ++)
            {
                fatorial *= contador;
            }

            Console.WriteLine($"O fatorial é: {fatorial}");
        }
    }
}