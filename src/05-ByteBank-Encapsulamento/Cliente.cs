using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank_Encapsulamento
{
    public class Cliente
    {
        private string _nome;
        private string _cpf;
        private string _profissao;

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        public string Cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }
        public string Profissao
        {
            get
            {
                return _profissao;
            }
            set
            {
                _profissao = value;
            }
        }
    }
}
