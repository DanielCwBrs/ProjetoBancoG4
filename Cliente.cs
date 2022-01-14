using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco_G4
{
    class Cliente
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public TipoCliente Tipo { get; set; }


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


        public void CadastrarDados(string inCpf, string inNome)
        {
            bool validaDigitos;
            Console.WriteLine("Digite seu nome:");
            inNome = Console.ReadLine();
            do
            {
                Console.WriteLine("Digite seu CPF sem pontos ou traços (11 dígitos): ");
                inCpf = Console.ReadLine();
                validaDigitos = inCpf.Length != 11;
                Console.WriteLine("\n");

                if (validaDigitos)
                {
                    Console.WriteLine("CPF não tem 11 dígitos!");
                }

            } while (validaDigitos);


            Cpf = inCpf;
            Nome = inNome;
        }

    }
}
