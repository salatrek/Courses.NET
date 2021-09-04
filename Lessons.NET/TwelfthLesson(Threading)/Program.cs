using System;
using System.Collections.Generic;
using System.Threading;

namespace TwelfthLesson_Threading_
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            var locker = new object();
            var count = 10000;
            var completed = 0;

            ThreadPool.QueueUserWorkItem(_ => // запуск параллельного потока
            {
                var c = count;
                while (c-- > 0)
                {
                    lock (locker) // синхронизация
                    {
                        dict.Add("1_" + c, "hello thread1");
                    }
                }

                Interlocked.Increment(ref completed); // потокобезопасный инкремент числа
            });

            ThreadPool.QueueUserWorkItem(_ => // запуск параллельного потока
            {
                var c = count;
                while (c-- > 0)
                {
                    lock (locker) // синхронизация
                    {
                        dict.Add("2_" + c, "hello thread2");
                    }
                }

                Interlocked.Increment(ref completed); // потокобезопасный инкремент числа
            });

            //while (completed < 2) // ожидание завершения
            //{
            //    Thread.Sleep(25);
            //}
        }

    }
}
