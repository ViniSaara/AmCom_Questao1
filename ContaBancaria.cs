using System.Globalization;

namespace Questao1
{
    public class ContaBancaria {

        private const double TAXA_SAQUE = 3.5;

        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular, double depositoInicial)
        {
            Numero = numero;
            Titular = titular;
            Saldo = depositoInicial;
        }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo = Saldo - TAXA_SAQUE - quantia;
        }
    }
}