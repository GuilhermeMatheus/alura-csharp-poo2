using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = "Gabriela";
            cliente.Cpf = "444.444.444-44";
            cliente.Profissao = "Gerente de TI";

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.Titular = cliente;
            contaGabriela.Agencia = 444;
            contaGabriela.Numero = 444444;

            Console.WriteLine("cliente.GetNome(): " + cliente.Nome);
            Console.WriteLine("contaGabriela.GetTitular().GetNome(): " + contaGabriela.Titular.Nome);

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
