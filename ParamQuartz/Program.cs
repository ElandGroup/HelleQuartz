using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelloQuartzCron;
using Quartz;
using Quartz.Impl;

namespace ParamQuartz
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
            IJobDetail jobDetail = JobBuilder.Create<HelloParamJob>()
                                    .WithIdentity("job1", "jobGroup1")
                                    .UsingJobData("jobtalk","hello world")
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
