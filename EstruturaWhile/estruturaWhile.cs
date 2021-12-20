using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoTres
{
    class EstruturaWhile
    {
        public static void ExecutarEstruturaWhile()
        {


            Console.Write("Digite um número: ");
            double numeroDigitado = double.Parse(Console.ReadLine());

            while (numeroDigitado >= 0.0)
            {
                double raizQuadrada = Math.Sqrt(numeroDigitado);
                Console.WriteLine("O número digitado foi: " + raizQuadrada.ToString("F3"));
                Console.Write("Digite outro número: ");
                numeroDigitado = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Número negativo!");
        }

        public static void ExecutarExercicioSenha()
        {
            Console.Write("Digite a senha válida: ");
            double senhaCorreta = double.Parse(Console.ReadLine());

            while (senhaCorreta != 2002)
            {
                Console.WriteLine("Senha inválida!Digite a senha correta: ");
                senhaCorreta = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("Acesso permitido!");
        }

        public static void ExecutarExercicioCartesiano()
        {
            Console.WriteLine("Digite a coordenada x: ");
            double coordX = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a coordenada Y: ");
            double coordY = double.Parse(Console.ReadLine());

            while (coordX != 0 && coordY != 0)
            {
                
                if (coordX > 0 && coordY > 0)
                {
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if (coordX > 0 && coordY < 0)
                {
                    Console.WriteLine("Quarto Quadrante");
                }
                else if (coordX < 0 && coordY < 0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else if (coordX < 0 && coordY > 0)
                {
                    Console.WriteLine("Segundo Quadrante");
                } 

                Console.WriteLine("Digite a coordenada x: ");
                coordX = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a coordenada Y: ");
                coordY = double.Parse(Console.ReadLine());             
            }

            Console.WriteLine("Acesso Negado");
        }
    }
}