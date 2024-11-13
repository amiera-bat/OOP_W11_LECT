using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W11_LECT
{
    /*
     * Joblist manages a list of job
     * it has the following operation:
     *      - add new job, report on all job
     */
    internal class JobList
    {
        public List<Job> jobs = new List<Job>();

        public JobList()
        {
        }

        public void AddJob(Job job)
        {
            jobs.Add(job);
        }

        public void Report()
        {
            foreach (Job job in jobs)
            {
                /*
                if (job is RecurringJob) //Not utilising polymorphism
                {
                    ((RecurringJob)job).ReportRJ();
                }
                else 
                {
                    ((OneTimeJob)job).ReportOT();
                }
                */

                job.Report();
            }

        }
    }

}
