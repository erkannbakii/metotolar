namespace metotolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string urunAdi = "Elma";
           // double fiyati = 15;
           //string aciklama = "amasya elmasi";

            //string[] meyveler = new string[] {"elma","karpuz"};

            Urunler urun1 = new Urunler();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urunler urun2 = new Urunler();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urunler[] yazdır = new Urunler[] {urun1, urun2};

            foreach (var urun in yazdır)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------------");
            }

            Console.WriteLine("-----------------Metotlar-----------------");

            SepetMenager sepetMenager = new SepetMenager();
            sepetMenager.Ekle(urun1);
            sepetMenager.Ekle(urun2);

            sepetMenager.Ekle2("armut", "kabaköy armudu", 20, 5);
            sepetMenager.Ekle2("erik", "kütür kütür", 25, 10);
            sepetMenager.Ekle2("kiraz", "napolyon", 17, 8);
        }
    }
}