using System;

namespace Projeto_Banco_G4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EscolherConta();
        }

        public static int EscolherConta()
        {
            var cliente = new Cliente();
            var cc = new ContaCorrente(cliente);
            var cp = new ContaPoupanca(cliente);
            Console.WriteLine("Selecione uma opção? 1 para conta corrente, 2 para conta poupança ou 3 para sair");
            int opc = int.Parse(Console.ReadLine());
            bool isValido;
            do
            {
                if (opc == 1)
                {
                    ChamarMenu(cc);
                }
                else if (opc == 2)
                {
                    ChamarMenuCP(cp);
                }
                else if (opc == 3)
                {
                    Environment.Exit(0);
                }
                isValido = opc > 1 && opc <= 2;
                if (!isValido)
                {
                    Console.WriteLine("Você digitou uma opção inválida! Tente novamente!");
                    EscolherConta();
                }
            } while (!isValido);

            return opc;
        }

        public static int GuardarOpcaoCC(Conta conta)
        {
            bool isValido;
            string opcao;
            do
            {
                Console.WriteLine("Menu - escolha a opção desejada de acordo com o número: ");
                Console.WriteLine(@$"
                        1- Cadastrar Cliente
                        2- Depositar dinheiro na conta corrente
                        3- Transferir dinheiro da conta corrente
                        4- Consultar Saldo/Dados da Conta {conta.TipoConta}
                        5- Sair");
                opcao = Console.ReadLine();
                isValido = int.Parse(opcao) > 0 && int.Parse(opcao) <= 5;
                if (!isValido)
                {
                    Console.WriteLine("Você digitou uma opção inválida! Tente novamente!");
                }
            } while (!isValido);

            return int.Parse(opcao);
        }

        public static int GuardarOpcaoCP(Conta conta)
        {
            string opcao;
            bool isValido;
            do
            {
                Console.WriteLine("Menu - escolha a opção desejada de acordo com o número: ");
                Console.WriteLine(@$"
                    1- Cadastrar Cliente
                    2- Depositar dinheiro na conta poupanca
                    3- Transferir dinheiro da conta poupanca
                    4- Consultar Saldo/Dados da Conta {conta.TipoConta}
                    5- Sair");
                opcao = Console.ReadLine();
                isValido = int.Parse(opcao) > 0 && int.Parse(opcao) < 6;
                if (!isValido)
                {
                    Console.WriteLine("Você digitou uma opção inválida! Tente novamente!");
                }
            } while (!isValido);

            return int.Parse(opcao);
        }


        public static void ChamarMenu(Conta conta)
        {

            string respostaCpf = "";
            string respostaNome = "";
            int opcao = GuardarOpcaoCC(conta);
            do
            {
                switch (opcao)
                {
                    case 1:
                        conta.Cliente.CadastrarDados(respostaCpf, respostaNome);
                        opcao = GuardarOpcaoCC(conta);
                        break;
                    case 2:
                        conta.Depositar();
                        opcao = GuardarOpcaoCC(conta);
                        break;
                    case 3:
                        conta.Transferir();
                        opcao = GuardarOpcaoCC(conta);
                        break;
                    case 4:
                        conta.ConsultarSaldo();
                        opcao = GuardarOpcaoCC(conta);
                        break;
                    case 5:
                        EscolherConta();
                        break;
                }
            }
            while (opcao < int.MaxValue);
            var cliente = new Cliente();
            var cc = new ContaCorrente(cliente);
            if (opcao > 5 || opcao <= 0)
                Console.WriteLine("Opção inválida");
            ChamarMenu(cc);
        }

        public static void ChamarMenuCP(Conta conta)
        {

            string respostaCpf = "";
            string respostaNome = "";
            int opcao = GuardarOpcaoCP(conta);
            do
            {
                switch (opcao)
                {
                    case 1:
                        conta.Cliente.CadastrarDados(respostaCpf, respostaNome);
                        opcao = GuardarOpcaoCP(conta);
                        break;
                    case 2:
                        conta.Depositar();
                        opcao = GuardarOpcaoCP(conta);
                        break;
                    case 3:
                        conta.Transferir();
                        opcao = GuardarOpcaoCP(conta);
                        break;
                    case 4:
                        conta.ConsultarSaldo();
                        opcao = GuardarOpcaoCP(conta);
                        break;
                    case 5:

                        EscolherConta();
                        break;
                }
            } while (opcao < int.MaxValue);
            var cliente = new Cliente();
            var cp = new ContaPoupanca(cliente);
            if (opcao > 5 || opcao <= 0)
                Console.WriteLine("Opção inválida");
            ChamarMenu(cp);


        }
    }
}


