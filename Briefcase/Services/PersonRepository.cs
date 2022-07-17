using Briefcase.Models;

namespace Briefcase.Services
{
    public interface IPersonRepository
    {
        string? FirstName { get; set; }
        string? LastName { get; set; }
        DateTime BirthDate { get; set; }
        bool ShowAge { get; set; }
        List<Project>? Projects { get; set; }
        string? LinkPhoto { get; set; }
    }
    public class PersonRepository : IPersonRepository
    {
        PersonDto personDto = new PersonDto("FirstName", "LastName", new(day: 01, month: 01, year: 1990), true, new ProjectsRepository().GetProjects());
        public PersonRepository()
        {
            FirstName = personDto.FirstName;
            LastName = personDto.LastName;
            BirthDate = personDto.BirthDate;
            ShowAge = personDto.ShowAge;
            Projects = personDto.Projects;
        }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool ShowAge { get; set; }
        public List<Project>? Projects { get; set; }
        public string? LinkPhoto { get; set; }
    }
}
