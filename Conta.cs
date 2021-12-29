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
        public decimal Saldo { get; protected set; } //lembrar de alterar para private "Testando"
        private Cliente Cliente { get; set; }
        private int TipoDeConta { get; set; }

        Conta conta = new Conta();
        //enum TiposDeConta { contaCorrente = 1, contaPouPança = 2 }



        public Conta() { } //primeiro informamos ao nosso programa que utilizaremos uma classe sem parametros, ou seja, o construtor () é do tipo vazio,
                           //ele não recebe nada
        public Conta(string numero, decimal saldo, Cliente cliente, int tipodeconta) //todas as minhas variaveis que utilizarei na minha classe "conta" ja recebem parametros,
                                                                                     //esses parametros devem ser suas propriedades (Numero, Saldo, Cliente) que foram inseridas
                                                                                     //em get-set, para que depois você as converta em tipos de variaveis, o
        {
            this.Cliente = cliente;
            this.Saldo = saldo;
            this.Numero = numero;
           // this.TipoDeConta = tipodeconta;
        }
        //public void EscolherConta (Conta conta)
        //{
        //    string op;
        //    do
        //    {
        //        Console.WriteLine("Selecione o tipo de conta do cliente:" +
        //            "1 para corrente" +
        //            "2 para poupança");
        //        op = Console.ReadLine();
        //        switch (op)
        //        {
        //            case "1": TiposDeConta.contaCorrente
        //                conta.TipoDeConta = Console.WriteLine($"Saldo mais rendimento mensal: {conta.Saldo(Saldo)}", op);
        //                break;
        //            case (int)TiposDeConta.contaPouPança:
        //                conta.TipoDeConta = conta.TipoDeConta = Console.WriteLine($"Saldo mais rendimento mensal: {conta.TipoDeConta(Saldo)}", op);
        //                break;
        //            default:
        //                Console.WriteLine("Opção Inválida");
        //                break;
        //        }
        //    } while (op != 1 && op != 2);
        //}

        public void Transferir(Conta conta)
        {

            Console.WriteLine("Qual o valor do saque?");
            decimal valor = decimal.Parse(Console.ReadLine());
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
        public void Criarconta(Conta conta, Cliente cliente)
        {

            Console.WriteLine("Número da conta: 123456"); //essa conta tem que aparecer na tela do usuario
            //conta.Numero = Console.ReadLine();
            conta.Saldo = 0;
            conta.Cliente = cliente;

        }

        



        public void Depositar(Conta conta)
        {

            Console.WriteLine("Qual o valor do deposito?");
            decimal valor = decimal.Parse(Console.ReadLine());
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

        public decimal ConsultaSaldo(Conta conta)
        {
            return conta.Saldo;
        }

        public abstract void Saca(decimal saldo);
        
        //public abstract void Operacoes(double saldo);
    }
}
