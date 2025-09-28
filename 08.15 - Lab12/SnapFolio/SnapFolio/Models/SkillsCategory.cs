namespace SnapFolio.Models;

public class SkillsCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<SkillItem>? Items { get; set; }
}
