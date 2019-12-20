using System;
using System.Globalization;

namespace Exercicio_Fixação3
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            Console.Write("Entre com o número da conta: ");
            c1.Numero = int.Parse (Console.ReadLine());
            Console.Write("Entre com o nome do Titular: ");
            c1.Nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            c1.Verificacao(char.Parse(Console.ReadLine()));
            Console.WriteLine("Dados Conta:");
            Console.WriteLine(c1);

            Console.Write("Entre com um valor para depósito: ");
            c1.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(c1);
            Console.Write("Entre com um valor para saque: ");
            c1.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(c1);
        }
    }
}
