using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLesson_Delegate_
{
    public class BankAccount
    {
        public delegate void AccountMessageHandler(string message);
        
        public int Sum { get; private set; }
        private AccountMessageHandler _messageHandler;

        public void DeligateRegister(AccountMessageHandler messageHandler)
        {
            _messageHandler = messageHandler;
        }
        public void Add(int sum)
        {
            Sum = Sum + sum;
            _messageHandler.Invoke($"На ваш счет поступила сумма: {sum}");
        }
    }

    class TestClass
    {
        private void TestMethod()
        {
            var testFunc = new Func<string, float, bool, int>(TestMethodWithParams);
            var result = testFunc.Invoke("", 0f, true);
        }

        private int TestMethodWithParams(string str, float fl, bool b)
        {
            return 0;
        }
    }

}
