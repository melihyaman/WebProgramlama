using Microsoft.AspNetCore.Mvc;
using WebProgramlama.data;
using WebProgramlama.Models;

namespace WebProgramlama.Controllers
{
    public class CalisanController : Controller
    {
        private readonly KuaforContext _context;

        public CalisanController(KuaforContext context)
        {
            _context = context;
        }

        public IActionResult Index(int kuaforId)
        {
            var calisanlar = _context.Calisanlar.Where(c => c.KuaforId == kuaforId).ToList();
            return View(calisanlar);
        }

        public IActionResult Create(int kuaforId)
        {
            ViewBag.KuaforId = kuaforId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Calisan calisan)
        {
            if (ModelState.IsValid)
            {
                _context.Calisanlar.Add(calisan);
                _context.SaveChanges();
                return RedirectToAction("Index", new { kuaforId = calisan.KuaforId });
            }
            return View(calisan);
        }
    }
}
