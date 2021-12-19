using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoTres
{
    class EntradaDeDados
    {
        public static void ExecutarEntradaDeDados()
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            

            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            
        }
        public static void ExecutarEntradaDeDadosDois()
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string [] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3]);

            Console.WriteLine($"Você digitou: {n1}");
            Console.WriteLine($"O caractere digitado foi: {ch}");
            Console.WriteLine($"O número digitado foi: {n2}");
            Console.WriteLine($"O nome no vetor é:{nome}");
            Console.WriteLine($"O sexo no vetor é:{sexo}");
            Console.WriteLine($"A idade no vetor é:{idade}");
            Console.WriteLine($"A altura no vetor é:{altura}");
        }

        public static void ExecutarExercicioEntradaDeDados()
        {
            string nomeUsuario;
            int quantidadeQuartos;
            double precoProduto;
            
            string[] vetorExercicio;


            Console.WriteLine("Entre com seu nome completo: ");
            nomeUsuario = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa? ");
            quantidadeQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto: ");
            precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            vetorExercicio = Console.ReadLine().Split(' ');
            string ultimoNome = vetorExercicio[0];
            int idade = int.Parse(vetorExercicio[1]);
            double altura = double.Parse(vetorExercicio[2]);

            Console.WriteLine("Exercício solucionado:");
            Console.WriteLine(nomeUsuario);
            Console.WriteLine(quantidadeQuartos);
            Console.WriteLine(precoProduto.ToString("F2"));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));
        }
    }
}