using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio07
{
    public class ContaCorrente : ContaBancaria
    {
        public void realizarDeposito(double deposito){
            this.saldo += deposito;
        }

        public void realizarSaque(double saque){
            this.saldo -= saque;
        }
    }
}