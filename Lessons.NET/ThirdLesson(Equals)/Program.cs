using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLesson_Equals_
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Alex = new Client("Mospan Alexey Alexandrovich", 450, 574);
            Client Anna = new Client("Mospan Anna Pavlovna", 450, 575);
            Client Elena = new Client("Kalinichenko Elena Petrovna", 900, 900);
            Client Alex2 = new Client("Mospan Alexey Alexandrovich", 450, 580);
            Client Alex3 = new Client("Mospan Alexey Alexandrovich", 450, 574);

            List<Client> listOfClients = new List<Client>();

            CreateClient(listOfClients, Alex);
            CreateClient(listOfClients, Anna);
            CreateClient(listOfClients, Alex);
            CreateClient(listOfClients, Elena);
            CreateClient(listOfClients, Alex2);
            CreateClient(listOfClients, Alex3);
            
            Console.ReadKey();
        }

        public static void CreateClient(List<Client>  listOfClients, Client client)
        {

            if (!listOfClients.Contains(client))
            {
                listOfClients.Add(client);
            }
            else
            {
                Console.WriteLine($"Пользоваель {client.ClientName} уже существует");
            }
              
        }
        
    }
}

