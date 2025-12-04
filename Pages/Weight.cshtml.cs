using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UnitConverterRazor.Pages
{
    public class WeightModel : PageModel
    {
        [BindProperty]
        public double? InputValue { get; set; }

        [BindProperty]
        public string FromUnit { get; set; } = "kg";

        [BindProperty]
        public string ToUnit { get; set; } = "g";

        public double? Result { get; set; }

        public bool HasResult { get; set; } = false;

        private static readonly Dictionary<string, double> Factors = new()
        {
            ["mg"] = 0.000001,
            ["g"]  = 0.001,
            ["kg"] = 1.0,
            ["oz"] = 0.0283492,
            ["lb"] = 0.453592
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

            double inKg = InputValue.Value * Factors[FromUnit];
            Result = inKg / Factors[ToUnit];
            HasResult = true;
        }
    }
}
