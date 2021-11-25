using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri(1, "Bilal Karademir", 35, 8500, "İstanbul", "Başakşehir");
            Musteri m2 = new Musteri(2, "Ümit Özkan", 48, 12500, "İstanbul", "Beşiktaş");
            Musteri m3 = new Musteri(3, "Tülay Yılmaz", 53, 10500, "İstanbul", "Bağcılar");
            Musteri m4 = new Musteri(4, "Gülay Günay", 50, 7500, "Sakarya", "Serdiva");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(m1);
            musteriManager.MusteriEkle(m2);
            musteriManager.MusteriEkle(m3);
            musteriManager.MusteriEkle(m4);
            musteriManager.MusterileriGoster();

            musteriManager.MusteriSil(m1);
            Console.WriteLine("**************************");

            musteriManager.MusterileriGoster();

            Console.ReadLine();



        }
    }
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();
        public void MusteriEkle(Musteri m)
        {
            musteriler.Add(m);   
        }
        public void MusteriSil(Musteri m)
        {
            musteriler.Remove(m);
        }
        public void MusterileriGoster()
        {
            foreach(Musteri m in musteriler)
            {
                Console.WriteLine("Müşteri adı-soyadı: " + m.adsoyad + " müşteri yaşı: " + m.yas + " müşteri maaşı: " + m.maas);
            }
        }
    }
}
