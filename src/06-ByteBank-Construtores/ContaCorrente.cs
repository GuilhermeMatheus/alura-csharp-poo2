using System;

namespace _06_ByteBank_Construtores
{
    public class ContaCorrente
    {
        public static int NumeroDeContasCriadas { get; private set; }

        private int _numero;
        private int _agencia;
        private double _saldo;
        private Cliente _titular;

        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Não é permitido número menor ou igual a 0");
                    return;
                }
                _numero = value;
            }
        }
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Não é permitido agencia menor ou igual a 0");
                    return;
                }
                _agencia = value;
            }
        }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }
        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }

        public ContaCorrente(int numero, int agencia)
        {
            Numero = numero;
            Agencia = agencia;

            NumeroDeContasCriadas++;
        }

        public void Deposita(double valor)
        {
            // devia ter feito um SetSaldo(GetSaldo() + saldo)  
            // usar propriedades aqui é opcional mas eu sempre faço assim pra centralizar qualquer lógica
            Saldo += valor;
        }

        public bool Saca(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transfere(double valor, ContaCorrente outraConta)
        {
            // Começamos assim, mas podemos fazer invocando o Saca
            // e ganhamos um DRY ?

            //if (this.saldo >= valor)
            //{
            //    this.saldo -= valor;
            //    outraConta.Deposita(valor);
            //    return true;
            //}

            bool saqueRealizado = Saca(valor);
            if (saqueRealizado)
            {
                outraConta.Deposita(valor);
                return true;
            }

            return false;
        }
    }
}