using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco_G4
{
    class Conta
    {
        private string Numero { get; set; }
        private double Saldo { get; set; }
        private Cliente cliente { get; set; }

        public Conta() { }
        public Conta(string numero, double saldo, Cliente cliente)
        {
            this.cliente = cliente;
            this.Saldo = saldo;
            this.Numero = numero;
        }

        public void Transferir(Conta conta)
        {

            Console.WriteLine("Qual o valor do saque?");
            double valor = double.Parse(Console.ReadLine());
            if (valor > 0)
            {


                if (conta.Saldo - valor < 0)
                {
                    Console.WriteLine("Saldo insuficiente");

                }
                else
                {
                    conta.Saldo -= valor;
                    Console.WriteLine("Saldo disponível após o saque: R$ " + conta.Saldo);


                }
            }
            else
            {
                Console.WriteLine("Valor Invalido");
            }
        }
        public void criarConta(Conta conta, Cliente cliente)
        {
            Console.WriteLine("Digite o número da conta:");
            conta.Numero = Console.ReadLine();
            conta.Saldo = 0;
            conta.cliente = cliente;

        }

        public void Depositar(Conta conta)
        {

            Console.WriteLine("Qual o valor do deposito?");
            double valor = double.Parse(Console.ReadLine());
            if (valor > 0)
            {
            
                    conta.Saldo += valor;
                    Console.WriteLine("Saldo disponível após o depósito: R$ " + conta.Saldo);
            }
            else
            {
                Console.WriteLine("Valor Invalido");
            }
        }

        public double ConsultaSaldo(Conta conta)
        {
            return conta.Saldo;
        }
    }
}
