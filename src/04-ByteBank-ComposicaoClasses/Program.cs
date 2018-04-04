using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank_ComposicaoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.nome = "Gabriela";
            cliente.cpf = "444.444.444-44";
            cliente.profissao = "Gerente de TI";

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = cliente;

            Console.WriteLine("cliente.nome: " + cliente.nome);
            Console.WriteLine("contaGabriela.titular.nome: " + contaGabriela.titular.nome);
            
            Console.WriteLine();

            contaGabriela.titular.nome = "Gabriela Castro";

            Console.WriteLine("cliente.nome: " + cliente.nome);
            Console.WriteLine("contaGabriela.titular.nome: " + contaGabriela.titular.nome);

            Console.ReadLine();
        }
    }
}
