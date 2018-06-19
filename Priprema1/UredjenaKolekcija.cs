using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema1
{
    class UredjenaKolekcija : Kolekcija, Uredjivac
    {
        private char status = '/';

        public UredjenaKolekcija(int x) : base(x)
        {

        }

        public void Sort(char status)
        {
            Student T;

            if (status == '>')
            {
                //to-do
                for (int i = 0; i < trenutni - 1; i++)
                {
                    for (int j = i + 1; j < trenutni; j++)
                    {
                        if (Students[i] < Students[j])
                        {
                            T = Students[i];
                            Students[i] = Students[j];
                            Students[j] = T;
                        }
                    }
                }
                this.status = status;
            }
            else if (status == '<')
            {
                //to-do
                for (int i = 0; i < trenutni - 1; i++)
                {
                    for (int j = i + 1; j < trenutni; j++)
                    {
                        if (Students[i] > Students[j])
                        {
                            T = Students[i];
                            Students[i] = Students[j];
                            Students[j] = T;
                        }
                    }
                }
                this.status = status;
            }
            else Console.WriteLine("Invalid sotr order");
        }
    }
}
