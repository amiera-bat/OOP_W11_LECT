using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_W11_LECT
{
    internal class RecurringJob : Job,Payable
    {
        public TimeSpan timeBeforeNext { get; set; }
        public DateTime LastDone { get; set; }

        public override void Report()
        {
            //base = supperclass (job)
            //base.Report();
            Console.WriteLine("********");
            Console.WriteLine(Name + "Last done " + LastDone.ToString());
            Console.WriteLine("Next Scheduled " + (LastDone + timeBeforeNext).ToString());
            Console.WriteLine("******END REPORT******");
        }

        public float CalcCost()
        {
            return 2000;
        }

    }
}
