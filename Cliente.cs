using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco_G4
{
    class Cliente
    {
        private string Nome { get; set; }
        private string CPF { get; set; }
        private int TipoCliente { get; set; }

        enum TiposCliente { ContaCorrente = 1, ContaPouPança = 2 }

        public Cliente () {}

        public Cliente(string nome, string cpf, int tipocliente)
        { 
            this.Nome = nome;
            this.CPF = cpf;
            this.TipoCliente = tipocliente;
        }

        public void CadastrarDados (Cliente cliente) //tudo que estiver na função "CadastrarDados" com parametros Cliente cliente,
                                                     //iram aparecer la no program.cs no switch case 1
        {
            Console.WriteLine("Digite o nome do cliente:");
            cliente.Nome = Console.ReadLine();

            do
            {
                Console.WriteLine("Digite o CPF do cliente:");
                cliente.CPF = Console.ReadLine();
                if (!validarCpf(cliente.CPF))
                {
                    Console.WriteLine("CPF Inválido!");
                }
            } while (!validarCpf(cliente.CPF));


            int op;
            do
            {
                Console.WriteLine("Selecione o tipo de conta do cliente:" +
                    "1 para corrente" +
                    "2 para poupança");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case (int)TiposCliente.ContaCorrente:
                        cliente.TipoCliente = op;
                        break;
                    case (int)TiposCliente.ContaPouPança:
                        cliente.TipoCliente = op;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (op != 1 && op != 2);
            Console.WriteLine("Cliente Cadastrado com sucesso!");
        }

        public bool validarCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333333" || cpf == "44444444444" || cpf == "55555555555" || cpf == "66666666666" || cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999" || cpf == "00000000000")
            return false;
            if (cpf.Length != 11)
            return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        
        }

        public string toString()
        {
            return "Nome: "+
                Nome +
                "\nCPF: " +
                CPF + 
                "\nTipo de Conta " +
                TipoCliente;
        }
    }
}
