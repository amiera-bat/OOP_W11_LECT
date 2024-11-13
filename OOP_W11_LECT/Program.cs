// See https://aka.ms/new-console-template for more information
using OOP_W11_LECT;

//Job job = new Job() { Name = "WashDish", Description = "Use Soap" };

/* Need special type of jobs
 * one time job - has a certain fixed start and end date (DateTime)
 * recurring Job - has a certain date when it wa last done and a certain time interval (TimeSpan) before the next execution
*/

//List<Job> jobs = new List<Job>();


OneTimeJob otjob = new OneTimeJob() 
{ 
    Name = "RepairRoof", 
    Description= "Leaks", 
    Date = DateTime.Now
};

RecurringJob RJob = new RecurringJob()
{
    Name = "Wash Dish",
    Description = "Kitchen Job",
    LastDone = DateTime.Now,
    timeBeforeNext = new TimeSpan(1,0, 0),
};

JobList jobList = new JobList();

jobList.AddJob(job);
jobList.AddJob(otjob);
jobList.AddJob(RJob);
//jobs.Add(RecurringJob);

jobList.Report();

Account acc = new Account();
acc.Add(RJob);
acc.Add(otjob);
