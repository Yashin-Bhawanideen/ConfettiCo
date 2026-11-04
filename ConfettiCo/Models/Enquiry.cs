using System.ComponentModel.DataAnnotations;

namespace ConfettiCo.Models;

public class Enquiry
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please tell us your name."), StringLength(80)]
    [Display(Name = "Your name")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "We need an email to reply to."), EmailAddress(ErrorMessage = "That email doesn't look right."), StringLength(120)]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Add a phone number so we can call you."), Phone, StringLength(30)]
    public string Phone { get; set; } = string.Empty;

    [Required(ErrorMessage = "Choose the type of event.")]
    [Display(Name = "Type of event")]
    public string EventTypeSlug { get; set; } = string.Empty;

    public string EventTypeName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Pick a date, even if it's a rough one.")]
    [Display(Name = "Event date")]
    public DateOnly EventDate { get; set; }

    [Range(1, 2000, ErrorMessage = "Enter a guest number between 1 and 2000.")]
    [Display(Name = "Number of guests")]
    public int Guests { get; set; } = 50;

    [Required(ErrorMessage = "Choose a budget range."), StringLength(40)]
    [Display(Name = "Budget")]
    public string BudgetRange { get; set; } = string.Empty;

    [StringLength(1000)]
    [Display(Name = "Tell us about your dream event")]
    public string? Message { get; set; }

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public static readonly string[] Budgets =
    {
        "Under R20 000",
        "R20 000 to R50 000",
        "R50 000 to R100 000",
        "R100 000 to R250 000",
        "Over R250 000",
        "Not sure yet"
    };
}
