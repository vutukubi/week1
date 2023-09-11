namespace recuritcat_vutukubi_.Models
{
    public class Company
    {

        public int Id { get; set; }
        public String Name { get; set; }

        public String Position { get; set; }

        public double MinimumSalary { get; set; }

        public double MaximumSalary { get; set;}

        public DateTime? StartDate { get; set; }

        public String Location { get; set; }

        // new properties

        public ICollection<Candidate> Candidates { get; set; }

        public int IndustryId { get; set; }

        public Industry Industry { get; set; }

    }
}
