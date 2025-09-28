using SnapFolio.Models;

namespace SnapFolio.ViewModels;

public class HomeVM
{
    public List<SkillsCategory> Categories { get; set; }
    public List<Experience> Experiences { get; set; }
    public List<Education> Educations { get; set; }
}