using Microsoft.AspNetCore.Mvc;

namespace StudentManagementSystem.Controllers
{
    [Route("ErrorPage/{statusCode}")]
    public class ErrorPageController : Controller
    {
        public IActionResult Index(int statusCode)
        {
            switch(statusCode)
            {
                case 404:
                    ViewData["Error"] = "Sorry, the resource you requested could not be found";
                    break;
                case 500:
                    ViewData["Error"] = "Sorry, something went wrong on the server";
                    break;
                default:
                    ViewData["Error"] = "Sorry, something went wrong";
                    break;
            }
            return View("ErrorPage");
        }
    }
}
