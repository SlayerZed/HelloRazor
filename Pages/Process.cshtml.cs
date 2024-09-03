using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace HelloRazor.Pages
{
    public class ProcessModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = "This is our first day in the 2024 Fall Term";

            // Get a list of all processes running on the system
            Process[] processList = Process.GetProcesses();

            // Select the process names
            string[] processNames = processList.Select(p => p.ProcessName).ToArray();

            ViewData["People"] = processNames;
        }
    }
}
