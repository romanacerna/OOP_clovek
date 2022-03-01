using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_clovek
{
    public class clovek
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }
        private int energie;
        public int Energie { get; set; }
        public int Zivot { get; set; }
        private int dovednost;
        public int Dovednost { get; set; }

        public clovek()
        {
            Jmeno = "";
            Prijmeni = "";
            DatumNarozeni = DateTime.Now;
            energie = 100;
            Zivot = 100;
            dovednost = 0;
        }

        public void ZvysitDovednost()
        {
            Dovednost += 20;
            Energie += 10;
        }
    }
}
