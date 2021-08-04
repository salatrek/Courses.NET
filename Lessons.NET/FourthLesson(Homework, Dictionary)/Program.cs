using System;

namespace FourthLesson_Homework__Dictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            Currency Rubles = new Currency(73.13);
            Currency Euro = new Currency(0.84);
            Currency Hryvnia = new Currency(26.82);

            Client Alex = new Client("Mospan Alexey", 580);

            Alex.AddAccount(540, new Account(Rubles, 900));
            Alex.AddAccount(850, new Account(Euro, 500));

            Alex.ChangeBalance(540, -880);

            foreach (var item in Alex.clientAccounts)
            {
                Console.WriteLine($"{nameof(item.Value.TypeOfCurrency)} {item.Value.AccountBalance}");
            }
        }
    }
}
