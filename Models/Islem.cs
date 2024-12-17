public class Islem
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public decimal Ucret { get; set; }
    public int Sure { get; set; } // dakika cinsinden
    public int SalonId { get; set; }
    public Salon Salon { get; set; }
}