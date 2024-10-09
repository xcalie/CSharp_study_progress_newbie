namespace _101_enumeration
{   
    enum Job
    {
        worker,
        teacher,
        sweeper
    };

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Job job = Job.worker;
            switch (job)
            {
                case Job.worker:
                case Job.teacher:
                    Console.WriteLine(job);
                    break;
                case Job.sweeper:
                    Console.WriteLine(job);
                    break;
            }


            Int32 number = (Int32)job;
            Console.WriteLine(number);

            job = (Job)1;
            Console.WriteLine(job);

            string str = job.ToString();
            Console.WriteLine(str);

            job = (Job)Enum.Parse(typeof(Job), "worker");
            Console.WriteLine(job);

        }
    }
}
