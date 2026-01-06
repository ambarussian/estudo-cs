using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo.ContaBancaria
{
    /*Crie uma aplicação que gerencie diferentes tipos de contas bancárias (ContaCorrente, ContaPoupanca),
     * utilizando uma classe base ContaBancaria e classes específicas para cada tipo de conta.*/

    public abstract class ContaBancaria(string numeroDaConta, string titular, decimal saldo)
    {
            public string NumeroDaConta { get; set; } = numeroDaConta;
            public string Titular { get; set; } = titular;
            public decimal Saldo { get; set; } = saldo;

            //Métodos
            public abstract void Sacar(decimal valor);
            public abstract void Depositar(decimal valor);

            public virtual void ExibirSaldo()
            {
                Console.WriteLine($"O saldo atual da conta {NumeroDaConta} é {Saldo}");
            }
    }

}
