using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema1
{
    class Program
    {
        static void Main(string[] args)
        {
            UredjenaKolekcija UK;
            UK = new UredjenaKolekcija(100);

            StudentFIB A, B;
            A = new StudentFIB(100, 100, 100, 111, "aaa", "ss");
            B = new StudentFIB(80, 80, 80, 555, "ddd", "fff");

            StudentSAF C, D;
            C = new StudentSAF(79, 79, 888, "qqq", "www");
            D = new StudentSAF(99, 100, 999, "yyy", "sss");

            UK.addStudent(A);
            UK.addStudent(B);
            UK.addStudent(C);
            UK.addStudent(D);

            UK.Sort('<');
            UK.showStudents();
            UK.Sort('>');
            UK.showStudents();
            
        }
    }
}
