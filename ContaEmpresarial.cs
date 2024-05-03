using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio07
{
    public class ContaEmpresarial : ContaBancaria
    {
        public void calculaSaldoMinimo(){
            if (this.saldo < 10000) {
                System.Console.WriteLine("Saldo abaixo do mínimo, contate o seu gerente!");
            } else {
                System.Console.WriteLine("Valor dentro do intervalo.");
            }
        }
    }
}