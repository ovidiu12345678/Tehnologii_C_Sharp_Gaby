using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehnologii_C_Sharp_Gaby
{
    class Student
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string specializare { get; set; }
        public int Varsta { get; set; }
        public Student(string nume, string prenume, string specializare, int varsta)
        {
            this.Nume = nume;
            this.Prenume = prenume;
            this.specializare = specializare;
            this.Varsta  = varsta;
        }

    }
}
