using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA230323
{
    internal class Versenyzo
    {
        public string Nev { get; set; }
        public int SzulEv { get; set; }
        public string RajtSzam { get; set; }
        public bool Nem { get; set; }
        public string KorKategoria { get; set; }
        public TimeSpan[] IdoEredmenyek { get; set; }

        public TimeSpan Osszido
        {
            get
            {
                TimeSpan oi = TimeSpan.Zero;
                foreach (var ie in IdoEredmenyek) oi += ie;
                return oi;
            }
        }

        public Versenyzo(string sor)
        {
            string[] v = sor.Split(';');
            Nev = v[0];
            SzulEv = int.Parse(v[1]);
            RajtSzam = v[2];
            Nem = v[3] == "f";
            KorKategoria = v[4];
            IdoEredmenyek = new TimeSpan[5];
            for (int i = 5; i < v.Length; i++)
                IdoEredmenyek[i - 5] = TimeSpan.Parse(v[i]);
        }
    }
}
