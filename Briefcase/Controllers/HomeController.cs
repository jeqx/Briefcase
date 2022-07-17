using Briefcase.Models;
using Briefcase.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Briefcase.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonRepository personsRepository;
        private readonly IEmailSendGrisService sendGrisService;
        private readonly IProjectsRepository projectsRepository;

        public HomeController( ILogger<HomeController> logger, 
                               IPersonRepository personsRepository,
                               IEmailSendGrisService sendGrisService,
                               IProjectsRepository projectsRepository)
        {
            _logger = logger;
            this.personsRepository = personsRepository;
            this.sendGrisService = sendGrisService;
            this.projectsRepository = projectsRepository;
        }

        public IActionResult Index()
        {
            personsRepository.Projects = projectsRepository.GetProjects().Take(2).ToList();
            return View( personsRepository );
        }
            
        public IActionResult Projects()
        {
            var projets = projectsRepository.GetProjects();
            return View(projets);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact( Contact contact)
        {
            await sendGrisService.Enviar(contact);
            return RedirectToAction("Thanks");
        }

        public IActionResult Thanks()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}