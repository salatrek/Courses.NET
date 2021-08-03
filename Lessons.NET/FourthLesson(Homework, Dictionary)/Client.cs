using System;
using System.Collections.Generic;

namespace FourthLesson_Homework__Dictionary_
{
    public class Client
    {
        public string ClientName { get; set; }
        public int PassportID { get; set; }

        public Dictionary<int, Account> clientAccounts = new Dictionary<int, Account>();

        public Client(string clietnName, int passportID)
        {
            ClientName = string.IsNullOrWhiteSpace(clietnName) ? throw new ArgumentNullException(nameof(clietnName)) : clietnName;
            PassportID = passportID <= 0 ? throw new ArgumentNullException(nameof(passportID)) : passportID;
        }

        public void AddAccount(int accountID, Account account)
        {
            if (!clientAccounts.ContainsKey(accountID))
            {
                clientAccounts.Add(accountID, account);
                Console.WriteLine($"Номер счета {accountID} добавлен.");
            }
            else
            {
                Console.WriteLine($"Номер счета {accountID} уже существует.");
            }
        }

        public void RemoveAccount(int accountID)
        {
            if (clientAccounts.ContainsKey(accountID))
            {
                clientAccounts.Remove(accountID);
                Console.WriteLine($"Номер счета {accountID} удален.");
            }
            else
            {
                Console.WriteLine($"Номер счета {accountID} не существует.");
            }

        }

        public void ExchangeMoney(int sourceAccount, double count, int targerAccount)
        {
            if (clientAccounts.ContainsKey(sourceAccount) && clientAccounts.ContainsKey(targerAccount))
            {

                var sourceBalance = clientAccounts[sourceAccount].AccountBalance;
                var sourceRate = clientAccounts[sourceAccount].TypeOfCurrency.Rate;

                var targetBalance = clientAccounts[targerAccount].AccountBalance;
                var targetRate = clientAccounts[targerAccount].TypeOfCurrency.Rate;

                sourceBalance = sourceBalance - count;
                targetBalance = targetBalance + (sourceBalance / sourceRate) * targetRate;

                clientAccounts[sourceAccount].AccountBalance = sourceBalance;
                clientAccounts[targerAccount].AccountBalance = targetBalance;
            }
        }
    }
}
