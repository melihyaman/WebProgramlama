using Microsoft.AspNetCore.Mvc;

public class RandevuController : Controller
{
    public IActionResult Index()
    {
        // Randevuları listele
        return View();
    }

    public IActionResult Create()
    {
        // Yeni randevu oluşturma
        return View();
    }
}