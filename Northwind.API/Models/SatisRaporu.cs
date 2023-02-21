using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Northwind.API.Models
{
    public partial class SatisRaporu
    {
        public int CalisanId { get; set; }
        public string CalisanAd { get; set; }
        public string MüşteriŞirketAdı { get; set; }
        public string KategoriAdı { get; set; }
        public decimal Fiyat { get; set; }
        public short Adet { get; set; }
    }
}
