using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_ile_listeleme_ortalama_sorusu
{
    internal class Program
    {
        static void Main(string[] args)//2 SİNAV NOTU GİR-ORTALAMA HESAPLA-VERİYİ TUT DİZİ İLE-HESAPLA LİSTELE.
        {
            int i;
            string[] isim = new string[3];
            float[] s1 = new float[3];
            float[] s2 = new float[3];
            float[] ort = new float[3];

            for (i = 0; i < isim.Length; i++)
            {   Console.WriteLine("İSİM GİRİNİZ:");
                isim[i] = Convert.ToString(Console.ReadLine());

                Console.WriteLine("1.sinav notunu giriniz");
                s1[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2.sinav notunu giriniz");
                s2[i] = Convert.ToInt32(Console.ReadLine());
                ort[i] = (s1[i] + s2[i])/2;
            }
            Console.WriteLine("*********");
            Console.WriteLine("");
            for(i=0;i<isim.Length;i++)
            { Console.WriteLine("ÖGRENCİ ADİ:" + isim[i] + "\n" + "1.SİNAV NOTU:" + s1[i] + "\n" + "2.SİNAV NOTU:" + s2[i] + "\n" + "ORTALAMASİ:" + ort[i]); }
           


            Console.Read();
        }
    }
}
