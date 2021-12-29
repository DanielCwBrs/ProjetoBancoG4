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

        public void DescontarTaxa()
        {
            this.Saldo = (Saldo - 0.10m);
            Console.WriteLine($"Saldo mais taxa de manutenção mensal: {this.Saldo}");
        }
        public override void Saca(decimal saldo)
        {
            this.Saldo = saldo;

            DescontarTaxa();
        }




        //public void DescontarTaxa(decimal saldo)
        //{
        //    TaxaManutencao = 0.10m;
        //    this.TaxaManutencao = saldo - TaxaManutencao;
        //    Console.WriteLine($"O valor do saldo após taxa de manutenção ficou: {this.TaxaManutencao}");
        //}
        //public override void Saca(decimal saldo)
        //{
           
        //}


        //public override void DescontarTaxa(ContaCorrente contaCorrente)
        //{
        //    this.TaxaManutencao(ContaCorrente - taxaManutencao);

        //}
    }
}