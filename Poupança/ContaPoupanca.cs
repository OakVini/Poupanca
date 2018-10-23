using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poupança
{
    class ContaPoupanca
    {

        //Mostra o saldo.
        public void SaldoPoupanca()
        {

            Console.WriteLine("Poupador1: {0}", poupador1);
            Console.WriteLine("Poupador2: {0}", poupador2);

        }

        

        public double poupador1 = 2000;
        public double poupador2 = 3000;
      

        public static double taxaDeJurosAnual = 0.04;


        public double CalcularJurosMensal()
        {

            Console.WriteLine("\n");

            var CalculandoPoup1 = (poupador1 * taxaDeJurosAnual) / 12;
            var novoSaldoPoupador1 = poupador1 + CalculandoPoup1;
            poupador1 = novoSaldoPoupador1;

            var CalculandoPoup2 = (poupador2 * taxaDeJurosAnual) / 12;
            var novoSaldoPoupador2 = poupador2 + CalculandoPoup2;
            poupador2 = novoSaldoPoupador2;


            return (CalculandoPoup1 + CalculandoPoup1);
            

        }
        


        public double AlterarTaxaDeJuros()
        {

            return taxaDeJurosAnual = 0.05;
        }
    }
}
