using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_Mvc.Controllers;

public class HomeController : Controller
{
    private readonly List<Service> services = new List<Service>()
    {
        new Service(1, "نقره ای"),
        new Service(2, "طلایی"),
        new Service(3, "پلاتینی"),
        new Service(4, "الماسی"),
    };

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Contact()
    {
        var contact = new Contact()
        {
            Services = new SelectList(services, "Id", "Name")
        };
        return View(contact);
    }

    [HttpPost]
    public IActionResult Contact(Contact contact)
    {
        contact.Services = new SelectList(services, "Id", "Name");
        if (!ModelState.IsValid)
        {
            ViewBag.error = "Please fill all fields";
            return View(contact);
        }

        ModelState.Clear();
        contact = new Contact()
        {
            Services = new SelectList(services, "Id", "Name"),
        };
        ViewBag.success = "Your contact was successfully added";
        return View(contact);
        // return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}