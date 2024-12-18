using Microsoft.AspNetCore.Mvc;
using WebProgramlama.Data;
using WebProgramlama.Models;

namespace WebProgramlama.Controllers
{
    public class KuaforController : Controller
    {
        private readonly KuaforContext _context;

        public KuaforController(KuaforContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var salonlar = _context.Salonlar.ToList();
            return View(salonlar);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Kuafor kuafor)
        {
            if (ModelState.IsValid)
            {
                _context.Salonlar.Add(kuafor);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kuafor);
        }
    }
}
