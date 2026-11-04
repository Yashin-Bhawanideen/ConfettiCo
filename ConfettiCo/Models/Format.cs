using System.Globalization;

namespace ConfettiCo.Models;

public static class Format
{
    /// <summary>South African style: R65 000</summary>
    public static string Money(this decimal value) =>
        "R" + ((long)value).ToString("N0", CultureInfo.InvariantCulture).Replace(",", "\u00A0");
}
