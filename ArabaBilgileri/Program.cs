using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaBilgileri
{
   class Program
    {
        static void Main (string[] args)
        {
            Araba araba = new Araba()
            {
                Id = 1,
                Marka = "Fiat",
                Model = "Egea",
                Kapi = KapiSayisi.DörtKapılı,
                BeygirGucu = 95,
                TicariMi = false,
                MaksimumHiz = 200,
                Cekisi = Cekis.ÖndenÇekiş,
                SifirdanYuzeHizlanma = 14.37,
                Agirlik = 1270,
                ArabaHacmi = 1368,
            };

            Araba araba2 = new Araba()
            {
                Id = 2,
                Marka = "Mercedes",
                Model = "C200",
                Kapi = KapiSayisi.DörtKapılı,
                BeygirGucu = 184,
                TicariMi = false,
                MaksimumHiz = 234,
                Cekisi = Cekis.Arkadanİtiş,
                SifirdanYuzeHizlanma = 8.1,
                Agirlik = 1385,
                ArabaHacmi = 2143

            };

            Console.WriteLine("***Araba Bilgileri***");
            Console.WriteLine("Id: " + araba.Id);
            Console.WriteLine("Marka: " + araba.Marka);
            Console.WriteLine("Model: " + araba.Model);
            Console.WriteLine("Kapi: " + araba.Kapi);
            Console.WriteLine("Beygir Gücü: " + araba.BeygirGucu + " HP");
            Console.WriteLine("Ticari Mi: " + (araba.TicariMi ? "Evet" : "Hayır"));
            Console.WriteLine("Maksimum Hız: " + araba.MaksimumHiz + "km/s");
            Console.WriteLine("Çekiş: " + araba.Cekisi);
            Console.WriteLine("Sıfırdan Yüze Hızlanma: " + araba.SifirdanYuzeHizlanma + "m/sn");
            Console.WriteLine("Ağırlık: " + araba.Agirlik + "kg");
            Console.WriteLine("Araba Hacmi: " + araba.ArabaHacmi + "cm3");
            Console.WriteLine("\n");
            Console.WriteLine("Id: " + araba2.Id);
            Console.WriteLine("Marka: " + araba2.Marka);
            Console.WriteLine("Model: " + araba2.Model);
            Console.WriteLine("Kapi: " + araba2.Kapi);
            Console.WriteLine("Beygir Gücü: " + araba2.BeygirGucu + " HP");
            Console.WriteLine("Ticari Mi: " + (araba2.TicariMi ? "Evet" : "Hayır"));
            Console.WriteLine("Maksimum Hız: " + araba2.MaksimumHiz + "km/s");
            Console.WriteLine("Çekiş: " + araba2.Cekisi);
            Console.WriteLine("Sıfırdan Yüze Hızlanma: " + araba2.SifirdanYuzeHizlanma + "m/sn");
            Console.WriteLine("Ağırlık: " + araba2.Agirlik + "kg");
            Console.WriteLine("Araba Hacmi: " + araba2.ArabaHacmi + "cm3");


            Console.ReadLine();
        }
    }
}
