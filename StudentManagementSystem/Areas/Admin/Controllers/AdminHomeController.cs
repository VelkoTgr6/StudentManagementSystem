using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StudentManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Administrator")]
    public class AdminHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
