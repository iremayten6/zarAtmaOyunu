using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            int toplamSkor = 0;   //Değişkenleri tanımladım ve nesne oluşturdum.
            int atmaHakki = 0;
            int sayiTut = 0;
            Random rastgele = new Random();
            int[] zarSayisi = new int[50];


            Console.Write("Lütfen oyuncunun ismini giriniz:"); // Gerekli bilgileri kişiden girmesini istedim.
            string ad = Console.ReadLine();
            Console.Write("Lütfen oyuncunun soyismini giriniz: ");
            string soyad = Console.ReadLine();
            Console.Write("Lütfen doğduğunuz ayı MM olacak şekilde giriniz:");
            int dogumTarihi = Convert.ToInt32(Console.ReadLine());

            int adKarakterSayisi = ad.Length;
            int soyadKarakterSayisi = soyad.Length;
          
            if (dogumTarihi<= 6)  // İlgili durumlardaki puanları ekledim ve çıkardım.
            {
                toplamSkor += 30;
            }
            else
            {
                toplamSkor -= 20;
            }

            if (adKarakterSayisi > soyadKarakterSayisi)
            {
                toplamSkor += 50;
            }
            else if (adKarakterSayisi == soyadKarakterSayisi)
            {
                toplamSkor += 25;
            }
            else
            {
                toplamSkor -= 10;
            }


            while (atmaHakki < 10)           //Döngü kullanarak gelen sayıyı kontrol ettim.
            {
                int zar = rastgele.Next(1, 7);
                zarSayisi[sayiTut] = zar;
                sayiTut++;
                Console.WriteLine("Zar atılıyor... Gelen sayı: " + zar);

                if (zar == 1)
                {
                    Console.WriteLine("Kaybettiniz.");
                    toplamSkor -= 75;
                    atmaHakki++;
                }
                else if (zar == 6)
                {
                    Console.WriteLine("Kazandınız!");

                    toplamSkor += 100;
                    Console.WriteLine("Toplam puan: " + toplamSkor);

                    atmaHakki++;
                }
                else
                {
                    Console.WriteLine("Tekrar zar atılıyor.");
                    
                }
            }

            if (toplamSkor >= 500) //Kazanma kaybetme durumunu kontrol ettim.
            {
                Console.WriteLine(sayiTut + ".zar Atışında Oyunu kazandınız! Toplam puan : " + toplamSkor);

            }
            else
            {
                Console.WriteLine(sayiTut + ".Zar Atışında Oyunu kaybettiniz... Toplam puan : " + toplamSkor);

            }


            Console.WriteLine("Atılan zarların sonuçları:"); //Tüm durumları ekrana yazdırdım.
            for (int i = 0; i < sayiTut; i++)
            {
                Console.WriteLine("Zar {0}: {1}", i + 1, zarSayisi[i]);
            }

            Console.ReadLine();

        }
    }
}
