using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoTres
{
    class SaidaDeDados
    {
        public static void ExecutarSaidaDeDados()
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
            Console.WriteLine("Produtos:");
            Console.WriteLine("{0} cujo preço é ${1:F2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preco é ${1:F2}", produto2, preco2);
            Console.WriteLine();
            Console.WriteLine($"Registro:{idade} anos de idade, cujo código {codigo} e genero: {genero}");
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas casas decimais:{0}", medida.ToString("F8", CultureInfo.InvariantCulture));
            Console.WriteLine("Arrendondado(três casas decmais):{0}", medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture:{0}", medida.ToString("F3", CultureInfo.InstalledUICulture));

        }
    }
}