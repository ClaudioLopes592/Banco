using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Conta
    {
        public int numero;
        public string titular;
        public double saldo;

        public bool Saca(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Deposita(double valor) 
        { 
            saldo += valor;
        }
    }
}
