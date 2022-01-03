using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco_G4
{
    abstract class Conta
    {
        public string Numero { get; protected set; } //get, valor de retorno / set, valor de entrada
        public decimal Saldo { get; protected set; } //lembrar de alterar para private "Testando"
        public Cliente Cliente { get; protected set; }
        public DateTime DataAbertura { get; set; }
        public decimal ValorDepositado { get; set; }
        //private int TipoDeConta { get; set; }

        //enum TiposDeConta { contaCorrente = 1, contaPouPança = 2 }



        public Conta() { } //primeiro informamos ao nosso programa que utilizaremos uma classe sem parametros, ou seja, o construtor () é do tipo vazio,
                           //ele não recebe nada
        public Conta(string numero, decimal saldo, Cliente cliente, DateTime dataAbertura, decimal valor) //todas as minhas variaveis que utilizarei na minha classe "conta" ja recebem parametros,
                                                                                     //esses parametros devem ser suas propriedades (Numero, Saldo, Cliente) que foram inseridas
                                                                                     //em get-set, para que depois você as converta em tipos de variaveis, o
        {
            this.Cliente = cliente;
            this.Saldo = saldo;
            this.Numero = numero;
            this.DataAbertura = dataAbertura;
            ValorDepositado = valor;
            // this.TipoDeConta = tipodeconta;
        }


        public virtual void Transferir()
        {

            Console.WriteLine("Qual o valor do saque?");
            decimal valor = decimal.Parse(Console.ReadLine());

            do
            {
                if (valor > 0)
                {


                    if (Saldo - valor < 0)
                    {
                        Console.WriteLine($"Saldo insuficiente, sua conta possui: R${Saldo}");

                    }
                    else
                    {
                        Saldo -= valor;
                        Console.WriteLine($"Saldo disponível da conta após o saque: R${Saldo}");


                    }
                }
                else
                {
                    Console.WriteLine("Valor Invalido");
                }
            }while (valor <= 0);
        }

        public virtual void Depositar()
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

        public virtual void Criarconta(string numero, Cliente cliente)
        {
            DateTime data = DateTime.Today;
        }

        public abstract decimal ConsultaSaldo();

        public virtual void EscolherConta()
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
                        break;
                    case 2:
                        Console.WriteLine("Conta Poupança escolhida");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (op != 1 && op != 2);
            Console.WriteLine("Cliente Cadastrado com sucesso!");
        }




       
        

        
        

        //public abstract void Saca(decimal saldo);
        
        //public abstract void Operacoes(double saldo);
    }
}
