using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;

namespace HelloQuartz
{
    public class HelloJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Hello"+DateTime.Now.ToString("yyyyMMdd HH:mm:ss"));
        }
    }
}
