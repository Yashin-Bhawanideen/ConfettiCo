using ConfettiCo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConfettiCo.Controllers;

public class EventsController : Controller
{
    public IActionResult Index() => View(EventData.Items);

    public IActionResult Details(string id)
    {
        var item = EventData.Find(id);
        if (item is null) return NotFound();
        return View(item);
    }
}
