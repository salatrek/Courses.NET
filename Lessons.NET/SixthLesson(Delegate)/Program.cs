using System;

namespace SixthLesson_Delegate_
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            var messageHandler = new BankAccount.AccountMessageHandler(SendRedMessage);
            messageHandler += SendMessage;
            bankAccount.DeligateRegister(messageHandler);
            bankAccount.Add(500);

            var test = new Test();
            for (int i = 0; i < 10; i++)
            {
                test.Devide(10, i);
            }
        }

        static void SendRedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
