using System;

namespace MethodOverloadingOrnek
{
    public class Matematik
    {
        //Toplama metodu (int olarak)
        public int Topla(int a, int b)
        {
            return a + b;
        }

        public int Topla(int a, int b, int c)
        {
            return a + b + c;
        }

        //Toplama metodu (double)
        public double Topla(double a, double b)
        {
            return a + b;
        }

        public double Topla(double a, double b, double c)
        {
            return a + b + c;
        }

        //Çarpma metodu (int)
        public int Carp(int a, int b)
        {
            return a * b;
        }

        public int Carp(int a, int b, int c)
        {
            return a * b * c;
        }

        //Çarpma metodu (double)
        public double Carp(double a, double b)
        {
            return a * b;
        }

        public double Carp(double a, double b, double c)
        {
            return a * b * c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matematik mat = new Matematik();

            //Toplama örnekleri
            int sonucIntIki = mat.Topla(3, 5);
            int sonucIntUc = mat.Topla(3, 5, 7);
            double sonucDoubleIki = mat.Topla(3.5, 4.5);
            double sonucDoubleUc = mat.Topla(3.5, 4.5, 2.0);

            //Çarpma örnekleri
            int carpimIntIki = mat.Carp(3, 5);
            int carpimIntUc = mat.Carp(3, 5, 2);
            double carpimDoubleIki = mat.Carp(2.5, 4.0);
            double carpimDoubleUc = mat.Carp(2.5, 3.5, 2.0);

            Console.WriteLine("Toplama (int) - İki parametre: " + sonucIntIki);
            Console.WriteLine("Toplama (int) - Üç parametre: " + sonucIntUc);
            Console.WriteLine("Toplama (double) - İki parametre: " + sonucDoubleIki);
            Console.WriteLine("Toplama (double) - Üç parametre: " + sonucDoubleUc);

            Console.WriteLine("Çarpma (int) - İki parametre: " + carpimIntIki);
            Console.WriteLine("Çarpma (int) - Üç parametre: " + carpimIntUc);
            Console.WriteLine("Çarpma (double) - İki parametre: " + carpimDoubleIki);
            Console.WriteLine("Çarpma (double) - Üç parametre: " + carpimDoubleUc);

            Console.ReadLine();
        }
    }
}
