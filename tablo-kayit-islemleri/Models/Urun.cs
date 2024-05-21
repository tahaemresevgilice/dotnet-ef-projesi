using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tablo_kayit_islemleri.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string ?UrunAdi { get; set; }
        public int Fiyat { get; set; }
        public int Stok { get; set; }
        public string ?Aciklama { get; set; }
    }
}