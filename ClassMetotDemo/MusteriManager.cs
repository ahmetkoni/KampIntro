using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void musteriekle(Musteri musteri)
        {
            Console.WriteLine("eklenen musteri:"+ " " + musteri.Adi);
        }
        public void musteriekle2(Musteri musteri)
        {
            Console.WriteLine("silinen müşteri ve Id'si:" + " " + musteri.Adi + " " + musteri.Id);
        }
        public void musteriekle3(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteri: " +musteri.Adi + " " +musteri.Id+ " " +musteri.Soyadi);
        }
        public void musteriekle4(Musteri musteri)
        {
            Console.WriteLine("silinen müşteri ve Id'si:  "  + musteri.Adi + " " + musteri.Id + " " + musteri.Soyadi+ " "+ musteri.Yası);
        }
    }
}
