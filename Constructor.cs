using System;

namespace CompositionOrnek
{
    public class Kapi
    {
        public int Sayi { get; set; }

        public Kapi(int sayi)
        {
            Sayi = sayi;
        }
    }

    public class Pencere
    {
        public int Sayi { get; set; }

        public Pencere(int sayi)
        {
            Sayi = sayi;
        }
    }

    public class Kasa
    {
        public string Tur { get; set; }

        public Kasa(string tur)
        {
            Tur = tur;
        }
    }

    public class Marka
    {
        public string Isim { get; set; }

        public Marka(string isim)
        {
            Isim = isim;
        }
    }

    //Araba sınıfı (Composition)
    public class Araba
    {
        public Marka Marka { get; set; }
        public string Model { get; set; }
        public Kapi Kapi { get; set; }
        public Pencere Pencere { get; set; }
        public Kasa Kasa { get; set; }
        public decimal Fiyat { get; set; }

        public Araba(Marka marka, string model, Kapi kapi, Pencere pencere, Kasa kasa, decimal fiyat)
        {
            Marka = marka;
            Model = model;
            Kapi = kapi;
            Pencere = pencere;
            Kasa = kasa;
            Fiyat = fiyat;
        }

        public void BilgiYazdir()
        {
            Console.WriteLine(
                $"Arabanın markası {Marka.Isim}, " +
                $"modeli {Model}, " +
                $"kapı sayısı {Kapi.Sayi}, " +
                $"pencere sayısı {Pencere.Sayi}, " +
                $"kasası {Kasa.Tur}, " +
                $"fiyatı {Fiyat:N0} TL’dir."
            );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Bileşenlerini oluşturdum
            Marka bmw = new Marka("BMW");
            Kapi kapi = new Kapi(4);
            Pencere pencere = new Pencere(4);
            Kasa kasa = new Kasa("sedan");

            //Araba nesnesinin bilgileri
            Araba araba = new Araba(
                bmw,
                "X5",
                kapi,
                pencere,
                kasa,
                2000000 // Fiyat
            );

            //Print fonksiyonunu çağırdım
            araba.BilgiYazdir();

            Console.ReadLine();
        }
    }
}
