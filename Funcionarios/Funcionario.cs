using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        Funcionario(double salario, string cpf){
            CPF = cpf;
            Salario = salario;
            TotalFuncionarios++;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();


        public static int TotalFuncionarios { get; private set;}
    }
}
