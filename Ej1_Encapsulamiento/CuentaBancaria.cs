using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_Encapsulamiento
{
   // Crea una clase llamada "CuentaBancaria" con una propiedad privada "saldo"
   // y métodos públicos como "Depositar" y "Retirar".
   // Asegúrate de que estos métodos verifiquen y actualicen adecuadamente el saldo.
    public  class CuentaBancaria
    {
        private double Saldo { get; set; }

        public double Depositar(double Deposito) 
        {
            return Saldo += Deposito;
        }

        public string SaldoActualConDeposito() 
        {
            return $"Su saldo actual es {Saldo}";
        }

        public double Retirar(double Extraccion) 
        {
        return Saldo -= Extraccion;
        }
        public string SaldoActualConExtraccion() 
        {
            return $"Su saldo actual es {Saldo} ";
        }
    }
}
