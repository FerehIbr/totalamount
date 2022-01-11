using amount.Models;
using System;

namespace amount
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cashRegister = new CashRegister(100,Currency.AZN);
            cashRegister.Addnewsale(110, Currency.USD);
        }
    }
}
