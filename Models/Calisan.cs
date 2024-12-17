public class Calisan
{
    public int Id { get; set; }
    public string AdSoyad { get; set; }
    public string UzmanlikAlani { get; set; }
    public bool Musaitlik { get; set; }
    public int SalonId { get; set; }
    public Salon Salon { get; set; }
}