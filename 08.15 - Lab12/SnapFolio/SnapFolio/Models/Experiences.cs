namespace SnapFolio.Models;

public class Experience
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Company { get; set; }
    public int StartYear { get; set; }
    public int? EndYear { get; set; }
    public List<ExperienceDetail> Details { get; set; }
}

public class ExperienceDetail
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int ExperienceId { get; set; }
    public Experience Experience { get; set; }
}

public class Education
{
    public int Id { get; set; }
    public string Profession { get; set; }
    public string University { get; set; }
    public int StartYear { get; set; }
    public int? EndYear { get; set; }
    public string Description { get; set; }
}