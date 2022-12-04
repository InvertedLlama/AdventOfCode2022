namespace CampCleanup
{
    public class CampCleanup
    {
        public static List<Job> ParseInput(List<string> input)
        {
            var result = new List<Job>();
            foreach (string i in input)
            {
                result.Add(new Job(i));
            }
            return result;
        }

        public static List<Job> GetContainingAssignments(List<Job> parsedInput)
        {
            var result = new List<Job>();

            foreach (Job job in parsedInput)
            {
                var overlap = FindOverlap(job);

                if (overlap)
                    result.Add(job);
            }
            return result;
        }

        private static bool FindOverlap(Job job)
        {
            foreach (Job.Assignment assignment in job.assignments)
            {
                foreach (Job.Assignment assignmentTocompareTo in job.assignments)
                {
                    if (assignment != assignmentTocompareTo)
                    {
                        if(assignment.Start >= assignmentTocompareTo.Start && assignment.End <= assignmentTocompareTo.End)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static List<Job> Temp(List<Job> parsedInput)
        {
            var result = new List<Job>();

            foreach(Job job in parsedInput)
            {
                var overlap = false;

                foreach (Job jobTocompareTo in parsedInput)
                {
                    if (jobTocompareTo != job)
                    {
                        foreach (Job.Assignment assignment in job.assignments)
                        {
                            foreach (Job.Assignment assignmentTocompareTo in jobTocompareTo.assignments)
                            {
                                overlap = assignment.Start >= assignmentTocompareTo.Start && assignment.End <= assignmentTocompareTo.End;
                            }
                        }
                    }
                }

                if (overlap)
                    result.Add(job);
            }
            return result;
        }
    }
}