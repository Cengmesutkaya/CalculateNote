using System;
using System.Collections.Generic;
using System.IO;

namespace CalculateNote
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "student.txt";
            string[] satirlar = null;
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            try
            {
                 satirlar = File.ReadAllLines(path);

            }
            catch (Exception e)
            {

                Console.WriteLine("Dosya Okunamadı:");
                Console.WriteLine(e.Message); 
            }
        
                foreach (string satir in satirlar)
            {
                string[] bilgiler = satir.Split(' ');
                string ad = bilgiler[0];
                int numara = int.Parse(bilgiler[1]);
                double vizeNotu = double.Parse(bilgiler[2]);
                double finalNotu = double.Parse(bilgiler[3]);
                Ogrenci ogrenci = new Ogrenci(ad, numara, vizeNotu, finalNotu);
                ogrenciler.Add(ogrenci);
            }

            // Öğrenci bilgilerini yazdırma
            foreach (Ogrenci ogrenci in ogrenciler)
            {
                ogrenci.OgrenciYazdir();
            }
        }
    }
}
