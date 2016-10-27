# HelleQuartz

##command

```sh
git init
git remote add origin  https://github.com/ElandGroup/HelleQuartz.git
git pull origin master
```
```sh
git clone https://github.com/ElandGroup/HelleQuartz.git
```
##Steps

```sh
//1.create scheduler
IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();

//2.start scheduler
scheduler.Start();

//3.create job
IJobDetail jobDetail = JobBuilder.Create<HelloParamJob>()
                        .WithIdentity("job1", "jobGroup1")
                        .Build();

//4.create trigger
ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("trigger1", "triggerGroup1")
                    .WithCronSchedule("0/2 * * * * ?")
                    .Build();

//5. mapping job and trigger
scheduler.ScheduleJob(jobDetail, trigger);
```