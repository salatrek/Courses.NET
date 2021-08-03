using System;
using System.Collections.Generic;

namespace FourthLesson_ClassWork_
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Alex = new Client("Mospan Alexey", 580);
            Client Anna = new Client("Mospan Anna", 590);

            Currency Rubles = new Currency(73.13);
            Currency Euro = new Currency(0.84);
            Currency Hryvnia = new Currency(26.82);

            Account RublesAccount = new Account() { TypeOfCurrency = Rubles, AccountBalance = 960 };
            Account EuroAccount = new Account() { TypeOfCurrency = Euro, AccountBalance = 800 };
            Account HryvniaAccount = new Account() { TypeOfCurrency = Hryvnia, AccountBalance = 700 };

            Alex.listOfAccounts.Add(RublesAccount);
            Alex.listOfAccounts.Add(EuroAccount);
            Anna.listOfAccounts.Add(HryvniaAccount);

            Dictionary<Client, List<Account>> clients = new Dictionary<Client, List<Account>>();
            clients.Add(Alex, Alex.listOfAccounts);
            clients.Add(Anna, Anna.listOfAccounts);

            var clientAccounts = clients[Alex];
            
            foreach (var item in clientAccounts)
            {
                Console.WriteLine($"{nameof(item.TypeOfCurrency)} {item.AccountBalance}");
            }

        }

        static double СurrencyСonverter(Account account, Currency purchaseСurrency)
        {
            var balance = account.AccountBalance;
            var _sellСurrency = account.TypeOfCurrency.Rate;
            var _purchaseСurrency = purchaseСurrency.Rate;

            balance = (balance / _sellСurrency) * _purchaseСurrency;


            return balance;
        }

        static double IndependentСurrencyСonverter(Account account, Currency sellCurrency, Currency purchaseСurrency)
        {
            var balance = account.AccountBalance;
            var _sellСurrency = sellCurrency.Rate;
            var _purchaseСurrency = purchaseСurrency.Rate;

            balance = (balance / _sellСurrency) * _purchaseСurrency;


            return balance;
        }

    }
}
