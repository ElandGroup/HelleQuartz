using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;
using Quartz.Impl;

namespace HelloQuartz
{
    class Program
    {
        static void Main(string[] args)
        {
            //从工厂中获取一个调度器实例化
            IScheduler schedular = StdSchedulerFactory.GetDefaultScheduler();
            //开启调度器
            schedular.Start();

            //创建一个作业
            IJobDetail job1 = JobBuilder.Create<HelloJob>()
                                .WithIdentity("job1", "jobGroup1")
                                .Build();

            //创建触发器
            ITrigger trigger1 = TriggerBuilder.Create()
                                .WithIdentity("trigger1", "triggerGroup1")
                                .StartNow()
                                .WithSimpleSchedule(
                                    x => x.WithIntervalInSeconds(5)
                                    .RepeatForever())
                                .Build();

            schedular.ScheduleJob(job1, trigger1);

        }
    }
}
