using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotolar
{
    internal class SepetMenager
    {
        public void Ekle (Urunler urun)
        {
            Console.WriteLine("sepete eklendi: " + urun.Adi);
        }
        public void Ekle2 ( string urunAdi , string aciklama, double fiyati, int stokadedi)
        {
            Console.WriteLine( urunAdi + " ürünü: " + aciklama + "'dır/dür. " + fiyati+ "'Tl."+ " Stokta kalan miktar: "+ stokadedi);
        }
    }
}
