using Microsoft.EntityFrameworkCore;
using tablo_kayit_islemleri.Models;

namespace tablo_kayit_islemleri.Models {
    public class DenemeContext : DbContext {
        public DenemeContext() { }
        public DenemeContext(DbContextOptions<DenemeContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SCARYEMRE\\SQLEXPRESS01;Initial Catalog=DenemikiDb;Integrated Security=True;Trusted_Connection=True;Encrypt=False;");
        }

        public DbSet<Urun> Products { get; set; }
    }
}