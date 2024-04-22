using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateNote
{
    public class Ogrenci
    {
        private string ad;
        private int numara;
        private double vizeNotu;
        private double finalNotu;

        // Constructor
        public Ogrenci(string ad, int numara, double vizeNotu, double finalNotu)
        {
            this.ad = ad;
            this.numara = numara;
            this.vizeNotu = vizeNotu;
            this.finalNotu = finalNotu;
        }

        // Not hesaplama methodu
        private double NotHesapla()
        {
            return (vizeNotu * 0.4) + (finalNotu * 0.6);
        }

        // Öğrenci bilgilerini yazdıran method
        public void OgrenciYazdir()
        {
            double ortalama = NotHesapla();
            Console.WriteLine($"Ogrenci Bilgileri: Adı: {ad}, Numarası: {numara}, Not Ortalaması: {ortalama}");
        }
    }
}
