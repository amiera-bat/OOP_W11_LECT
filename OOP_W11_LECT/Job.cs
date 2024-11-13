using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W11_LECT
{
    //A Job is consists of a Name and Description
    internal abstract class Job
    {
        public string Name { get; set; }
        public string Description { get; set; }

        /*
        public Job(string name, string description)
        {
            Name = name;
            Description = description;

        }
        */

        public abstract void Report(); //abstract : unimplemented (must implemented in subclass) (class is "not concrete")
        //{
        //    Console.WriteLine("Job : " + Name + " Done");
        //}
    
    
    }

}
