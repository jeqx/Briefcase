namespace Briefcase.Models
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool ShowAge { get; set; }
        public string? LinkPhoto { get; set; }
        public List<Project>? Projects { get; set; }

    }
    
    public record PersonDto
    (
        string FirstName, 
        string LastName, 
        DateTime BirthDate,
        bool ShowAge,
        List<Project> Projects 
    );
}
