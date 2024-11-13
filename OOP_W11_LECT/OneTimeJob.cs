using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W11_LECT
{
    internal class OneTimeJob : Job, Payable //MUST IMPLEMENT "Payable"
    {
        public DateTime Date { get; set; }
        //public DateTime EndDate { get; set; }

        /*
        public OneTimeJob(DateTime start, DateTime end)
        {
            StartDate = start;
            EndDate = end;
        }
        */

        public override void Report() //Overide
        {
            //base = supperclass (job)
            //base.Report();
            Console.WriteLine("Date on " + Date.ToString());
        }

        public float CalcCost()
        {
            return 1000;
        }
    }
}
