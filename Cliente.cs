using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco_G4
{
    class Cliente
    {
        private string Nome { get; set; } //get, valor de retorno / set, valor de entrada
        private string CPF { get; set; }
        private int TipoDeConta { get; set; }
        

        enum TiposDeConta { contaCorrente = 1, contaPouPança = 2 }

        public Cliente () {}

        public Cliente(string nome, string cpf, int tipodeconta) //Aqui orientaremos ao programa o que ele deve armazenar na classe cliente, onde a variavel é atribuida a propriedade
        { 
            this.Nome = nome; //precisamos dar uma referencia ao nosso programa de que aquela variavel será atribuida a nossa propriedade
            this.CPF = cpf;
            this.TipoDeConta = tipodeconta;
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
                if (!ValidarCpf(cliente.CPF))
                {
                    Console.WriteLine("CPF Inválido!");
                }
            } while (!ValidarCpf(cliente.CPF));


            int op;
            do
            {
                Console.WriteLine("Selecione o tipo de conta do cliente:" +
                    "1 para corrente" +
                    "2 para poupança");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case (int)TiposDeConta.contaCorrente:
                        cliente.TipoDeConta = op;
                        break;
                    case (int)TiposDeConta.contaPouPança:
                        cliente.TipoDeConta = op;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (op != 1 && op != 2);
            Console.WriteLine("Cliente Cadastrado com sucesso!");

            //fazer aqui um if para tipo de cliente

        }

        public bool ValidarCpf(string cpf)
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
                "\nTipo de conta " +
                TipoDeConta;
        }
    }
}
