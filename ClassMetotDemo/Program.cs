using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 06703;
            musteri1.Adi = "Dilçağ";
            musteri1.Soyadi = "Terzi";
            musteri1.Yas = 25;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 05462;
            musteri2.Adi = "Berkan";
            musteri2.Soyadi = "Öztürk";
            musteri2.Yas = 30;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 05489;
            musteri3.Adi = "Dila";
            musteri3.Soyadi = "Koçar";
            musteri3.Yas = 45;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 05479;
            musteri4.Adi = "Duru";
            musteri4.Soyadi = "Akbağ";
            musteri4.Yas = 32;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);
            
            Musteri[] listeleme = new Musteri[] {musteri1,musteri2,musteri3,musteri4};
            musteriManager.MusteriListeleme(listeleme);

            musteriManager.MusteriSilme(musteri2);
            musteriManager.MusteriSilme(musteri3);

            Musteri[] listeleme2 = new Musteri[] { musteri1, musteri4 };
            musteriManager.MusteriListeleme(listeleme2);

        }
    }
}
