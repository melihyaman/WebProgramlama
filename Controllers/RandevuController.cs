using Microsoft.AspNetCore.Mvc;
using WebProgramlama.data;
using WebProgramlama.Models;

namespace WebProgramlama.Controllers
{
    public class RandevuController : Controller
    {
        private readonly KuaforContext _context;

        public RandevuController(KuaforContext context)
        {
            _context = context;
        }

        public IActionResult Index(int calisanId)
        {
            var randevular = _context.Randevular.Where(r => r.CalisanId == calisanId).ToList();
            return View(randevular);
        }

        public IActionResult Create(int calisanId)
        {
            ViewBag.CalisanId = calisanId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Randevu randevu)
        {
            if (ModelState.IsValid)
            {
                _context.Randevular.Add(randevu);
                _context.SaveChanges();
                return RedirectToAction("Index", new { calisanId = randevu.CalisanId });
            }
            return View(randevu);
        }
    }
}
