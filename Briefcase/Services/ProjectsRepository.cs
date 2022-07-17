using Briefcase.Models;

namespace Briefcase.Services;

public interface IProjectsRepository
{
    List<Project> GetProjects();
}
public class ProjectsRepository : IProjectsRepository
{
    public List<Project> GetProjects() 
    {
        return new List<Project>()
        {
            new(               
                    "Web-API Rest with ASP.NET",
                    " Architecture Pattern Layers Middleware, OpenAPI(swagger)",
                    "/images/web_api.png" ,
                    "https://github.com/jeqx/Hogwarts"
                ),

            new(                
                    "Landing Page with ASP.NET-MVC",
                    "Architecture Pattern MVC, HTML, CSS, Razor",
                    "/images/asp_net_core_mvc.png" ,
                    "https://github.com/jeqx/"
                ),

            new(               
                    "Web-API Rest with ASP.NET",
                    " Architecture Pattern Layers Middleware, OpenAPI(swagger)",
                    "/images/web_api.png" ,
                    "https://github.com/jeqx/Hogwarts"
                ),

            new Project
                (                
                    "Landing Page with ASP.NET-MVC",
                    "Architecture Pattern MVC, HTML, CSS, Razor",
                    "/images/asp_net_core_mvc.png" ,
                    "https://github.com/jeqx/"
                ),
            new Project
                (               
                    "Web-API Rest with ASP.NET",
                    " Architecture Pattern Layers Middleware, OpenAPI(swagger)",
                    "/images/web_api.png" ,
                    "https://github.com/jeqx/Hogwarts"
                ),
            new Project
                (                
                    "Landing Page with ASP.NET-MVC",
                    "Architecture Pattern MVC, HTML, CSS, Razor",
                    "/images/asp_net_core_mvc.png" ,
                    "https://github.com/jeqx/"
                )
        }; 
    }        
}
