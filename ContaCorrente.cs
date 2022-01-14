using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco_G4
{
    class ContaCorrente : Conta
    {
        public decimal TaxaManutencao { get; set; }

        public ContaCorrente(Cliente cliente) : base(cliente, "12345")
        {
            TipoConta = "Corrente";
            TaxaManutencao = 1.50m;
        }

        public override void Transferir()
        {
            Console.WriteLine("Insira o valor desejado: ");
            decimal valor = decimal.Parse(Console.ReadLine());
            if (Saldo < valor + TaxaManutencao)
            {
                Console.WriteLine($"Você não tem saldo suficiente para essa transferência!\nSaldo: R${Saldo}");
            }
            else
            {
                Saldo -= valor + TaxaManutencao;
                base.ClassificarCliente();
                Console.WriteLine($"Você transferiu dinheiro da conta corrente!\nSaldo após o depósito: R${Saldo}");
            }
        }

        public override void Depositar()
        {
            Console.WriteLine("Insira o valor desejado: ");
            decimal valor = decimal.Parse(Console.ReadLine());
            Saldo += valor - TaxaManutencao;
            ClassificarCliente();
            Console.WriteLine($"Você depositou dinheiro na conta poupança!\nSaldo após depósito: R${Saldo}");
        }

        public override void ConsultarSaldo()
        {
            Console.WriteLine($"Esta conta pertence a : {Cliente.Nome} - CPF: {Cliente.Cpf}");
            Console.WriteLine($"Número da conta poupança: {Numero}");
            Console.WriteLine($"O saldo atual da conta poupança é de R$ {Saldo}");
            Console.WriteLine($"O cliente é do tipo {Cliente.Tipo}");
        }
    }

}
