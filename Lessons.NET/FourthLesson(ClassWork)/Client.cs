using System;
using System.Collections.Generic;

namespace FourthLesson_ClassWork_
{
    public class Client
    {
        public string ClientName { get; set; }
        public int PassportID { get; set; }

        public Client(string clietnName, int passportID)
        {
            ClientName = string.IsNullOrWhiteSpace(clietnName) ? throw new ArgumentNullException(nameof(clietnName)) : clietnName;
            PassportID = passportID <= 0 ? throw new ArgumentNullException(nameof(passportID)) : passportID;
        }

        public List<Account> listOfAccounts = new List<Account>();

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

        public override int GetHashCode()
        {
            return PassportID;
        }
    }
}
