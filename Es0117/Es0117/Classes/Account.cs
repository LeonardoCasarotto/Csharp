using System;
using System.Collections.Generic;
using System.Text;

namespace Es0117.Classes
{
    public class Account
    {
        private readonly object BalanceLock = new object();
        private decimal balance;


        public Account(decimal inizio) => balance = inizio;



        public decimal prelievo(decimal soldi)
        {
            
            if (soldi <= 0)
            {
                throw new ArgumentOutOfRangeException("Non è possibile prelevare valori nulli o negativi");
            }
            lock (BalanceLock)
            {
                if (balance < soldi)
                {
                    throw new ArgumentOutOfRangeException("Non è possibile prelevare valori superiori a quanto in deposito");
                }
                balance -= soldi;
                return soldi;
            }
        }

        public decimal deposito(decimal cash)
        {
            if (cash <= 0)
            {
                throw new ArgumentOutOfRangeException("Attenzione, non è possibile depositare valori nulli o negativi.");
            }
            lock (BalanceLock)
            {
                balance += cash;
            }
            return balance;
        }

        public decimal GetBalance()
        {
            lock (BalanceLock)
            {
                return this.balance;

            }
        }


    }
}
