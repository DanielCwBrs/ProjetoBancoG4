using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco_G4
{
    class ContaCorrente : Conta
    {
        private decimal TaxaManutencao;

        public ContaCorrente(){}

        public ContaCorrente(decimal taxaManutencao)
        {
            this.TaxaManutencao = taxaManutencao;
        }
        public void DescontarTaxa(double saldo)
        {
            this.Saldo -= (saldo - 0.10);
        }
        public override void Saca(double saldo)
        {
           
        }


        //public override void DescontarTaxa(ContaCorrente contaCorrente)
        //{
        //    this.TaxaManutencao(ContaCorrente - taxaManutencao);

        //}
    }
}