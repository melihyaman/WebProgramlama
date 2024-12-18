using System;

namespace WebProgramlama.Models
{
    public class Randevu
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }

        // İlişkiler
        public int CalisanId { get; set; }
        public Calisan Calisan { get; set; }
        public int IslemId { get; set; }
        public Islem Islem { get; set; }

        // Müşteri bilgileri
        public string MusteriAdSoyad { get; set; }
        public string MusteriTelefon { get; set; }
    }
}
