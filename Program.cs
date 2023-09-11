using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace İsimSehirLvl1_2
{
    public class Program
    {

        static void Main(string[] args)
        {
            ArrayList cevaplar = new ArrayList();
            Console.WriteLine("İSİM ŞEHİR OYUNUMUZA HOŞGELDİNİZ");
            Console.WriteLine("OYUNA BAŞLAMAK İÇİN BİR TUŞA BASIN");
            Console.ReadLine();
            while (true)
            {
                Random random = new Random();
                string alfabe = "ABCDEFGHIKLMNOPRSTUVYZ";
                char rastgeleHarf = alfabe[random.Next(alfabe.Length)];

                Console.WriteLine("BU OYUNDAKİ HARFİN : " + rastgeleHarf);


                Console.WriteLine("LÜTFEN İSİM GİRİN:");
                string isim = Console.ReadLine();
                Console.WriteLine("LÜTFEN ŞEHİR GİRİN:");
                string sehir = Console.ReadLine();
                Console.WriteLine("LÜTFEN HAYVAN GİRİN");
                string hayvan = Console.ReadLine();
                Console.WriteLine("LÜTFEN BİTKİ GİRİN");
                string bitki = Console.ReadLine();
                Console.WriteLine("LÜTFEN EŞYA GİRİN");
                string esya = Console.ReadLine();
                Console.WriteLine("LÜTFEN ÜLKE GİRİN");
                string ülke = Console.ReadLine();
                Console.WriteLine("LÜTFEN ÜNLÜ İSMİ GİRİN");
                string ünlüAdi = Console.ReadLine();

                string convertedToUpperCaseİsim = isim.ToUpper();
                string convertedToUpperCasesehir = sehir.ToUpper();
                string convertedToUpperCasebitki = bitki.ToUpper();
                string convertedToUpperCasehayvan = hayvan.ToUpper();
                string convertedToUpperCaseesya = esya.ToUpper();
                string convertedToUpperCaseülke = ülke.ToUpper();
                string convertedToUpperCaseünlüAdi = ünlüAdi.ToUpper();
                string convertedtostringrastgeleharf = Convert.ToString(rastgeleHarf);

                if (convertedToUpperCaseİsim.StartsWith(convertedtostringrastgeleharf))
                {
                    Console.WriteLine("Doğru Değer Girdiniz");
                    cevaplar.Add(convertedToUpperCaseİsim);
                    


                }
                else if (convertedToUpperCasesehir.StartsWith(convertedtostringrastgeleharf))
                {
                    cevaplar.Add(sehir.ToUpper());
                   


                }
                else if (convertedToUpperCasebitki.StartsWith(convertedtostringrastgeleharf))
                {
                    cevaplar.Add(bitki.ToLower());
                    

                }
                else if (convertedToUpperCaseesya.StartsWith(convertedtostringrastgeleharf))
                {
                    cevaplar.Add(esya.ToUpper());
                    

                }
                else if (convertedToUpperCaseülke.StartsWith(convertedtostringrastgeleharf))
                {
                    cevaplar.Add(ülke.ToUpper());
                    
                }
                else if (convertedToUpperCaseünlüAdi.StartsWith(convertedtostringrastgeleharf))
                {
                    cevaplar.Add(ünlüAdi.ToUpper());
                    Console.WriteLine(cevaplar.Count * 10);
                }
                else
                {

                    Console.WriteLine("Girdiğiniz Verinin Baş Harfi Oyunun Size Verdiği Harf İle Uyuşmuyor");

                    Console.ReadLine();
                }
            }

        }
    }
}


