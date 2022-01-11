using System;
using System.Collections.Generic;
using System.Text;

namespace amount.Models
{
    class CashRegister
    {
        public Currency Currency { get; set; }
        public PaymentType PaymentType { get; set; }
        public double TotalAmount { get; set; }
        public static int TotalSalesCount { get; set; }
        public CashRegister(double totalamount,Currency currency)
        {
            TotalAmount = (int)totalamount;
            Currency = currency;
        }
        public void Addnewsale(Currency currency1,double amount)
        {
            if (Currency==currency1)
            {
                TotalAmount += amount;
            }
            else
            {
                switch (currency1)
                {
                    case Currency.AZN:
                        amount /= 1.7;
                        break;
                    case Currency.USD:
                        amount *= 1.7;
                        break;
                    default:
                        break;
                }
            }
            TotalAmount += amount;
        }
        public void RemoveSale(Currency currency2, double amount)
        {
            if (Currency == currency2)
            {
                TotalAmount -= amount;
            }
            else
            {
                switch (currency2)
                {
                    case Currency.AZN:
                        amount /= 1.7;
                        break;
                    case Currency.USD:
                        amount *= 1.7;
                        break;
                    default:
                        break;
                }
            }
            TotalAmount -= amount;
        }
        public override string ToString()
        {
            return $"{TotalAmount}   {PaymentType}   {Currency}";
        }
    }
}
