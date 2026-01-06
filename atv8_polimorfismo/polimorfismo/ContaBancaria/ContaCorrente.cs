using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo.ContaBancaria
{
    public class ContaCorrente : ContaBancaria
    {
        public decimal LimiteChequeEspecial { get; set; }

        public ContaCorrente(string numeroDaConta, string titular, decimal saldoInicial, decimal limiteChequeEspecial)
            : base(numeroDaConta, titular, saldoInicial)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
        }

        public override void Sacar(decimal valor)
        {
            if (Saldo + LimiteChequeEspecial >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso na conta {NumeroDaConta}.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente e limite de cheque especial excedido.");
            }
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado com sucesso na conta {NumeroDaConta}.");
        }
    }
}
