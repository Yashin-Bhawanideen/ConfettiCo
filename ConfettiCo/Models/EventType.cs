namespace ConfettiCo.Models;

public record EventType(
    string Slug,
    string Name,
    string Tagline,
    string Description,
    decimal FromPrice,
    string Guests,
    string Color,
    string[] Includes,
    string[] Themes)
{
    public string Image => $"{Slug}.svg";
}

public static class EventData
{
    // Prices are illustrative starting points for a demo website.
    public static readonly IReadOnlyList<EventType> Items = new List<EventType>
    {
        new("weddings", "Weddings", "Your love story, beautifully told.",
            "From the first venue visit to the last dance, we design and run a wedding that feels like the two of you. Choose full planning, partial planning or day-of coordination.",
            65_000m, "50 to 300 guests", "#ff3d8b",
            new[] { "Full planning or day-of coordination", "Venue sourcing and site visits", "Florals, draping and lighting", "Catering, cake and bar service", "Photography, video and live music", "Guest transport and accommodation" },
            new[] { "Garden romance", "Boho barn", "Black-tie classic", "Winelands rustic" }),

        new("birthdays", "Birthdays", "From first birthdays to fabulous fifties.",
            "Milestone birthdays deserve more than a cake in the kitchen. We build the theme, the decor and the schedule so the birthday star can simply enjoy the night.",
            12_000m, "10 to 150 guests", "#ffb800",
            new[] { "Theme concept and decor", "Cake and dessert tables", "DJ or curated playlist", "Balloon art and photo corner", "Party favours and games" },
            new[] { "Neon glow", "Garden brunch", "Retro disco", "Casino night" }),

        new("corporate", "Corporate Events", "Conferences, galas and team days that run on time.",
            "Your people and clients notice the details. We handle logistics, branding and on-the-day management so your event reflects well on your business.",
            35_000m, "30 to 600 guests", "#3d9bff",
            new[] { "Venue, staging and AV", "Registration and name tags", "Catering and branded bars", "MC, speakers and entertainment", "Photography and live streaming" },
            new[] { "Year-end function", "Awards gala", "Strategy offsite", "Team-building day" }),

        new("baby-showers", "Baby Showers", "Sweet, soft and totally photogenic.",
            "A gentle, joyful celebration for the parents-to-be. We take care of the styling, the sweet treats and the games, so you can focus on the guest of honour.",
            8_500m, "15 to 60 guests", "#9b7bff",
            new[] { "Themed decor and balloon arches", "Dessert table and cupcakes", "Games and keepsakes", "Photo corner", "Set-up and pack-down" },
            new[] { "Little cloud", "Safari babies", "Boho rainbow", "Twinkle twinkle" }),

        new("anniversaries", "Anniversaries", "Celebrate every year together.",
            "Whether it's a quiet dinner for two or a party for the whole family, we design a celebration that honours your story and your style.",
            15_000m, "10 to 120 guests", "#ff7a2f",
            new[] { "Dinner or party design", "Florals and candlelight", "Photo memory wall", "Live music or playlist", "Surprise coordination" },
            new[] { "Candlelit dinner", "Vow renewal", "Garden lunch", "Rooftop sunset" }),

        new("graduations", "Matric Dances and Graduations", "Proud moments, proper parties.",
            "A big night for big achievers. We style the entrance, the dance floor and the photo areas so every learner and parent feels like a star.",
            18_000m, "40 to 400 guests", "#19b5a5",
            new[] { "Entrance and venue styling", "Red-carpet photo area", "DJ, lighting and sound", "Catering and mocktail bar", "Photography" },
            new[] { "Red carpet", "Great Gatsby", "Enchanted forest", "Hollywood" }),

        new("product-launches", "Product Launches", "Make the big reveal unforgettable.",
            "Launches need a moment people will talk about and share. We design the concept, the staging and the guest experience around your product.",
            45_000m, "50 to 500 guests", "#7a5cff",
            new[] { "Concept and stage design", "Lighting, AV and effects", "Media and influencer management", "Canapes and branded drinks", "Content capture" },
            new[] { "Immersive pop-up", "Cocktail reveal", "Gallery style", "Tech showcase" }),

        new("kids-parties", "Kids' Parties", "Sticky fingers, big smiles.",
            "We bring the entertainment, the decor and the cleanup crew. You bring the birthday child and a camera.",
            6_500m, "10 to 50 children", "#ff9f1c",
            new[] { "Themed decor", "Entertainers, face painting and jumping castles", "Kiddie catering", "Cake and party packs", "Full clean-up" },
            new[] { "Dinosaurs", "Princess tea party", "Superheroes", "Under the sea" }),

        new("engagements", "Engagement Parties", "Say yes to a great celebration.",
            "The first big party of your journey together. Relaxed, stylish and full of the people who matter most.",
            14_000m, "20 to 150 guests", "#ef476f",
            new[] { "Reveal moment design", "Florals and styling", "Cocktails and canapes", "Photographer", "Music and sound" },
            new[] { "Rooftop cocktails", "Garden tea", "Picnic proposal", "Dinner under the stars" }),
    };

    public static EventType? Find(string? slug) =>
        Items.FirstOrDefault(e => string.Equals(e.Slug, slug, StringComparison.OrdinalIgnoreCase));
}
