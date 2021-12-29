using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco_G4
{
    class ContaPoupanca : Conta
    {
        private float TaxaRendimento { get; set; }


        public ContaPoupanca() { }

        public ContaPoupanca(float taxaRendimento)
        {
            this.TaxaRendimento = taxaRendimento;
        }

        public void AcrescentarRendimento(decimal Saldo);
        {
            this.Saldo = (Saldo + 0.10m);
            //Console.WriteLine($"Saldo mais rendimento mensal: {this.Saldo}");
        }
        public override void Saca(decimal saldo)
        {
            this.Saldo = saldo;

            AcrescentarRendimento();
        }
        
    }
}
