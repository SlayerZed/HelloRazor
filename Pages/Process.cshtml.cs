using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloRazor.Pages
{
    public class ProcessModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = "This is our first day in the 2024 Fall Term";
            string[] people = { "John", "Jane", "Jack", "Jill" };
            ViewData["People"] = people;

        }
    }
}