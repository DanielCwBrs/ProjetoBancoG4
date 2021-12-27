using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco_G4
{
    class conta
    {
        private string Numero { get; set; } //get, valor de retorno / set, valor de entrada
        private double Saldo { get; set; }
        private Cliente Cliente { get; set; }

        public conta() { } //primeiro informamos ao nosso programa que utilizaremos uma classe sem parametros, ou seja, o construtor () é do tipo vazio,
                           //ele não recebe nada
        public conta(string numero, double saldo, Cliente cliente) //todas as minhas variaveis que utilizarei na minha classe "conta" ja recebem parametros,
                                                                   //esses parametros devem ser suas propriedades (Numero, Saldo, Cliente) que foram inseridas
                                                                   //em get-set, para que depois você as converta em tipos de variaveis, o
        {
            this.Cliente = cliente;
            this.Saldo = saldo;
            this.Numero = numero;
        }

        public void Transferir(conta conta)
        {

            Console.WriteLine("Qual o valor do saque?");
            double valor = double.Parse(Console.ReadLine());
            if (valor > 0)
            {


                if (conta.Saldo - valor < 0)
                {
                    Console.WriteLine($"Saldo insuficiente, sua conta possui: {conta.Saldo}R$");

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
        public void criarconta(conta conta, Cliente cliente)
        {
            Console.WriteLine("Número da conta: 123456"); //essa conta tem que aparecer na tela do usuario
            //conta.Numero = Console.ReadLine();
            conta.Saldo = 0;
            conta.Cliente = cliente;

        }

        public void Depositar(conta conta)
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

        public double ConsultaSaldo(conta conta)
        {
            return conta.Saldo;
        }
    }
}
