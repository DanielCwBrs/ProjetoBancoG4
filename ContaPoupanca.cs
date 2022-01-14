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
        //Testando essa budega
        //public ContaPoupanca() { }

        //public ContaPoupanca(float taxaRendimento, DateTime data, decimal saldo)
        //{
        //    TaxaRendimento = taxaRendimento;
        //    DataAbertura = data;
        //    Saldo = saldo;
        //}

        public void AcrescentarRendimento()
        {
            decimal saldoNovo;
            TaxaRendimento = 0.05f;
            saldoNovo = Saldo + (Saldo * (decimal)TaxaRendimento);
            Console.WriteLine($"Saldo após primeiro mês de rendimento: {saldoNovo}");
        }

        public override void EscolherConta()
        {
            int op;
            do
            {
                Console.WriteLine("Selecione o tipo de conta do cliente:" +
                    "1 para corrente" +
                    "2 para poupança");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        //Console.WriteLine("Conta Corrente escolhida");
                        Transferir();
                        Depositar();
                        //ConsultaSaldo();
                        break;
                    case 2:
                        //Console.WriteLine("Conta Poupança escolhida");
                        Transferir();
                        Depositar();
                        //ConsultaSaldo();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (op != 1 && op != 2);
            Console.WriteLine("Cliente Cadastrado com sucesso!");

            Console.WriteLine("Sua conta é do tipo: Poupança");
        }

        public override void Criarconta(string numero, Cliente cliente)
        {

            Numero = numero; // essa conta tem que aparecer na tela do usuario
            Saldo = 0;
            Cliente = cliente;
            DateTime data = DateTime.Today;
        }

        public override void Transferir()
        {

            decimal saldoNovo;
            decimal valor;

            do
            {
                Console.WriteLine("Qual o valor do saque?");
                valor = decimal.Parse(Console.ReadLine());
                if (valor > 0)
                {


                    if (Saldo - valor < 0)
                    {
                        Console.WriteLine($"Saldo insuficiente, sua conta Poupança possui: R${Saldo}");

                    }
                    else
                    {
                        Saldo -= valor;
                        saldoNovo = Saldo;
                        AcrescentarRendimento();
                        //Console.WriteLine($"Saldo disponível da conta poupança após o saque: R${saldoNovo}");


                    }
                }
                else
                {
                    Console.WriteLine("Valor Invalido");
                }
            }while (valor <= 0);
        }

        public override void Depositar()
        {
            decimal saldoNovo;
            Console.WriteLine("Qual o valor do deposito para Conta Poupanca?");
            decimal valor = decimal.Parse(Console.ReadLine());
            if (valor > 0)
            {

                Saldo += valor;
                saldoNovo = Saldo;
                Console.WriteLine($"Saldo disponível na conta poupanca após o depósito: R$ {saldoNovo}");
            }
            else
            {
                Console.WriteLine("Valor Invalido");
            }
        }

        public override decimal ConsultaSaldo()
        {
            return Saldo;
        }
          
    }   

}

