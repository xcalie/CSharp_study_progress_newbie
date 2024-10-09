namespace _017_switch
{
    internal class Program
    {
        enum Job
        { 
            worker,
            teacher,
            sweeper
        };

        static void Main(string[] args)
        {
            Job job = Job.worker;
            switch (job)
            {
                case Job.worker:
                    break;
                case Job.teacher:
                    break;
                case Job.sweeper:
                    break;
            }        
        }
    }
}
