using Microsoft.AspNetCore.Mvc;
using WebProgramlama.Models;

namespace KuaforYonetim.Controllers
{
    public class CalisanController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalisanController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Çalışan Listesi
        public async Task<IActionResult> Index()
        {
            var calisanlar = await _context.Calisanlar.Include(c => c.Salon).ToListAsync();
            return View(calisanlar);
        }

        // Yeni Çalışan Formu
        public IActionResult Create()
        {
            ViewBag.Salonlar = _context.Salonlar.ToList();
            return View();
        }

        // Yeni Çalışan Ekleme İşlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Calisan calisan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(calisan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Salonlar = _context.Salonlar.ToList();
            return View(calisan);
        }

        // Çalışan Detayları
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var calisan = await _context.Calisanlar
                .Include(c => c.Salon)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (calisan == null) return NotFound();

            return View(calisan);
        }

        // Çalışan Düzenleme Formu
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var calisan = await _context.Calisanlar.FindAsync(id);
            if (calisan == null) return NotFound();

            ViewBag.Salonlar = _context.Salonlar.ToList();
            return View(calisan);
        }

        // Çalışan Düzenleme İşlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Calisan calisan)
        {
            if (id != calisan.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calisan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalisanExists(calisan.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Salonlar = _context.Salonlar.ToList();
            return View(calisan);
        }

        // Çalışan Silme Formu
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var calisan = await _context.Calisanlar
                .Include(c => c.Salon)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (calisan == null) return NotFound();

            return View(calisan);
        }

        // Çalışan Silme İşlemi
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var calisan = await _context.Calisanlar.FindAsync(id);
            _context.Calisanlar.Remove(calisan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Çalışan Var mı Kontrol
        private bool CalisanExists(int id)
        {
            return _context.Calisanlar.Any(e => e.Id == id);
        }
    }
}
