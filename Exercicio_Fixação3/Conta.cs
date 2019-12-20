using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_Fixação3
{
    class Conta
    {
        public int Numero { get;  set; }
        public string Nome { get;  set; }
        public double Saldo { get; private set; }

        
        public Conta(){}

        public void Verificacao (char resposta)
        {
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o com valor do deposito inicial: ");
                DepositoInicial (double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            }
          
        }
        public void DepositoInicial (double inicio)
        {
            
            Saldo += inicio;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public void Saque(double valor)
        {
            Saldo = Saldo - 5.00 - valor;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Nome + ", Saldo: $" + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
