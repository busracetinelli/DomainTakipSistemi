using System;

namespace DomainTakipSistemiWeb.DTO
{
    public class ProjeDto
    {
        public int id { get; set; }
        public string Proje_Adi { get; set; }
        public string Proje_Tipleri { get; set; }
        public int? Yenileme_Periyodu { get; set; }
        public string Domain_Adi { get; set; }
        public DateTime? Domain_Bitis_Tarihi { get; set; }
        public Double? Domain_Fiyati { get; set; }
        public string Sunucu { get; set; }
        public DateTime? Sunucu_Bitis_Tarihi { get; set; }
        public Double? Sunucu_Fiyati { get; set; }
        public bool? SSL { get; set; }
        public DateTime? SSL_Bitis_Tarihi { get; set; }
        public Double? SSL_Fiyati { get; set; }
        public string Statik_IP { get; set; }
        public DateTime? Statik_IP_Bitis_Tarihi { get; set; }
        public Double? Statik_IP_Fiyati { get; set; }
        public string Metin { get; set; }
    }
}