using System;
namespace Projeto_Banco_G4
{

    class Program
    {

        public static void Main(string[] args)
        {
            int opc = 5;

            Cliente cliente = new Cliente();
            Conta conta = new Conta();

            do
            {
                Console.WriteLine("Menu - escolha a opção desejada de acordo com o número: " +
                    "\n                              1 para cliente" +
                    "\n                              2 para depositar" +
                    "\n                              3 para tranferir" +
                    "\n                              4 para colsultar" +
                    "\n                              5 para sair\n");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Cadastrar Cliente");
                        cliente.CadastrarDados(cliente);
                        conta.criarConta(conta, cliente);
                        break;
                    case 2:
                        Console.WriteLine("Depositar Dinheiro");
                        conta.Depositar(conta);
                        break;
                    case 3:
                        Console.WriteLine("Tranferir Dinheiro");
                        conta.Transferir(conta);
                        break;
                    case 4:
                        Console.WriteLine("Consultar Saldo/Dados da conta");
                        
                        Console.WriteLine("Saldo: R$ "+ conta.ConsultaSaldo(conta));
                        Console.WriteLine(cliente.toString());
                        break;
                    case 5:
                        Console.WriteLine("Sair");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }
            
            while (opc != 5);
        }
    }
}
