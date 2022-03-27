using System;

namespace Cocomo_Modeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesaplamak istediğiniz modeli giriniz: (Ayrık, Yarı, Gömülü)");
            string model = Convert.ToString(Console.ReadLine());
            if (model=="ayrık" || model=="Ayrık")
            {
                Console.Write("Kod satır sayısını giriniz: ");
                int kloc = Convert.ToInt32(Console.ReadLine());
                Ayrik(kloc);
            }
            if (model == "yarı" || model == "Yarı")
            {
                Console.Write("Kod satır sayısını giriniz: ");
                int kloc = Convert.ToInt32(Console.ReadLine());
                Yari(kloc);
            }
            if (model == "gömülü" || model == "Gömülü")
            {
                Console.Write("Kod satır sayısını giriniz: ");
                int kloc = Convert.ToInt32(Console.ReadLine());
                Gomulu(kloc);
            }
            Console.ReadKey();
        }
        public static void Ayrik(int kloc)
        {
            Console.WriteLine("---- Ayrık Model ----");
            double isgücü = 2.4 * (Math.Pow(kloc,1.05));
            isgücü = Math.Round(isgücü, 2);
            double süre = 2.5 * (Math.Pow(isgücü, 0.38));
            süre = Math.Round(süre, 2);
            double personel = isgücü / süre;
            personel = Math.Round(personel, 2);
            double verimlilik = kloc / isgücü;
            verimlilik = Math.Round(verimlilik, 2);
            Console.WriteLine("İş Gücü: "+ isgücü+ " Kişi ay");
            Console.WriteLine("Geliştirme Süresi: "+süre+ " Ay");
            Console.WriteLine("Ortalama Personel Sayısı: "+personel+ " Kişi");
            Console.WriteLine("Verimlilik: " + verimlilik);
        }
        public static void Yari(int kloc)
        {
            Console.WriteLine("---- Yarı Gömülü Model ----");
            double isgücü = 3.0 * (Math.Pow(kloc, 1.12));
            isgücü = Math.Round(isgücü, 2);
            double süre = 2.5 * (Math.Pow(isgücü, 0.35));
            süre = Math.Round(süre, 2);
            double personel = isgücü / süre;
            personel = Math.Round(personel, 2);
            double verimlilik = kloc / isgücü;
            verimlilik = Math.Round(verimlilik, 2);
            Console.WriteLine("İş Gücü: " + isgücü + " Kişi ay");
            Console.WriteLine("Geliştirme Süresi: " + süre + " Ay");
            Console.WriteLine("Ortalama Personel Sayısı: " + personel + " Kişi");
            Console.WriteLine("Verimlilik: " + verimlilik);
        }
        public static void Gomulu(int kloc)
        {
            Console.WriteLine("---- Gömülü Model ----");
            double isgücü = 3.6 * (Math.Pow(kloc, 1.20));
            isgücü = Math.Round(isgücü, 2);
            double süre = 2.5 * (Math.Pow(isgücü, 0.32));
            süre = Math.Round(süre, 2);
            double personel = isgücü / süre;
            personel = Math.Round(personel, 2);
            double verimlilik = kloc / isgücü;
            verimlilik = Math.Round(verimlilik, 2);
            Console.WriteLine("İş Gücü: " + isgücü + " Kişi ay");
            Console.WriteLine("Geliştirme Süresi: " + süre + " Ay");
            Console.WriteLine("Ortalama Personel Sayısı: " + personel + " Kişi");
            Console.WriteLine("Verimlilik: " + verimlilik);
        }
    }
}
