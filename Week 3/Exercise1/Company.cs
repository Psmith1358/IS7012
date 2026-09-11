public class Company
{
    public int Id { get; set; }
    public string CompanyName { get; set; }

    public Industry Industry { get; set; }
    public int IndustryId { get; set; }

    public List<JobTitle> JobTitles { get; set; }
}