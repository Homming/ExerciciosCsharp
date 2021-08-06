using System;
namespace Primeiro_Projeto {
    class Program {
        static void Main(string[] args) {
            string frase = Console.ReadLine();

            Console.WriteLine(frase);

            string[] vetor = Console.ReadLine().Split(' ');

            Console.WriteLine(vetor[0]);
            Console.WriteLine(vetor[1]);
            Console.WriteLine(vetor[2]);
        }
    }
}
