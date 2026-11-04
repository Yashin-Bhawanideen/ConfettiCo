using Microsoft.AspNetCore.Mvc;

namespace ConfettiCo.Controllers;

public class PortfolioController : Controller
{
    public IActionResult Index() => View();
}
