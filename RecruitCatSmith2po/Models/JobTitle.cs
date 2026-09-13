namespace RecruitCatSmith2po.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public decimal MinimumSalary { get; set; }

        public decimal MaximumSalary { get; set; }

        public string Description { get; set; } = string.Empty;

        public int YearsOfExperience { get; set; }

        public List<Candidate> Candidates { get; set; } = new List<Candidate>();
    }
}