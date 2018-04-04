using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Referencias
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 123;
            contaGabriela.numero = 123456;

            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";
            contaDoBruno.agencia = 444;
            contaDoBruno.numero = 444444;


            contaGabriela.saldo = 100;
            contaDoBruno.saldo = 100;

            contaGabriela.saldo += 100;

            Console.WriteLine("contaGabriela.saldo:" + contaGabriela.saldo);
            Console.WriteLine("contaDoBruno.saldo:" + contaDoBruno.saldo);

            Console.WriteLine();
            contaDoBruno = contaGabriela;
            contaDoBruno.saldo = 1000;

            Console.WriteLine("contaGabriela.saldo:" + contaGabriela.saldo);
            Console.WriteLine("contaDoBruno.saldo:" + contaDoBruno.saldo);

            Console.ReadLine();
        }
    }
}
