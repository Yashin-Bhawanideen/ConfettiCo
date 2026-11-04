using Microsoft.AspNetCore.Mvc;

namespace ConfettiCo.Controllers;

public class ServicesController : Controller
{
    public IActionResult Index() => View();
}
