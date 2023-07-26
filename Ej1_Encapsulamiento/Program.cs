using System.Security.Cryptography.X509Certificates;

namespace Ej1_Encapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CuentaBancaria cuentaBancaria = new CuentaBancaria();
            cuentaBancaria.Depositar(800000);
            Console.WriteLine(cuentaBancaria.SaldoActualConDeposito());

            cuentaBancaria.Retirar(400000);
            Console.WriteLine(cuentaBancaria.SaldoActualConExtraccion());
        }
    }
}