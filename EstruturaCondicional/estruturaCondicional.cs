using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoTres
{
    class EstruturaCondicional
    {
        public static void ExecutarEstruturaCondicional()
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if(hora <18) 
            {
                Console.WriteLine("Boa Tarde");
            }
            else
            {
                Console.WriteLine("Boa Noite!");
            }
        }
    }
}