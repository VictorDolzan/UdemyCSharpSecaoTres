using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoTres.exercicioCinco
{
    class ExercicioCinco
    {
        public static void ExecutarExercicioCinco()
        {
            Funcionario Victor = new Funcionario();

            Console.WriteLine("Digite o id do funcionário: ");
            Victor.IdFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite as horas trabalhadas: ");
            Victor.HorasTrabalhadas = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o salário por hora: ");
            Victor.SalarioPorHora = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"O salário do funcionário {Victor.IdFuncionario} é: {Victor.CalculaSalario()}");
        }

        public static void ExecutarExercicioSeis()
        {
            //double resultado1;
            Pecas peca1 = new Pecas();
            Pecas peca2 = new Pecas();

            peca1.CodigoPeca = 12;
            peca1.NumeroPecas = 10;
            peca1.ValorUnitario = 5.50;
            peca1.CalculaValorAPagar();

            peca2.CodigoPeca = 10;
            peca2.NumeroPecas = 5;
            peca2.ValorUnitario = 2;
            

            Console.WriteLine($"O valor total a ser pago é: {peca1.ValorAPagar + peca2.ValorAPagar}");

            
        }
    }
}