using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insaatfirmasi
{
    public class Sahabolumu
    { 
        public Guid ID { get; set; }
        public string Kalipci { get; set; }
        public string Sivaci { get; set; }
        public string Demirci { get; set; }
        public string Tesisatci { get; set; }
        
    }

    public class Sahacalisanlari
    {
        public Guid ID { get; set; }
        public Sahabolumu Sahabolumu { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
     
    }

    public class Ofisbolumu
    {
        public Guid ID { get; set; }
        public string Pazarlamaci { get; set; }
        public string Muhasebeci { get; set; }
        public string Temizlikgorevlisi { get; set; }
    }

    public class Ofiscalisanlari
    {
        public Guid ID { get; set; }
        public Ofisbolumu Ofisbolumu { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

    }


    public class Maaslar
    {
        public Guid ID { get; set; }
        public Sahacalisanlari Sahacalisanlari { get; set; }
        public Ofiscalisanlari Ofiscalisanlari { get; set; }
        public double Maas { get; set; }
    }

    public class Maliyetler
    {
        public Guid ID { get; set; }
        public Maaslar Maaslar { get; set; }    
        public double Maliyet { get; set; }
    }

    public class Musteri
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }



    public class Ev
    {
        public Guid ID { get; set; }
        public Maliyetler Maliyetler { get; set; }
        public Musteri Musteri { get; set; }
        public double Fiyat { get; set; }
        public DateTime Ay { get; set; }
        public string Metrekare { get; set; }

    }


}
