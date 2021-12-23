using System;
namespace Projeto_Banco_G4
{

    class Program
    {

        public static void Main(string[] args)
        {
            //int opc = 5 digito 5 referente ao valor de saída da estrutura de escolhas
            int opc = 5;
            //
            Cliente cliente = new Cliente();
            Conta conta = new Conta();

            do //o do ele faz que a informação que sera gerada possa retornar false, assim, cancelando a operação;
               //em while ele retornara se o valor for diferente do esperado
            {
                //deixando desta forma, o menu aparecera centralizado
                Console.WriteLine("Menu - escolha a opção desejada de acordo com o número: " +
                    "\n                              1 para cliente" +
                    "\n                              2 para depositar" +
                    "\n                              3 para tranferir" +
                    "\n                              4 para colsultar" +
                    "\n                              5 para sair\n");
                //cria uma variavel para salvar a resposta do usuario e a converte em inteiro:
                opc = int.Parse(Console.ReadLine());
                //switch case, A info que será impressa para o usuario caso ele digite um valor entre 1 à 5 
                switch (opc) //o switch usa a variavel opc como parametro para saber com que estara trabalhando, neste caso as 5 opções de escolha para o usuario
                {
                    case 1:
                        //info impressa:
                        Console.WriteLine("Cadastrar Cliente");
                        cliente.CadastrarDados(cliente); //valor de retorno, ou seja, de onde vão sair as informações que serão impressas na tela? por isso inserimos
                                                         //cliente.CadastrarDados(cliente), ele vai buscar as infos diretamente na classe "Cliente.cs":
                        conta.criarConta(conta, cliente);//mesma finalidade, aqui ele vai imprimir as infos na tela para o usuario de acordo com o que estiver la na classe "Conta.cs"
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
                        if(conta.ConsultaSaldo(conta) < 5000)
                        {
                            Console.WriteLine("Usuário conta: COMUM");
                        }
                        else if (conta.ConsultaSaldo(conta) < 15000)
                        {
                            Console.WriteLine("Usuário conta: Super");
                        }
                        else if (conta.ConsultaSaldo(conta) >= 15000)
                        {
                            Console.WriteLine("Usário conta: Premium");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Sair");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }
             //!= se diferente de 5, ou seja, usuario inserir algum valor diferente do switch, ele invalida
            while (opc != 5);
        }
    }
}
