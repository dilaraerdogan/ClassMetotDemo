using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " "+ musteri.Adi+ " "+ musteri.Soyadi+ " "+ musteri.Yas +"\n Bilgilerine sahip müşteri bankamızın kayıtlarına eklendi");
            Console.WriteLine("-------------");
        }
        public void MusteriListeleme(Musteri[] musteriler)
        {
            foreach(Musteri customer in musteriler)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Adi);
                Console.WriteLine(customer.Soyadi);
                Console.WriteLine(customer.Yas);
                Console.WriteLine("-------------");
            }
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Yas + "\n Bilgilerine sahip müşteri bankamızın kayıtlarından silindi");
            Console.WriteLine("------------");
        }

    }
}
