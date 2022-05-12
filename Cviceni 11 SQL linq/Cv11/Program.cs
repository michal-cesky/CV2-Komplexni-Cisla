using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv11
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dc = new LINQDataContext())
            {
                fillData(dc);

                var studentpredmet = StudentPredmet(dc, "BANA");
                var predmetstudent = PredmetStudent(dc, 1003);

                var prumer = from a in dc.Hodnocenis
                             group a by a.ZkratkaPredmet into k
                             select new
                             {
                                 k.Key,
                                 average = k.Average(p => p.Znamka)
                             };

                foreach (var entry in prumer)
                {
                    Console.WriteLine("Predmet: {0} prumerna znamka: {1}", entry.Key, entry.average);
                    Console.ReadLine();
                }
            }


        }

        public static IEnumerable<Student> StudentPredmet(LINQDataContext dc, string Zkratka)
        {
            return (from a in dc.StudentPredmets
                    where a.ZkratkaPredmet == Zkratka
                    select a.Student);
        }

        public static IEnumerable<Predmet> PredmetStudent(LINQDataContext dc, int studentID)
        {
            return (from a in dc.StudentPredmets
                    where a.IdStudent == studentID
                    select a.Predmet); ;
        }

        public static void fillData(LINQDataContext dc)
        {
            if (!dc.Students.Any(s => s.Id == 0))
            {
                dc.Students.InsertOnSubmit(entity: new Student()
                {
                    Jmeno = "Tomáš",
                    Prijmeni = "Caha",
                    DatumNarozeni = DateTime.Today

                }) ;
            }
            dc.SubmitChanges();
            if (!dc.Students.Any(s => s.Id == 123456))
            {
                dc.Students.InsertOnSubmit(entity: new Student()
                {
                    Id = 123456,
                    Jmeno = "Michal",
                    Prijmeni = "Cesky",
                    DatumNarozeni = DateTime.Today

                }) ;
            }
            dc.SubmitChanges();
            if (!dc.Students.Any(s => s.Id == 230000))
            {
                dc.Students.InsertOnSubmit(entity: new Student()
                {
                    Id = 230000,
                    Jmeno = "Radek",
                    Prijmeni = "Vomocil",
                    DatumNarozeni = DateTime.Today

                });
            }
            dc.SubmitChanges();
            if (!dc.Students.Any(s => s.Id == 230230))
            {
                dc.Students.InsertOnSubmit(entity: new Student()
                {
                    Id = 230230,
                    Jmeno = "Natalie",
                    Prijmeni = "Vychodilova",
                    DatumNarozeni = DateTime.Today

                });
            }
            dc.SubmitChanges();

            Predmet[] newPredmet = 
            {
                new Predmet() { Zkratka = "OOP", Nazev = "Objektově orientované programování" },
                new Predmet() { Zkratka = "PC2T", Nazev = "Počítače a programování 2" },
            };

            StudentPredmet[] newStudentPredmet =
            {
                new StudentPredmet() { IdStudent = 123456, ZkratkaPredmet = "OOP" },
                new StudentPredmet() { IdStudent = 230000, ZkratkaPredmet = "PC2T" },
                new StudentPredmet() { IdStudent = 230230, ZkratkaPredmet = "OOP" },
            };

            Hodnoceni[] newHodnoceni =
            {
                new Hodnoceni() { IdStudent = 123456, ZkratkaPredmet = "OOP", Datum = DateTime.Today, Znamka = 1},
                new Hodnoceni() { IdStudent = 123456, ZkratkaPredmet = "PC2T", Datum = DateTime.Today, Znamka = 3},
                new Hodnoceni() { IdStudent = 230000, ZkratkaPredmet = "PC2T", Datum = DateTime.Today, Znamka = 2 },
                new Hodnoceni() { IdStudent = 230230, ZkratkaPredmet = "OOP", Datum = DateTime.Today, Znamka = 1 },
             };

            foreach (Predmet s in newPredmet)
            {
                if (!dc.Predmets.Any(sub => sub.Zkratka == s.Zkratka))
                {
                    dc.SubmitChanges();
                }
            }


            foreach (StudentPredmet s in newStudentPredmet)
            {
                if (!dc.StudentPredmets.Any(sub => sub.IdStudent == s.IdStudent))
                {
                    dc.SubmitChanges();
                }
            }

            foreach (Hodnoceni s in newHodnoceni)
            {
                if (!dc.Hodnocenis.Any(sub => (sub.IdStudent == s.IdStudent) && (sub.ZkratkaPredmet == s.ZkratkaPredmet)))
                {
                    dc.SubmitChanges();
                }
            }
        }
    }
}


