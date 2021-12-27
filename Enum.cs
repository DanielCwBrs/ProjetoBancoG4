using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco_G4
{
   class Enum
    {
        enum TipoDeConta { Comum = 0, Super = 1, Premium = 2}

        static void ContaTipo(string[] args)
        {
            TipoDeConta validaconta = TipoDeConta.Comum;
            Console.WriteLine("Conta é do tipo: " + (int)validaconta);
            
        }
    }
}
