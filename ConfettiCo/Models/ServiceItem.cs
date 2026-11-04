namespace ConfettiCo.Models;

public record ServiceItem(string Name, string Summary, string Icon, string Color, string[] Details);

public static class ServiceData
{
    public static readonly IReadOnlyList<ServiceItem> Items = new List<ServiceItem>
    {
        new("Planning and coordination", "One planner, one plan, zero stress.", "planning.svg", "#ff3d8b",
            new[] { "Budget and timeline", "Supplier management", "Run sheet and on-the-day team" }),
        new("Decor and styling", "Colour, flowers, lighting and the details guests photograph.", "decor.svg", "#ffb800",
            new[] { "Theme and mood boards", "Florals and balloon art", "Table styling and signage" }),
        new("Catering and bar", "Menus built around your guests, from canapes to sit-down dinners.", "catering.svg", "#ff7a2f",
            new[] { "Tasting sessions", "Dietary and halal options", "Cocktail and mocktail bars" }),
        new("Entertainment", "DJs, bands, MCs and surprises that keep the dance floor full.", "entertainment.svg", "#7a5cff",
            new[] { "DJs and live bands", "MCs and presenters", "Kids' entertainers" }),
        new("Photography and video", "Candid, colourful memories you will want to relive.", "photo.svg", "#3d9bff",
            new[] { "Photographers and videographers", "Photo booths and 360 cameras", "Same-week preview gallery" }),
        new("Venue sourcing", "We know the venues and we negotiate on your behalf.", "venue.svg", "#19b5a5",
            new[] { "Shortlist and site visits", "Layout and capacity planning", "Contract review" }),
        new("Equipment hire", "Marquees, furniture, lighting and AV delivered and set up.", "equipment.svg", "#ef476f",
            new[] { "Tents and dance floors", "Tables, chairs and lounge sets", "Sound, lighting and screens" }),
        new("Invitations and RSVPs", "Beautiful invitations and a guest list that manages itself.", "invitations.svg", "#9b7bff",
            new[] { "Printed and digital invitations", "RSVP tracking", "Seating plans" }),
    };
}
