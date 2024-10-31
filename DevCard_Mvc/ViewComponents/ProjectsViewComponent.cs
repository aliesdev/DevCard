using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Mvc.ViewComponents;

public class ProjectsViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var projects = new List<Project>
        {
            new Project(1, "C#", "Programming lamguage", "csharp", "project-1.jpg"),
            new Project(2, "C++", "Programming lamguage", "c++", "project-2.jpg"),
            new Project(3, "Python", "Programming lamguage", "python", "project-3.jpg"),
            new Project(4, "java", "Programming lamguage", "java", "project-4.jpg"),
            
        };
        return View("_Projects", projects);
    }
}