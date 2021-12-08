using System;
using System.Globalization;

namespace encapsulamento_ex1
{
    internal class ContaBancaria
    {
        static double Taxa = 5.00;

        public int NumeroDaConta { get; private set; }
        public string TitularDaConta { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria(int numero, string titular)
        {
            NumeroDaConta = numero;
            TitularDaConta = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }
        public void Saque(double saque)
        {
            saque += Taxa;
            Saldo -= saque;
            
        }
        public override string ToString()
        {
            return "Conta "
                + NumeroDaConta
                + ", Titular: "
                + TitularDaConta
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
