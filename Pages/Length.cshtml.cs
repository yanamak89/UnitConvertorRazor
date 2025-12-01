using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UnitConverterRazor.Pages
{
    public class LengthModel : PageModel
    {
        [BindProperty]
        public double? InputValue { get; set; }

        [BindProperty]
        public string FromUnit { get; set; } = "m";

        [BindProperty]
        public string ToUnit { get; set; } = "km";

        public double? Result { get; set; }

        public bool HasResult { get; set; } = false;

        private static readonly Dictionary<string, double> Factors = new()
        {
            ["mm"]   = 0.001,
            ["cm"]   = 0.01,
            ["m"]    = 1.0,
            ["km"]   = 1000.0,
            ["inch"] = 0.0254,
            ["foot"] = 0.3048,
            ["yard"] = 0.9144,
            ["mile"] = 1609.34
        };

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!InputValue.HasValue)
            {
                HasResult = false;
                return;
            }

            if (!Factors.ContainsKey(FromUnit) || !Factors.ContainsKey(ToUnit))
            {
                HasResult = false;
                return;
            }

            double inMeters = InputValue.Value * Factors[FromUnit];
            Result = inMeters / Factors[ToUnit];
            HasResult = true;
        }
    }
}
