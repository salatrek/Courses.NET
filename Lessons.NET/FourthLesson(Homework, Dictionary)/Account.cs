using System;

namespace FourthLesson_Homework__Dictionary_
{
    public class Account
    {
        public Currency TypeOfCurrency { get; set; }
        public double AccountBalance { get; set; }

        public Account(Currency typeOfCurrency, double accountBalance)
        {
            TypeOfCurrency = typeOfCurrency is Currency && typeOfCurrency != null ? typeOfCurrency : throw new ArgumentNullException(nameof(typeOfCurrency));
            AccountBalance = accountBalance < 0 ? throw new ArgumentNullException(nameof(accountBalance)) : accountBalance;
        }
    }
}
