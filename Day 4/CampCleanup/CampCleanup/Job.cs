using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampCleanup
{
    public class Job
    {        
        public class Assignment
        {
            public int Start { get; set; }
            public int End { get; set; }

            public Assignment(string assignment)
            {
                Start = Convert.ToInt32(assignment.Split('-')[0]);
                End = Convert.ToInt32(assignment.Split('-')[1]);
            }
        }

        public List<Assignment> assignments = new List<Assignment>();

        public Job(string assignments)
        {
            foreach(var assignment in assignments.Split(','))
            {
                this.assignments.Add(new Assignment(assignment));
            }
        }

    }
}
