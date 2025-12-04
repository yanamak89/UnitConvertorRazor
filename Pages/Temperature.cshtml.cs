using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UnitConverterRazor.Pages
{
    public class TemperatureModel : PageModel
    {
        [BindProperty]
        public double? InputValue { get; set; }

        [BindProperty]
        public string FromUnit { get; set; } = "C";

        [BindProperty]
        public string ToUnit { get; set; } = "F";

        public double? Result { get; set; }

        public bool HasResult { get; set; } = false;

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

            double value = InputValue.Value;

            double inCelsius = FromUnit switch
            {
                "C" => value,
                "F" => (value - 32.0) * 5.0 / 9.0,
                "K" => value - 273.15,
                _   => double.NaN
            };

            if (double.IsNaN(inCelsius))
            {
                HasResult = false;
                return;
            }

            Result = ToUnit switch
            {
                "C" => inCelsius,
                "F" => inCelsius * 9.0 / 5.0 + 32.0,
                "K" => inCelsius + 273.15,
                _   => double.NaN
            };

            HasResult = !double.IsNaN(Result.Value);
        }
    }
}
