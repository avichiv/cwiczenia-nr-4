using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWICZENIA_NR_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Osoba osoba1 = new Osoba();
            //Osoba osoba2 = new Osoba("Jan", "Kowalski", 1980);
            //Student osoba3 = new Student("Adam","Kowalik",2018,2,5,141505);
            //Student osoba4 = new Student("Jakub", "Krol", 1996, 1, 5, 141223);

            //Console.WriteLine(osoba1.WypiszInfo());
            //Console.WriteLine(osoba2.WypiszInfo());
            //Console.WriteLine(osoba3.WypiszInfo());
            //Console.WriteLine(osoba4.ObliczWiek());
            //osoba4.miejsceZamiekszania = "Olsztyn";

            //Osoba student2 = new Student("Adam","Kowalik",2018,2,5,141505);
            //Console.WriteLine(student2.WypiszInfo());
            Student student3 = new Student();
            Osoba osoba3 = student3;
            Student student4 = (Student)osoba3;
            Console.ReadKey();
        }

    }
}
