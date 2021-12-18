using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoTres
{
    class ConversaoImplicita
    {
        public static void ExecutarConversaoImplicita()
        {
            float x = 4.5f;
            double y = x;
            double a;
            int b;

            int c = 5;
            int d = 2;

            Console.WriteLine(y);

            a = 5.1;
            b = (int)a;

            Console.WriteLine(b);

            double resultado = (double) c / d;

            Console.WriteLine(resultado);

        }
    }
}