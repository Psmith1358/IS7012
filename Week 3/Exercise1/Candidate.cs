public class Candidate
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public JobTitle JobTitle { get; set; }
    public int JobTitleId { get; set; }
}