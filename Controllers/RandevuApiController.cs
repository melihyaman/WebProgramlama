using Microsoft.AspNetCore.Mvc;
using WebProgramlama.Models;

[Route("api/[controller]")]
[ApiController]
public class RandevuApiController : ControllerBase
{
    [HttpGet]
    public IActionResult GetRandevular()
    {
        // Randevuları getir
        return Ok();
    }

    [HttpPost]
    public IActionResult AddRandevu([FromBody] Randevu randevu)
    {
        // Yeni randevu ekle
        return Ok();
    }
}
