using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Musteri
    {
        public int id { get; set; }
        public string adsoyad { get; set; }
        public int yas { get; set; }
        public double maas { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }

        public Musteri(int id, string adsoyad, int yas, double maas, string il, string ilce)
        {
            this.id = id;
            this.adsoyad = adsoyad;
            this.yas = yas;
            this.maas = maas;
            this.il = il;
            this.ilce = ilce;
        }
    }
}
