using Microsoft.EntityFrameworkCore;
using WebProgramlama.Models;

namespace WebProgramlama.data
{
    public class KuaforContext : DbContext
    {
        public KuaforContext(DbContextOptions<KuaforContext> options)
            : base(options)
        {
        }

        // Kuaförleri temsil eden DbSet
        public DbSet<Kuafor> Salonlar { get; set; }

        // Çalışanları temsil eden DbSet
        public DbSet<Calisan> Calisanlar { get; set; }

        // Randevuları temsil eden DbSet
        public DbSet<Randevu> Randevular { get; set; }

        // Fluent API yapılandırmaları
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Kuaför ile Çalışan ilişkisi (Bir Kuaför birden fazla Çalışana sahip olabilir)
            modelBuilder.Entity<Calisan>()
                .HasOne(c => c.Kuafor)
                .WithMany(k => k.Calisanlar)
                .HasForeignKey(c => c.SalonId);

          
    }
    }
}
