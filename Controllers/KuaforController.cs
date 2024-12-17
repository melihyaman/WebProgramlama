using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebProgramlama.Models;



public class KuaforController : Controller
{
    public IActionResult Index()
    {
        // Tüm salonları listeleyecek
        return View();
    }

    public IActionResult Details(int id)
    {
        // Bir salon detaylarını gösterecek
        return View();
    }
}