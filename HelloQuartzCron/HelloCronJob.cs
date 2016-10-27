using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;

namespace HelloQuartzCron
{
    public class HelloCronJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine(@"Hello cron " + DateTime.Now.ToString("yyyyMMdd HH:mm:ss"));
        }
    }
}
