using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.NumeroDeContasCriadas);
            // ContaCorrente conta = new ContaCorrente(); dá erro
            ContaCorrente conta = new ContaCorrente(444, 44444);

            // não compila:
            // Console.WriteLine(conta.NumeroDeContasCriadas)

            Console.WriteLine(ContaCorrente.NumeroDeContasCriadas);

            ContaCorrente contaBruno = new ContaCorrente(555, 55555);

            Console.WriteLine(ContaCorrente.NumeroDeContasCriadas);

            Console.ReadLine();
        }
    }
}
