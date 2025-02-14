using Microsoft.AspNetCore.Mvc;

namespace MindTrade.Controllers
{
    public class MateriasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Matematica()
        {
            return View();
        }

        public IActionResult Portugues()
        {
            return View();
        }

        public IActionResult Historia()
        {
            return View();
        }

        public IActionResult Quimica()
        {
            return View();
        }

        public IActionResult Biologia()
        {
            return View();
        }

        public IActionResult Geografia()
        {
            return View();
        }


    }
}
