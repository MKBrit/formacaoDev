using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _14Dez
{
    class Bank
    {
        private float saldo;
        public Bank(float x)
        {
            saldo = x;
            Console.WriteLine(saldo);
        }
        public void deposit(float x)
        {
            saldo = saldo + x;
            Console.WriteLine(saldo); 
        }
        public void withdraw(float x) 
        {
            saldo = saldo - x;
            Console.WriteLine(saldo);
        }
    }
}
