using polimorfismo.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo.ContaBancaria
{
    class ProgramConta
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente("12345", "João da Silva", 1000, 500);
            ContaPoupanca contaPoupanca = new ContaPoupanca("54321", "Maria dos Santos", 2000, 300);

            //Tem q add os tipos de contas na lista
            List<ContaBancaria> contas = new List<ContaBancaria>
            {
                contaCorrente,
                contaPoupanca
            };

            //Teste de métodos
            contaCorrente.Depositar(200);
            contaPoupanca.AplicarRendimento();
            contaPoupanca.Sacar(500);

            foreach (var conta in contas)
            {
                conta.ExibirSaldo();
            }
        }
    }
}