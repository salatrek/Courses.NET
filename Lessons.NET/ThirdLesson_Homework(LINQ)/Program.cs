using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLesson_Homework_LINQ_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> listOfClients = new List<Client>();

            AddToList(listOfClients, new Client("Mospan Alexey Alexandrovich", 450, "T574"));
            AddToList(listOfClients, new Client("Mospan Anna Pavlovna", 200, "Y575"));
            AddToList(listOfClients, new Client("Kalinichenko Elena Petrovna", 900, "W900"));
            AddToList(listOfClients, new Client("Tereshin Pavel Viktorovich", 1500, "Z856"));
            AddToList(listOfClients, new Client("Ivanov Ivan Ivanovich", 650, "AV400"));
            AddToList(listOfClients, new Client("Vasiliev Vasilii Pupkin", 200, "TB359"));
            AddToList(listOfClients, new Client("Vasiliev Vasilii Pupkin", 500, "YU785"));

            var clientByNameOrPassportID = SearchByName(listOfClients, "Vasiliev Vasilii Pupkin");
            foreach (var item in clientByNameOrPassportID)
            {
                Console.WriteLine($"{item.ClientName} {item.AccountBalance} {item.PassportID}");
            }

            Console.WriteLine("\n");

            var clientByBalance = SearchByBalance(listOfClients, 700);
            foreach (var item in clientByBalance)
            {
                Console.WriteLine($"{item.ClientName} {item.AccountBalance} {item.PassportID}");
            }

            Console.WriteLine("\n");

            var clientByMinBalance = SearchByMinBalance(listOfClients);
            foreach (var item in clientByMinBalance)
            {
                Console.WriteLine($"{item.ClientName} {item.AccountBalance} {item.PassportID}");
            }

            Console.WriteLine("\n");

            Console.WriteLine($"Общая сумма: {ShowTotalBalances(listOfClients)}");
            
            Console.ReadKey();
        }

        static void AddToList(List<Client> listOfClients, Client client)
        {
            try
            {
                listOfClients.Add(client);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static Client[] SearchByName(List<Client> listOfClients, string searchString)
        {
            return listOfClients.Where(x => x.ClientName.Contains(searchString) || x.PassportID.Contains(searchString)).ToArray();
        }

        static Client[] SearchByBalance(List<Client> listOfClients, int balance)
        {
            return listOfClients.Where(x => x.AccountBalance < balance).ToArray();
        }

        static Client[] SearchByMinBalance(List<Client> listOfClients)
        {
            var minBalance = listOfClients.Min(x => x.AccountBalance);
            return listOfClients.Where(x => x.AccountBalance == minBalance).ToArray();
        }

        static int ShowTotalBalances(List<Client> listOfClients)
        {
            int totalBalance;
            return totalBalance = (int)listOfClients.Sum(x => x.AccountBalance);
        }
    }
}
