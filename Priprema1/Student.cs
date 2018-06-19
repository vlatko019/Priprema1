using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema1
{
    public abstract class Student
    {
        private int brIndeksa;
        private string ime;
        private string prezime;

        public Student(int brIndeksa, string ime, string prezime)
        {
            this.brIndeksa = brIndeksa;
            this.ime = ime;
            this.prezime = prezime;
        }

        public abstract double getPTS();

        public override string ToString()
        {
            return brIndeksa + " " + ime + " " + prezime;
        }

        public static bool operator <(Student S1, Student S2)
        {
            return S1.getPTS() < S2.getPTS();
        }

        public static bool operator >(Student S1, Student S2)
        {
            return S1.getPTS() > S2.getPTS();
        }


    }
}
