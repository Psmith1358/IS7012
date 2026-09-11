public class JobTitle
{
    public int Id { get; set; }
    public string TitleName { get; set; }
    public string Description { get; set; }

    public Company Company { get; set; }
    public int CompanyId { get; set; }
}