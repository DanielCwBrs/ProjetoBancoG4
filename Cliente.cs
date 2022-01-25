using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CorrecaoBanco
{
    class Cliente
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public TipoCliente Tipo { get; set; }
        public DateTime DataNascimento { get; set; }


        public Cliente()
        {
            Tipo = TipoCliente.Comum;
        }

        public Cliente(string inCpf, string inNome)
        {
            Cpf = inCpf;
            Nome = inNome;
            Tipo = TipoCliente.Comum;
        }


        public void CadastrarDados()
        {
            string inCpf;
            string inNome;
            string inDataNascimento;
            bool validaDigitos;

            Console.WriteLine("Digite seu nome:");
            inNome = Console.ReadLine();

            bool continua = true;
            while (continua)
            {
                try
                {
                    continua = false;
                    Console.WriteLine("Digite sua data de nascimento:");
                    inDataNascimento = Console.ReadLine();
                    DataNascimento = DateTime.ParseExact(inDataNascimento, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    continua = true;
                    Console.WriteLine("Termo inválido inserido, insira sua data de nascimento da seguinte forma: 01/01/0001\n");
                }
            }

            do
            {
                Console.WriteLine("Digite seu CPF sem pontos ou traços (11 dígitos): ");
                inCpf = Console.ReadLine();
                validaDigitos = inCpf.Length != 11;
                //Console.WriteLine("\n");

                if (validaDigitos)
                {
                    Console.WriteLine("CPF não tem 11 dígitos!");
                }
            } while (validaDigitos);
            Console.WriteLine("Dados gravados com sucesso!\n");
            Console.WriteLine("Voltando ao menu principal!\n");
            Thread.Sleep(2000);
            

            Cpf = inCpf;
            Nome = inNome;
            
            

        }

    }
}
