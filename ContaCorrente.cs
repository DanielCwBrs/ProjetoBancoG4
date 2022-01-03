using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco_G4
{
    class ContaCorrente : Conta
    {
        private decimal TaxaManutencao { get; set; }

        //public ContaCorrente(){}

        //public ContaCorrente(decimal taxaManutencao, DateTime data)
        //{
        //    this.TaxaManutencao = taxaManutencao;
        //    DataAbertura = data;
        //}
       
        public void DescontarTaxa()
        {
            decimal saldoNovo;
            TaxaManutencao = 25.99m;
            saldoNovo = (Saldo - TaxaManutencao);
            Console.WriteLine($"Saldo após manutenção no valor de R$25.99: R${saldoNovo}");
        }

        public override void EscolherConta()
        {
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
                            Console.WriteLine("Conta Corrente escolhida");
                            Transferir();
                            Depositar();
                            //ConsultaSaldo();
                            break;
                        case 2:
                            Console.WriteLine("Conta Poupança escolhida");
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

                Console.WriteLine("Sua conta é do tipo: Corrente");
            }
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
                        DescontarTaxa();
                        //Console.WriteLine($"Saldo disponível da conta poupança após o saque: R${Saldo}");


                    }
                }
                else
                {
                    Console.WriteLine("Valor Invalido");
                }
            } while (valor <= 0);
        }

        public override void Depositar()
        {

            Console.WriteLine("Qual o valor do deposito para Conta Corrente?");
            decimal valor = decimal.Parse(Console.ReadLine());
            if (valor > 0)
            {

                Saldo += valor;
                Console.WriteLine($"Saldo disponível na conta corrente após o depósito: R$ {Saldo}");
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