using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationHW1.Pages
{
    public class Task4Model : PageModel
    {
        public char RandomLetter { get; set; }

        public void OnGet()
        {
            Random random = new Random();
            RandomLetter = (char)('A' + random.Next(0, 26));
        }
    }
}
