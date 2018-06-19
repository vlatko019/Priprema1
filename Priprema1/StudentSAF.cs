using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema1
{
    class StudentSAF : Student
    {
        private double pismeni;
        private double seminarski;

        public StudentSAF(double pismeni, double seminarski, int brIndeksa, string ime, string prezime) : base(brIndeksa, ime, prezime)
        {
            this.pismeni = pismeni;
            this.seminarski = seminarski;
        }

        public override double getPTS()
        {
            return pismeni + seminarski;
        }
    }
}
