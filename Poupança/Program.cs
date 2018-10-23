using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poupança
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaPoupanca CP = new ContaPoupanca();

            ContaPoupanca poupador1 = new ContaPoupanca();
            ContaPoupanca poupador2 = new ContaPoupanca();


            //Imprimir saldo atual.
            Console.WriteLine("Saldos originais. ");
            CP.SaldoPoupanca();

            //Calcular o juros de 4%
            CP.CalcularJurosMensal();

            //Imprimir novo saldo com 4% / 12
            Console.WriteLine("Seus saldos esse mês, com o juros anual em 4% e o mensal em 0,33%.");
            CP.SaldoPoupanca();

            //Alterando o juros para 5%
            CP.AlterarTaxaDeJuros();

            //Calcula o saldo com os 5%
            CP.CalcularJurosMensal();

            //Mostra o novo saldo
            Console.WriteLine("Seus saldos no mês subsequente, com o juros anual em5% e o mensal em 0,41%.");
            CP.SaldoPoupanca();









            Console.ReadKey();
        }
    }
}
