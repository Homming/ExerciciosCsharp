using System;

namespace Exercicio_2_Orientação_a_Objeto {
    class Funcionario {
        public string nome;
        public double salarioBruto;
        public double imposto;

        public double salarioLiquido() {
            return salarioBruto - imposto;
        }

        public void aumentarSalario(double porcentagem) {
            salarioBruto += salarioBruto * (porcentagem / 100);
        }
    }
}
