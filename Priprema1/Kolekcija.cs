using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema1
{
    class Kolekcija
    {
        protected int max;
        protected int trenutni;
        protected Student[] Students;

        public Kolekcija(int max)
        {
            this.max = max;
            this.trenutni = 0;
            Students = new Student[max];

        }
        public void addStudent(Student S1)
        {
            if (trenutni < max)
            {
                this.Students[trenutni] = S1;
                trenutni++;
            }
            else
                Console.WriteLine("Failed to add. Stack is full.");

        }
        public void showStudents()
        {
            for (int i = 0; i < trenutni; i++)
            {
                Console.WriteLine(Students[i]);
            }
        }
    }
}
