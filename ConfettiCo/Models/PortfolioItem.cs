namespace ConfettiCo.Models;

public record PortfolioItem(string Title, string EventName, string Venue, int Guests, string Story, string Image);

public static class PortfolioData
{
    public static readonly IReadOnlyList<PortfolioItem> Items = new List<PortfolioItem>
    {
        new("Lerato and Sipho's garden wedding", "Wedding", "Magalies Valley lodge", 180,
            "Blush florals, long communal tables and a sunset ceremony under a living willow arch.", "portfolio-1.svg"),
        new("Neon Nights: Zoe's 21st", "Birthday", "Rooftop in Hatfield", 90,
            "Glow-in-the-dark cocktails, a neon cake and a DJ who never let the floor empty.", "portfolio-2.svg"),
        new("Khumalo Group year-end gala", "Corporate", "Sandton ballroom", 400,
            "Awards, a live band and a three-course dinner delivered to 400 guests on schedule.", "portfolio-3.svg"),
        new("Little Cloud baby shower", "Baby shower", "Private garden, Waterkloof", 40,
            "Soft pastels, cloud balloon arches and a dessert table that disappeared in minutes.", "portfolio-4.svg"),
        new("Red-carpet matric dance", "Matric dance", "Centurion events venue", 250,
            "A red-carpet arrival, photo wall and a dance floor lit like a Hollywood premiere.", "portfolio-5.svg"),
        new("Nova phone launch", "Product launch", "Johannesburg warehouse", 300,
            "An immersive reveal with LED walls, hands-on demo zones and a dramatic stage unveiling.", "portfolio-6.svg"),
    };
}
