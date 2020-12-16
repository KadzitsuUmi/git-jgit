using ConsoleApp8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp8.Kontroller
{
    class OformlenieZakaza
    {
        public double Itogo { get; set; }
        public int Time { get; set; }
        public List<ZakazannoeBlyudo> AYF = new List<ZakazannoeBlyudo>();
        public List<ZakazDannie> AYF2 = new List<ZakazDannie>();
        public bool Vybrat (Bludo Eda, int Kolichvo)
        {
            ZakazannoeBlyudo aaa = new ZakazannoeBlyudo();
            aaa.bludo = Eda;
            aaa.Kolichestvo = Kolichvo;
            AYF.Add(aaa);
            return true;
        }
        public bool Sozdat()
        {
            Itogo = 0;
            foreach (ZakazannoeBlyudo AYF1 in AYF)
            {
                Itogo = AYF1.bludo.Prise * AYF1.Kolichestvo + Itogo;
            }

            Time = 0;
            foreach (ZakazannoeBlyudo AYF1 in AYF)
            {
                if (AYF1.bludo.Time > Time)
                {
                    Time = AYF1.bludo.Time;
                }
            }
            ZakazDannie aaa1 = new ZakazDannie();
            aaa1.SpisokBlyud = AYF;
            aaa1.Summa = Itogo;
            aaa1.Time = Time;
            AYF2.Add(aaa1);
            AYF = new List<ZakazannoeBlyudo>();
            return true;
        }
        
    }
}