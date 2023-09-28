using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoriniai
{
    internal class Program
    {
        //KLASE SKIRTA SIJONO DUOMENIMS SAUGOTI
        class Sijonas
        {
            private string sModPavad;//sijono modelio pavadinimas
            private string sMedPavad;//sijono medziagos pavadinimas
            private double ilgis;//sijono medziagos ilgis(cm)
            private double plotis;//sijono medziagos plotis(cm)
            private int atrKiekis;//sijono atraizu kiekis(%)
            private int minutes1;//laiko sanaudos(min)
            private int minutes2;//laiko sanaudos(min)
            private int minutes3;//laiko sanaudos(min)

            public Sijonas(string sModPavad, string sMedPavad,
                double ilgis, double plotis, int atrKiekis)
            {
                this.sModPavad = sModPavad;
                this.sMedPavad = sMedPavad;
                this.ilgis = ilgis;
                this.plotis = plotis;
                this.atrKiekis = atrKiekis;
            }

            public Sijonas(int minutes1, int minutes2, int minutes3)
            {
                this.minutes1 = minutes1;
                this.minutes2 = minutes2;
                this.minutes3 = minutes3;
            }

            //grazina modelio pavadinima
            public string ImtiSModPavad() { return sModPavad; }

            //grazina medziagos pavadinima
            public string ImtiMedPavad() { return sMedPavad; }

            //grazina ilgio pavadinima
            public double ImtiIgi() { return ilgis; }

            //grazina ploti
            public double ImtiPloti() { return plotis; }

            //grazina atraizu kieki
            public int ImtiAtrKiekis() { return atrKiekis; }

            //grazina minutes
            public int ImtiMinutes1() { return minutes1; }

            public int ImtiMinutes2() { return minutes2; }

            public int ImtiMinutes3() { return minutes3; }
        }

        //KLASE SKIRTA SIUVYKLOS DUOMENIMS SAUGOTI
        class Siuvykla
        {
            private string siuvPavad;//siuvyklos pavadinimas
            private int pirmSijon;//pirmo sijono kiekis
            private int antrSijon;//antro sijono kiekis
            private int trecSijon;//trecio sijono kiekis
            private int siuvSkaicius;//siuveju skaicius

            public Siuvykla(string siuvPavad, int pirmSijon, int antrSijon,
                int trecSijon)
            {
                this.siuvPavad = siuvPavad;
                this.pirmSijon = pirmSijon;
                this.antrSijon = antrSijon;
                this.trecSijon = trecSijon;
            }

            public Siuvykla(int siuvSkaicius)
            {
                this.siuvSkaicius = siuvSkaicius;
            }

            //grazina siuvyklos pavadinima
            public string ImtiSiuvPavad() { return siuvPavad; }

            //grazina pirmojo sinojo kieki
            public int ImtiPirmKieki() { return pirmSijon; }

            //grazina antrojo sijono kieki
            public int ImtiAntrKieki() { return antrSijon; }

            //grazina treciojo sijono kieki
            public int ImtiTrecKieki() { return trecSijon; }

            //grazina siuveju skaiciu
            public int ImtiSiuvejuSk() { return siuvSkaicius; }
        }

        static void Main(string[] args)
        {
            //pirmo modelio sijono duomenys
            /*string modPavad1;
            string medPavad1;
            double ilgis1;
            double plotis1;
            int atrKiekis1;
            Console.WriteLine("Pirmas sijonas:");
            Console.Write("Įveskite pirmojo sijono modelio pavadinimą: ");
            modPavad1 = Console.ReadLine();
            Console.Write("Įveskite pirmojo sijono medžiagos pavadinimą: ");
            medPavad1 = Console.ReadLine();
            Console.Write("Įveskite pirmojo sijono modelio ilgį(cm): ");
            ilgis1 = int.Parse(Console.ReadLine());
            Console.Write("Įveskite pirmojo sijono modelio ploti(cm): ");
            plotis1 = int.Parse(Console.ReadLine());
            Console.Write("Įveskite pirmojo sijono atraižų kiekį(%): ");
            atrKiekis1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");*/
            Sijonas s1;
            s1 = new Sijonas("Modelis1", "MPav1", 6.2, 4.3, 12);

            //antro modelio sijono duomenys
            /*string modPavad2;
            string medPavad2;
            double ilgis2;
            double plotis2;
            int atrKiekis2;
            Console.WriteLine("Antras sijonas:");
            Console.Write("Įveskite antrojo sijono modelio pavadinimą: ");
            modPavad2 = Console.ReadLine();
            Console.Write("Įveskite antrojo sijono medžiagos pavadinimą: ");
            medPavad2 = Console.ReadLine();
            Console.Write("Įveskite antrojo sijono modelio ilgį(cm): ");
            ilgis2 = int.Parse(Console.ReadLine());
            Console.Write("Įveskite antrojo sijono modelio ploti(cm): ");
            plotis2 = int.Parse(Console.ReadLine());
            Console.Write("Įveskite antrojo sijono atraižų kiekį(%): ");
            atrKiekis2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");*/
            Sijonas s2;
            s2 = new Sijonas("Modelis2", "MPav2", 3.4, 1.3, 11);

            //trecio modelio sijono duomenys
            /*string modPavad3;
            string medPavad3;
            double ilgis3;
            double plotis3;
            int atrKiekis3;
            Console.WriteLine("Trecias sijonas:");
            Console.Write("Įveskite trečiojo sijono modelio pavadinimą: ");
            modPavad3 = Console.ReadLine();
            Console.Write("Įveskite trečiojo sijono medžiagos pavadinimą: ");
            medPavad3 = Console.ReadLine();
            Console.Write("Įveskite trečiojo sijono modelio ilgį(cm): ");
            ilgis3 = int.Parse(Console.ReadLine());
            Console.Write("Įveskite trečiojo sijono modelio ploti(cm): ");
            plotis3 = int.Parse(Console.ReadLine());
            Console.Write("Įveskite trečiojo sijono atraižų kiekį(%): ");
            atrKiekis3 = int.Parse(Console.ReadLine());
            Console.Clear();*/
            Sijonas s3;
            s3 = new Sijonas("Modelis3", "MPav3", 4.5, 2.6, 11);

            //duomenys spausdinami i lentele
            Console.WriteLine("------------------------------------------------------------" +
                "----------------");
            Console.WriteLine("Modelis            Medziaga            Ilgis          Plotis" +
                "       Atraizos");
            Console.WriteLine("------------------------------------------------------------" +
                "----------------");
            Console.WriteLine("{0}\t   {1}\t    \t{2,3:f2}          \t{3,3:f2}     " +
                "\t{4,3:d}",
                s1.ImtiSModPavad(), s1.ImtiMedPavad(), s1.ImtiIgi(), s1.ImtiPloti(), s1.ImtiAtrKiekis());
            Console.WriteLine("{0}\t   {1}\t    \t{2,3:f2}          \t{3,3:f2}     " +
                "\t{4,3:d}",
                s2.ImtiSModPavad(), s2.ImtiMedPavad(), s2.ImtiIgi(), s2.ImtiPloti(), s2.ImtiAtrKiekis());
            Console.WriteLine("{0}\t   {1}\t    \t{2,3:f2}          \t{3,3:f2}     " +
                "\t{4,3:d}",
                s3.ImtiSModPavad(), s3.ImtiMedPavad(), s3.ImtiIgi(), s3.ImtiPloti(), s3.ImtiAtrKiekis());
            Console.WriteLine("");

            //randa, kuriam sijonui reikes daugiausiai medziagos
            double medziaga1 = KiekMedziagos(s1);
            double medziaga2 = KiekMedziagos(s2);
            double medziaga3 = KiekMedziagos(s3);
            if (medziaga1 > medziaga2 && medziaga1 > medziaga3)
            {
                Console.WriteLine("Daugiausiai medziagos reikes {0} sijonui", s1.ImtiSModPavad());
            }
            else
                if (medziaga2 > medziaga1 && medziaga2 > medziaga3)
            {
                Console.WriteLine("Daugiausiai medziagos reikes {0} sijonui", s2.ImtiSModPavad());
            }
            else
                if (medziaga3 > medziaga1 && medziaga3 > medziaga2)
            {
                Console.WriteLine("Daugiausiai medziagos reikes {0} sijonui", s3.ImtiSModPavad());
            }
            else
                if (medziaga1 == medziaga2)
            {
                Console.WriteLine("Daugiausiai medziagos reikes {0} ir {1} sijonams",
                    s1.ImtiSModPavad(), s2.ImtiSModPavad());
            }
            else
                if (medziaga1 == medziaga3)
            {
                Console.WriteLine("Daugiausiai medziagos reikes {0} ir {1} sijonams",
                    s1.ImtiSModPavad(), s3.ImtiSModPavad());
            }
            else
                if (medziaga2 == medziaga3)
            {
                Console.WriteLine("Daugiausiai medziagos reikes {0} ir {1} sijonams",
                    s2.ImtiSModPavad(), s3.ImtiSModPavad());
            }

            //randa, kuriam sijonui reikes maziausiai atraizu
            double atraizos1 = s1.ImtiAtrKiekis();
            double atraizos2 = s2.ImtiAtrKiekis();
            double atraizos3 = s3.ImtiAtrKiekis();
            if (atraizos1 < atraizos2 && atraizos1 < atraizos3)
            {
                Console.WriteLine("Maziausiai atraizu liks nuo {0} sijono", s1.ImtiSModPavad());
            }
            else
                if (atraizos2 < atraizos1 && atraizos2 < atraizos3)
            {
                Console.WriteLine("Maziausiai atraizu liks nuo {0} sijono", s2.ImtiSModPavad());
            }
            else
                if (atraizos3 < atraizos1 && atraizos3 < atraizos2)
            {
                Console.WriteLine("Maziausiai atraizu liks nuo {0} sijono", s3.ImtiSModPavad());
            }
            else
                if (atraizos1 == atraizos2)
            {
                Console.WriteLine("Maziausiai atraizu liks nuo {0} ir {1} sijonu",
                    s1.ImtiSModPavad(), s2.ImtiSModPavad());
            }
            else
                if (atraizos1 == atraizos3)
            {
                Console.WriteLine("Maziausiai atraizu liks nuo {0} ir {1} sijonu",
                    s1.ImtiSModPavad(), s3.ImtiSModPavad());
            }
            else
                if (atraizos2 == atraizos3)
            {
                Console.WriteLine("Maziausiai atraizu liks nuo {0} ir {1} sijonu",
                    s2.ImtiSModPavad(), s3.ImtiSModPavad());
            }
            Console.WriteLine("");

            //ivedami siuvyklos duomenys
            /*string siuvPavad;
            int kiek1;
            int kiek2;
            int kiek3;
            Console.Write("Iveskite siuvyklos pavadinima: ");
            siuvPavad = Console.ReadLine();
            Console.Write("Iveskite, kiek reikia pagaminti {0} modelio sijonu " +
                "per savaite: ", s1.ImtiSModPavad());
            kiek1 = int.Parse(Console.ReadLine());
            Console.Write("Iveskite, kiek reikia pagaminti {0} modelio sijonu " +
                "per savaite: ", s2.ImtiSModPavad());
            kiek2 = int.Parse(Console.ReadLine());
            Console.Write("Iveskite, kiek reikia pagaminti {0} modelio sijonu " +
                "per savaite: ", s3.ImtiSModPavad());
            kiek3 = int.Parse(Console.ReadLine());
            Console.WriteLine("");*/
            Siuvykla siuv;
            siuv = new Siuvykla("Siuvykla1", 123, 99, 67);

            //duomenys spausdinami lenteleje
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("{0}\t {1}\t {2}", s1.ImtiSModPavad(), s2.ImtiSModPavad(), s3.ImtiSModPavad());
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("     {0,3:d}\t     {1,3:d}\t      {2,3:d}", siuv.ImtiPirmKieki(),
                siuv.ImtiAntrKieki(), siuv.ImtiTrecKieki());
            Console.WriteLine("");

            //ivedamos minutes
            /*int minutes;
            Console.Write("Iveskite laiko sanaudas(minutemis) skirtas sijonams " +
                "pasiuti per savaite: ");
            minutes = int.Parse(Console.ReadLine());*/
            Sijonas s4;
            s4 = new Sijonas(23, 35, 47);

            Console.WriteLine("{0} sijonui reikes {1}min", s1.ImtiSModPavad(), s4.ImtiMinutes1());
            Console.WriteLine("{0} sijonui reikes {1}min", s2.ImtiSModPavad(), s4.ImtiMinutes2());
            Console.WriteLine("{0} sijonui reikes {1}min", s3.ImtiSModPavad(), s4.ImtiMinutes3());
            Console.WriteLine("");

            //ivedamos laiko sanaudos
            Console.WriteLine("{0} sijono modelius pasiuti reikes per {1}min",
                s1.ImtiSModPavad(), PirmasSijonas(s4, siuv));
            Console.WriteLine("{0} sijono modelius pasiuti reikes per {1}min",
                s2.ImtiSModPavad(), AntrasSijonas(s4, siuv));
            Console.WriteLine("{0} sijono modelius pasiuti reikes per {1}min",
                s3.ImtiSModPavad(), TreciasSijonas(s4, siuv));
            Console.WriteLine("");

            //ivedamas siuveju skaicius
            /*int siuvSkaicius;
            Console.Write("Iveskite kiek dirba siuveju {0} siuvykloje: ",
                siuvPavad);
            siuvSkaicius = int.Parse(Console.ReadLine());*/
            Siuvykla siuv1;
            siuv1 = new Siuvykla(5);

            Console.WriteLine("{0} dirba {1} siuvejos", siuv.ImtiSiuvPavad(), siuv1.ImtiSiuvejuSk());
            Console.WriteLine("");

            Console.WriteLine("Is viso sijonu pasiuti reikia: {0}",
                IsVisoSijonu(siuv));

            //ar siuvykla spes per 40h pasiuti reikiama kieki sijonu
            if (Laikas(siuv, siuv1) <= 2400)
                Console.WriteLine("Siuvykla spes pagaminti reikiama kieki sijonu.");
            else
                Console.WriteLine("Siuvykla nespes pagaminti reikiamo kiekio sijonu.");
            Console.WriteLine("");
        }

        /// <summary>
        /// Suskaiciuoja kiek medziagos reikia sijonui pasiuti
        /// </summary>
        /// <param name="s">sijono duomenys</param>
        /// <returns></returns>
        static double KiekMedziagos(Sijonas s)
        {
            return s.ImtiIgi() * s.ImtiPloti();
        }

        /// <summary>
        /// Suskaiciuoja laiko sanaudas pirmo modelio sijonams
        /// </summary>
        /// <param name="s">sijono duomenys</param>
        /// <param name="si">siuvyklos duomenys</param>
        /// <returns></returns>
        static int PirmasSijonas(Sijonas s, Siuvykla si)
        {
            int laikas;
            laikas = s.ImtiMinutes1() * si.ImtiPirmKieki();
            return laikas;
        }

        /// <summary>
        /// Suskaiciuoja laiko sanaudas antro modelio sijonams
        /// </summary>
        /// <param name="s">sijono duomenys</param>
        /// <param name="si">siuvyklos duomenys</param>
        /// <returns></returns>
        static int AntrasSijonas(Sijonas s, Siuvykla si)
        {
            int laikas;
            laikas = s.ImtiMinutes2() * si.ImtiAntrKieki();
            return laikas;
        }

        /// <summary>
        /// Suskaiciuoja laiko sanaudas trecio modelio sijonams
        /// </summary>
        /// <param name="s">sijono duomenys</param>
        /// <param name="si">siuvyklos duomneys</param>
        /// <returns></returns>
        static int TreciasSijonas(Sijonas s, Siuvykla si)
        {
            int laikas;
            laikas = s.ImtiMinutes3() * si.ImtiTrecKieki();
            return laikas;
        }

        /// <summary>
        /// Suskaiciuoja kiek is viso reikia sijonu
        /// </summary>
        /// <param name="siuv">siuvyklos duomenys</param>
        /// <returns></returns>
        static int IsVisoSijonu(Siuvykla siuv)
        {
            int kiek;
            kiek = siuv.ImtiPirmKieki() + siuv.ImtiAntrKieki() + siuv.ImtiTrecKieki();
            return kiek;
        }

        /// <summary>
        /// Suskaiciuoja ar spes pasiuti sijonus per tam tikra laika
        /// </summary>
        /// <param name="siuv">siuvyklos duomenys</param>
        /// <param name="siuvejos">siuveju skaicius</param>
        /// <returns></returns>
        static double Laikas(Siuvykla siuv, Siuvykla siuvejos)
        {
            double laikas;
            laikas = (IsVisoSijonu(siuv) * 2400) / siuvejos.ImtiSiuvejuSk();
            return laikas;
        }
    }
}