using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
    /// <summary>
    /// [실습] Razor 표현식 사용하기 
    /// </summary>
    public class RazorDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Demo1()
        {
            return View();
        }

        public IActionResult Demo2()
        {
            return View();
        }
    }
}
