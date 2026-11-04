using ConfettiCo.Data;
using ConfettiCo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConfettiCo.Controllers;

public class EnquiryController(AppDbContext db, ILogger<EnquiryController> logger) : Controller
{
    [HttpGet]
    public IActionResult Create(string? id)
    {
        var model = new Enquiry
        {
            EventTypeSlug = EventData.Find(id)?.Slug ?? EventData.Items[0].Slug,
            EventDate = DateOnly.FromDateTime(DateTime.Today.AddDays(60)),
            Guests = 50,
            BudgetRange = Enquiry.Budgets[1]
        };
        return View(model);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(
        [Bind("FullName,Email,Phone,EventTypeSlug,EventDate,Guests,BudgetRange,Message")] Enquiry model)
    {
        var type = EventData.Find(model.EventTypeSlug);
        if (type is null)
            ModelState.AddModelError(nameof(model.EventTypeSlug), "Please choose one of the event types.");

        if (model.EventDate < DateOnly.FromDateTime(DateTime.Today))
            ModelState.AddModelError(nameof(model.EventDate), "Please choose today or a later date.");

        if (!Enquiry.Budgets.Contains(model.BudgetRange))
            ModelState.AddModelError(nameof(model.BudgetRange), "Choose a budget range from the list.");

        if (!ModelState.IsValid) return View(model);

        try
        {
            model.EventTypeName = type!.Name;
            model.CreatedAtUtc = DateTime.UtcNow;
            db.Enquiries.Add(model);
            await db.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Could not save enquiry");
            ModelState.AddModelError(string.Empty,
                "We couldn't save your enquiry because the database isn't reachable. " +
                "Check the connection string in appsettings.json and run Update-Database.");
            return View(model);
        }

        TempData["Name"] = model.FullName;
        TempData["Type"] = type!.Name;
        TempData["Date"] = model.EventDate.ToString("dddd, d MMMM yyyy");
        return RedirectToAction(nameof(Thanks));
    }

    public IActionResult Thanks()
    {
        if (TempData["Name"] is null) return RedirectToAction(nameof(Create));
        return View();
    }
}
