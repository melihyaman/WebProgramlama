
namespace WebProgramlama.Models
{
    public class Kuafor
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string CalismaSaatleri { get; set; }

        // Bir salonun işlemleri ve çalışanları
        public List<Islem> Islemler { get; set; }
        public List<Calisan> Calisanlar { get; set; }
    }
}