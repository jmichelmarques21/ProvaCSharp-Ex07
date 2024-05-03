using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio07
{
    public class ContaPoupanca : ContaBancaria
    {
        public void acrescerJuros(double juros){
            this.saldo += this.saldo * juros;
        }
    }
}