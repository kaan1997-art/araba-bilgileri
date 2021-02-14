using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaBilgileri
{
    public class Araba
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public KapiSayisi Kapi { get; set; }
        public short BeygirGucu { get; set; }
        public bool TicariMi { get; set; }
        public int MaksimumHiz { get; set; }
        public Cekis Cekisi { get; set; }
        public double SifirdanYuzeHizlanma { get; set; }
        public short Agirlik { get; set; }
        public int ArabaHacmi { get; set; }

    }
}
