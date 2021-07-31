using System;

namespace ThirdLesson_Homework_LINQ_
{
    public class Client
    {
        public string ClientName { get; set; }
        public double AccountBalance { get; set; }
        public string PassportID { get; set; }

        public Client(string _clientName, double _accountBalance, string _passportID)
        {
            ClientName = string.IsNullOrWhiteSpace(_clientName) ? throw new ArgumentNullException(nameof(_clientName)) : _clientName;

            PassportID = string.IsNullOrWhiteSpace(_passportID) ? throw new ArgumentNullException(nameof(_passportID)) : _passportID;

            AccountBalance = _accountBalance <= -5000 ? throw new ArgumentNullException(nameof(_accountBalance)) : _accountBalance;
        }
    }
}
