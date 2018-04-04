namespace _05_ByteBank_Encapsulamento
{
    public class ContaCorrente
    {
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

        public void Deposita(double valor)
        {
            this._saldo += valor;
        }

        public bool Saca(double valor)
        {
            if (this._saldo >= valor)
            {
                this._saldo -= valor;
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