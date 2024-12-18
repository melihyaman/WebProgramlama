namespace WebProgramlama.Models
{
    public class Calisan
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string UzmanlikAlani { get; set; }
        public bool Musaitlik { get; set; }

        // İlişkilendirme
        public int SalonId { get; set; }
        public Kuafor Kuafor { get; set; }
    }
}
