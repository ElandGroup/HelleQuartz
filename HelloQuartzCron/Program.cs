using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;
using Quartz.Impl;

namespace HelloQuartzCron
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.create scheduler
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();

            //2.start scheduler
            scheduler.Start();

            //3.create job
            IJobDetail jobDetail = JobBuilder.Create<HelloCronJob>()
                                    .WithIdentity("job1", "jobGroup1")
                                    .Build();

            //4.create trigger
            ITrigger trigger = TriggerBuilder.Create()
                                .WithIdentity("trigger1", "triggerGroup1")
                                .WithCronSchedule("0/2 * * * * ?")
                                .Build();

            //5. mapping job and trigger
            scheduler.ScheduleJob(jobDetail, trigger);

        }
    }
}
