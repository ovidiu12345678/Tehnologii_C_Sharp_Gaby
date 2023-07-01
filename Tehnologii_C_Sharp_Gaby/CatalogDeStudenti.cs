using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehnologii_C_Sharp_Gaby
{
   public class CatalogDeStudenti
    {
      
        
            private List<Student> studenti;

            public CatalogDeStudenti()
            {
                this.studenti = new List<Student>();
            }

            public void CitesteStudenti() 
            {
                Console.Write("Introdu numarul de studenti: ");
                int numarStudenti = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                for (int i = 0; i < numarStudenti; i++)
                {
                    Console.Write("Introdu numele studentului: ");
                    string nume = Console.ReadLine();

                    Console.Write("Introdu prenumele studentului: ");
                    string prenume = Console.ReadLine();

                    Console.WriteLine(" ");

                    Console.WriteLine("Introduceti varsta : ");
                    int varsta = int.Parse(Console.ReadLine());

                    Console.WriteLine("Introduceti specializarea studentului ! ");
                    Console.WriteLine(" ");
                    string specializareStudent = Console.ReadLine();

                    studenti.Add(new Student(nume, prenume, specializareStudent, varsta));
                    Console.WriteLine(" ");


                }


            }

            public void AfiseazaStudentii()
            {
                Console.WriteLine("Acestia sunt studenti : ");

                foreach (var student in studenti)
                {
                    Console.WriteLine($"Ma numesc {student.Nume} {student.Prenume} cu varsta de {student.Varsta} de ani  si sunt la facultatea cu specializarea {student.specializare}");
                }
            }
        }

    }