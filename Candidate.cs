namespace recuritcat_vutukubi_.Models
{
    public class Candidate
    {

        public int Id { get; set; }

        // First Name of the Candidate
        public String FirstName { get; set; }

        // Last Name of the Candidate
        public String LastName { get; set; }

        // Candidate's Target Salary
        public double TargetSalary { get; set; }


        public DateTime? StartDate { get; set; }

        // new properties

        public int? CompanyId { get; set; }

        public Company? Company { get; set; }

        public int JobTitleId { get; set; }

        public JobTitle JobTitle { get; set; }

        public int IndustryId { get; set; }

        public Industry Industry { get; set; }
    }
}
