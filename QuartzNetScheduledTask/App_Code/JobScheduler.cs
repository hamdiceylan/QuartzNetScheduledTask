using Quartz;
using Quartz.Impl;
using System;

namespace QuartzNetScheduledTask.App_Code
{
    public class JobScheduler
    {
        public static void Start()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();

            IJobDetail job = JobBuilder.Create<Push>().Build();

            ITrigger trigger = TriggerBuilder.Create()
            .WithIdentity("trigger", "group")
            .StartNow()
            .WithSimpleSchedule(x => x
            .WithIntervalInSeconds(10)
            .RepeatForever())
            .Build();

            scheduler.ScheduleJob(job, trigger);
        }
    }
}