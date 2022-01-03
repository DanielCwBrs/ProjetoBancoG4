using System; //biblioteca convencional
namespace Projeto_Banco_G4
{

    class Program
    {

        public static void Main(string[] args)  //Aqui em static void Main, servirá somente para receber e enviar o que o usuario desejar; se ele quer saber o nome de uma pessoa, é por aqui que sera feito o questionamento, se ele quer guardar uma info tambem é por aqui
        {
            
            Cliente cliente = new Cliente();
            //Conta conta = new Conta; //checar erro
            ContaPoupanca contaP = new ContaPoupanca();
            ContaCorrente contaC = new ContaCorrente();



            //DateTime data = new DateTime();

            //int opc = 5 / digito 5 referente ao valor de saída da estrutura de escolhas
            int opc = 6;
            //

            do //o do ele faz que a informação que sera gerada possa retornar false, assim, cancelando a operação;
               //em while ele retornara se o valor for diferente do esperado
            {
                //deixando desta forma, o menu aparecera centralizado
                Console.WriteLine("Menu - escolha a opção desejada de acordo com o número: " +
                    "\n                              1 para cliente" +
                    "\n                              2 para depositar" +
                    "\n                              3 para tranferir" +
                    "\n                              4 Dados Cliente" +
                    "\n                              5 para colsultar" +
                    "\n                              6 para sair\n");
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
                        contaP.Criarconta("12345", cliente);//mesma finalidade, aqui ele vai imprimir as infos na tela para o usuario de acordo com o que estiver la na classe "conta.cs"
                        contaC.Criarconta("24567", cliente);
                        //contaP.EscolherConta();
                        //contaC.EscolherConta();
                        break;
                    case 2:
                        Console.WriteLine("Depositar Dinheiro");
                        contaP.Depositar();
                        
                        contaC.Depositar();
                        break;
                    case 3:
                        Console.WriteLine("Tranferir Dinheiro");
                        contaP.Transferir();
                        contaC.Transferir();
                        break;
                    case 4:
                        Console.WriteLine("Dados do Cliente");
                        contaP.EscolherConta();
                        contaC.EscolherConta();
                        break;
                    case 5:
                        Console.WriteLine("Consultar Saldo/Dados da conta");
                        
                        Console.WriteLine("Saldo: R$ "+ contaP.ConsultaSaldo());
                        Console.WriteLine("Saldo: R$ " + contaC.ConsultaSaldo());
                        //contaPoupanca.AcrescentarRendimento(contaPoupanca);
                        //Console.WriteLine($"Saldo mais rendimento mensal: {contaPoupanca.AcrescentarRendimento(contaPoupanca)}");
                        //Console.WriteLine($"Saldo mais taxa mensal: {contaCorrente.DescontarTaxa(contaCorrente)}");

                        Console.WriteLine(cliente.toString());
                        Console.WriteLine(cliente.DataNascimento);
                        
                        if(contaP.ConsultaSaldo() < 5000)
                        {
                            Console.WriteLine("Usuário conta: Comum");

                        }
                        else if (contaP.ConsultaSaldo() < 15000)
                        {
                            Console.WriteLine("Usuário conta: Super");
                        }
                        else if (contaP.ConsultaSaldo() >= 15000)
                        {
                            Console.WriteLine("Usário conta: Premium");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Sair");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (opc != 6);
            //!= se diferente de 5, ou seja, usuario inserir algum valor diferente do switch, ele invalida

        }
    }
}
