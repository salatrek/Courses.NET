using System;
using System.Collections.Generic;

namespace ThirdLesson_Equals_
{
    public class Client
    {
        public string ClientName { get; set; }
        public double AccountBalance { get; set; }
        public int PassportID { get; set; }

        public Client(string _clientName, double _accountBalance, int _passportID)
        {
            if (!string.IsNullOrWhiteSpace(_clientName))
            {
                ClientName = _clientName;
            }
            else
            {
                throw new ArgumentNullException("Неверно указаны ФИО клиента");
            }

            if (_passportID != 0)
            {
                PassportID = _passportID;
            }
            else
            {
                throw new ArgumentNullException("Неверно указан УИ клиента");
            }

            AccountBalance = _accountBalance;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Client))
            {
                return false;
            }
            var client = (Client)obj;

            return client.PassportID == PassportID;
        }
    }
}

