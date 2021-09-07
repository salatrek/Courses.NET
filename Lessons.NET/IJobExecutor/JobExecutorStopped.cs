using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobExecutor
{
    public class JobExecutorStopped : Exception
    {
        public JobExecutorStopped(string message) : base(message) { }
    }

    public class JobExecutorStarted : Exception
    {
        public JobExecutorStarted(string message) : base(message) { }
    }
}