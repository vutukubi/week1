namespace recuritcat_vutukubi_.Models
{
    public class Industry
    {
        public int Id { get; set; }

        // Name of the Industry
        public String Name { get; set; }

        // new properties
        public ICollection<Candidate> Candidates { get; set; }

        public ICollection<Company> Companies { get; set; }   
    }
}
