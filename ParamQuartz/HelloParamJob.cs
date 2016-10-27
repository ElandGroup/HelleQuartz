using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;

namespace HelloQuartzCron
{
    public class HelloParamJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            JobDataMap jobMap = context.JobDetail.JobDataMap;

            Console.WriteLine(@"Hello param " +jobMap.GetString("jobtalk") +@" "+ DateTime.Now.ToString("yyyyMMdd HH:mm:ss"));
        }
    }
}
