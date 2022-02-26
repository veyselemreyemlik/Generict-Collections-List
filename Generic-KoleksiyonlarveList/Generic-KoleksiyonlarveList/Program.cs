using System;
using System.Collections.Generic; 

namespace Generic_KoleksiyonlarveList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            // T => object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(14);
            sayiListesi.Add(15);
            sayiListesi.Add(19);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Mavi");
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Sarı");
            renkListesi.Add("Mor");

            // Count ile eleman sayısı yazdırma
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            Console.WriteLine("**************************");

            // Foreach ve List.Foreach ile elemanlara erişim
            foreach (int sayi in sayiListesi)
            Console.WriteLine("Sayılar : " + sayi);

            foreach (string renk in renkListesi)
            Console.WriteLine("Renkler : " + renk);

            Console.WriteLine("**************************");


            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            sayiListesi.ForEach(renk => Console.WriteLine(renk));

            Console.WriteLine("**************************");
            // Listeden eleman çıkarma
            sayiListesi.Remove(19);
            renkListesi.Remove("Sarı");
            
            // İndexdeki elemanı çıkarmak
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(0);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            sayiListesi.ForEach(renk => Console.WriteLine(renk));

            // Liste içerisinde arama
            if (sayiListesi.Contains(14))
            {
                Console.WriteLine("Dizi içerisinde 14 numaralı eleman vardır.");
            }
            else
            {
                Console.WriteLine("Dizi içerisinde 14 numaralı eleman yoktur.");
            }

            // Eleman ile İndex'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            // Diziyi List'e çevirmek
            string[] hayvan = { "Kedi", "Köpek", "At", "Ayı" };
            List<string> hayvanListesi = new List<string>(hayvan);

            // Listeyi nasıl temizleriz ?
            hayvanListesi.Clear();

            // Liste içerisinde nesne tutmak
            List<Kullancılar> KullanıcıListesi = new List<Kullancılar>();
            Kullancılar kullanıcı = new Kullancılar();
            kullanıcı.isim = "Veysel";
            kullanıcı.Soyisim = "Yemlik";
            kullanıcı.yası = 22;

            Kullancılar kullanıcı2 = new Kullancılar();
            kullanıcı2.isim = "Emre";
            kullanıcı2.Soyisim = "Yemlik";
            kullanıcı2.yası = 28;

            KullanıcıListesi.Add(kullanıcı);
            KullanıcıListesi.Add(kullanıcı2);

            List<Kullancılar> yeniListe = new List<Kullancılar>();
            yeniListe.Add(new Kullancılar(){
                isim = "Deniz",
                Soyisim = "Arda",
                yası = 20
            });

            foreach (var kullanıcılar in KullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + kullanıcı2.isim);
                Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı2.Soyisim);
                Console.WriteLine("Kullanıcı Yası:" + kullanıcı2.yası);

            }
           // yeniListe.Clear();




        }

    }
    public class Kullancılar
    {
        private string isimler;
        private string soyisim;
        private int yas;

        public string isim { get => isimler; set => isimler = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int yası { get => yas; set => yas = value; }


    }
}
