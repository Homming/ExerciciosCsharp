using System;

namespace Exercicio_2_Orientação_a_Objeto {
    class Program {
        static void Main(string[] args) {
            Funcionario fulano = new Funcionario();

            Console.WriteLine("Digite o nome do Funcionário");
            fulano.nome = Console.ReadLine();

            Console.WriteLine("Digite o Salario do Funcionário");
            fulano.salarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o imposto a ser taxado do Funcionário");
            fulano.imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário: {fulano.nome}, {fulano.salarioLiquido()}");

            Console.Write("Digite a porcentagem para aumentar sálario: ");
            double porcentagem = double.Parse(Console.ReadLine());

            Console.WriteLine($"Dados atualizados: {fulano.nome}, {fulano.salarioLiquido()}");
        }
    }
}
