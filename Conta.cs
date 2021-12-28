using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco_G4
{
    abstract class Conta
    {
        private string Numero { get; set; } //get, valor de retorno / set, valor de entrada
        public double Saldo { get; protected set; } //lembrar de alterar para private "Testando"
        private Cliente Cliente { get; set; }

        //enum TiposDeConta { contaCorrente = 1, contaPouPança = 2 }



        public Conta() { } //primeiro informamos ao nosso programa que utilizaremos uma classe sem parametros, ou seja, o construtor () é do tipo vazio,
                           //ele não recebe nada
        public Conta(string numero, double saldo, Cliente cliente) //todas as minhas variaveis que utilizarei na minha classe "conta" ja recebem parametros,
                                                                   //esses parametros devem ser suas propriedades (Numero, Saldo, Cliente) que foram inseridas
                                                                   //em get-set, para que depois você as converta em tipos de variaveis, o
        {
            this.Cliente = cliente;
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
        public void criarconta(Conta conta, Cliente cliente)
        {
            Console.WriteLine("Número da conta: 123456"); //essa conta tem que aparecer na tela do usuario
            //conta.Numero = Console.ReadLine();
            conta.Saldo = 0;
            conta.Cliente = cliente;

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

        public abstract void Saca(double saldo);
        
        //public abstract void Operacoes(double saldo);
    }
}
