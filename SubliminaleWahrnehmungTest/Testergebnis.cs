using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubliminaleWahrnehmungTest
{
    internal class Testergebnis
    {
        int idProband = -1;
        int idBild = -1;
        int gezeigteZiffer = -1;
        TimeSpan time = TimeSpan.Zero;
        bool correct = false;

        public Testergebnis() { }
        public Testergebnis(int idProband, int idBild, int gezeigteZiffer, TimeSpan time, bool correct)
        {
            this.idProband = idProband;
            this.idBild = idBild;
            this.gezeigteZiffer = gezeigteZiffer;
            this.time = time;
            this.correct = correct;
        }

        public int IdProband { get => idProband; set => idProband = value; }
        public int IdBild { get => idBild; set => idBild = value; }
        public int GezeigteZiffer { get => gezeigteZiffer; set => gezeigteZiffer = value; }
        public TimeSpan Time { get => time; set => time = value; }
        public bool Correct { get => correct; set => correct = value; }
    }
}
