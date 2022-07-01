using System;

namespace Sinif_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitaplar kt = new Kitaplar();
            
            Console.WriteLine
                ("Kitap Adını Giriniz :");
            kt.kitapAd = Console.ReadLine();
            
            Console.WriteLine
                ("Yazarın Adını Giriniz :");
            kt.Yazar = Console.ReadLine();
            
            Console.WriteLine
                ("Kitabın Sayfa Sayısını Giriniz :");
            kt.sayfaSayisi = Convert.ToInt32(Console.ReadLine());    
            kt.KitapYazdir();
        }
    }
    class Kitaplar{
        public string kitapAd;
        public string Yazar;
        public int sayfaSayisi;

        public void KitapYazdir(){
            Console.WriteLine("************");
            Console.WriteLine("Kitabın Adı :{0}",kitapAd);
            Console.WriteLine("Kitabın Yazarı :{0}",Yazar);
            Console.WriteLine("Kitabın Sayfa Sayisi :{0}",sayfaSayisi);
        }

    }
}