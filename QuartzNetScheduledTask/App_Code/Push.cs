using Quartz;
using System;


namespace QuartzNetScheduledTask.App_Code
{
    public class Push :IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            //This method will run every 10 seconds which setted in JobScheduler class with following code
            //ITrigger trigger = TriggerBuilder.Create()
            //.WithIdentity("trigger1", "group1")
            //.StartNow()
            //.WithSimpleSchedule(x => x
            //.WithIntervalInSeconds(10)
            //.RepeatForever())
            //.Build();
        }
    }
}