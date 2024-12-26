namespace WebProgramlama.Models
{
    public class Islem
    {
        public int Id { get; set; }
        public string ?Ad { get; set; }
        public decimal Ucret { get; set; }
        public int Sure { get; set; }

        // İlişkilendirme
        public int SalonId { get; set; }
        public Kuafor ?Kuafor { get; set; }
    }
}
