using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco_G4
{
    class ContaPoupanca : Conta
    {
        private decimal TaxaRendimento { get; set; }

        public ContaPoupanca(Cliente cliente) : base(cliente, "454545")
        {
            TipoConta = "Poupança";
            TaxaRendimento = 0.05m;
            TaxaRendimento = Saldo + (Saldo * (decimal)TaxaRendimento);
        }

        public override void Transferir()
        {
            Console.WriteLine("Insira o valor desejado: ");
            decimal valor = decimal.Parse(Console.ReadLine());
            if (Saldo < valor + TaxaRendimento)
            {
                Console.WriteLine($"Você não tem saldo suficiente para essa transferência!\nSaldo: R${Saldo}");
            }
            else
            {
                Saldo -= valor + TaxaRendimento;
                base.ClassificarCliente();
                Console.WriteLine($"Você transferiu dinheiro da conta poupança!\nSaldo após o depósito: R${Saldo}");
            }
        }

        public override void Depositar()
        {
            Console.WriteLine("Insira o valor desejado: ");
            decimal valor = decimal.Parse(Console.ReadLine());
            Saldo += valor + TaxaRendimento;
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

