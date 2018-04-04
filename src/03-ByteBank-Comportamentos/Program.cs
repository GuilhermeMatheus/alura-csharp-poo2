using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Comportamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 123;
            contaGabriela.numero = 123456;
            contaGabriela.saldo = 1000;

            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";
            contaDoBruno.agencia = 444;
            contaDoBruno.numero = 444444;
            contaDoBruno.saldo = 10;

            Console.WriteLine("contaGabriela.saldo:" + contaGabriela.saldo);
            Console.WriteLine("contaDoBruno.saldo:" + contaDoBruno.saldo);

            Console.WriteLine();

            contaDoBruno.Deposita(100);

            Console.WriteLine("contaGabriela.saldo:" + contaGabriela.saldo);
            Console.WriteLine("contaDoBruno.saldo:" + contaDoBruno.saldo);

            contaDoBruno.Transfere(110, contaGabriela);

            Console.WriteLine("contaGabriela.saldo:" + contaGabriela.saldo);
            Console.WriteLine("contaDoBruno.saldo:" + contaDoBruno.saldo);

            contaDoBruno.Transfere(1000, contaGabriela);
            Console.WriteLine(contaDoBruno.Transfere(1000, contaGabriela));

            Console.ReadLine();
        }
    }
}
