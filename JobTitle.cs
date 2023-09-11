namespace recuritcat_vutukubi_.Models
{
    public class JobTitle
    {

        public int Id { get; set; }

        // Title of the Job
        public String Title { get; set; }

        // Minimum Salary of the Job
        public double MinimumSalary { get; set; }

        // Maximum Salry of the Job
        public double MaximumSalary { get; set;}

        // new properties
        public ICollection<Candidate> Candidates { get; set; }
    }
}
