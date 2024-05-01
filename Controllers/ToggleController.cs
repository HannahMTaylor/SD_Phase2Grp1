using Microsoft.AspNetCore.Mvc;

namespace SD_Phase2.Controllers
{
    public class ToggleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //add actionResult for toggle button on referral form page

        //add getAltPage method to determine which view to return based on current view title

        //create popup if alt page doesn't exist
        public IActionResult Error() { }
    }
}
