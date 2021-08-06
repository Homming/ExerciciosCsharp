using System;
using System.Globalization;
namespace Primeiro_Projeto {
    class Program {
        static void Main(string[] args) {
            // Entradas
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa ?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de algo que comprou recentemente:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] vetor = Console.ReadLine().Split(' ');

            // Saídas

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(valor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vetor[0]);
            Console.WriteLine(int.Parse(vetor[1]));
            Console.WriteLine(double.Parse(vetor[2], CultureInfo.InvariantCulture).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
