using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema1
{
    class StudentFIB : Student
    {
        private double PTS1;
        private double PTS2;
        private double PTSLAB;

        public StudentFIB(double PTS1, double PTS2, double PTSLAB, int index, string ime, string prezime) : base(index, ime, prezime)
        {
            this.PTS1 = PTS1;
            this.PTS2 = PTS2;
            this.PTSLAB = PTSLAB;

        }

        public override double getPTS()
        {
            return PTS1 + PTS2 + PTSLAB;
        }
    }
}
