using System;

namespace Gruppenarbeit_HSP
{
    class Program
    {
        //Modul
        public double Modul(double d, double z)
        {
            double m = d / z;
            return m;
        }

        //Teilung
        public double Teilung(double m)
        {
            double p = Math.PI * m;
            return p;
        }

        //Kopfspiel
        public double Kopfspiel(double m)
        {
            double c = 0.167 * m;
            return c;
        }

        //Kopfkreisdurchmesser außenverzahnt
        public double Kopfkreisdurchmesser_a(double d, double m)
        {
            double da = d + 2 * m;
            return da;
        }

        //Fußkreisdurchmesser außenverzahnt 
        public double Fußkreisdurchmesser_a(double d, double m, double c)
        {
            double df = d - 2 * (m + c);
            return df;
        }

        //Kopfkreisdurchmesser innenverzahnt
        public double Kopfkreisdurchmesser_i(double d, double m)
        {
            double da = d - 2 + m;
            return da;
        }

        //Fußkreisdurchmesser innenverzahnt
        public double Fußkreisdurchmesser_i(double d, double m, double c)
        {
            double df = 2 + 2 * (m + c);
            return df;
        }

        //Grundkreisdurchmesser
        public double Grundkreisdurchmesser(double d)
        {
            double nw = 20 * Math.PI / 180;
            double dg = d * Math.Cos(nw);
            return dg;
        }

        //Zahnkopfhöhe
        public double Zahnkopfhöhe(double m)
        {
            double ha = m;
            return ha;
        }

        //Zahnfußhöhe
        public double Zahnfußhöhe(double m, double c)
        {
            double hf = m + c;
            return hf;
        }

        //Zahnhöhe
        public double Zahnhöhe(double m, double c)
        {
            double h = 2 + m + c;
            return h;
        }

        //Volumen
        public double Volumen(double da, double b)
        {
            double v = Math.Pow(da / 2, 2) * b;
            return v;
        }

        //Achsabstand mit außenliegendem Gegenrad
        public double Achsabstand_a(double d1, double d2)
        {
            double aa = (d2 + d1) / 2;
            return aa;
        }

        //Achsabstand mit innenliegendem Gegenrad
        public double Achsabstand_i(double d1, double d2)
        {
            double ai = (d2 - d1) / 2;
            return ai;
        }
        static void Main(string[] args)
        {

            //Einleitung
            Console.WriteLine("Herzlich Willkommen.");
            Console.WriteLine("Diese Software hilft Ihnen bei der Berechnung von Zahnrädern.");

            Console.WriteLine("");

            //Anweisungen
            Console.WriteLine("Bitte geben Sie die Zähnezahl von Zahnrad1 an und bestätigen anschließend mit Enter: ");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie den Teilkreisdurchmesser [mm] von Zahnrad1 an und bestätigen anschließend mit Enter: ");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die Breite [mm] von Zahnrad1 an und bestätigen sie mit Enter: ");
            double b1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Bitte geben Sie die Zähnezahl von Zahnrad2 an und bestätigen anschließend mit Enter: ");
            int z2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie den Teilkreisdurchmesser [mm] von Zahnrad2 an und bestätigen anschließend mit Enter: ");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die Breite [mm] von Zahnrad2 an und bestätigen sie mit Enter: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte wählen Sie jetzt ob Sie außenverzahnte(1) oder innenverzahnte(2) Zahnräder berechnen möchten und bestätigen anschließend mit Enter.");
            int ii = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Program prg = new Program();

            //außenverzahnte Zahnräder
            if (ii == 1)
            {
                //Ergebnisse Zahnrad1
                double m1 = prg.Modul(d1, z1);
                Console.WriteLine("Modul Zahnrad1: " + m1);
                double p1 = prg.Teilung(m1);
                Console.WriteLine("Teilung Zahnrad1: " + p1);
                double c1 = prg.Kopfspiel(m1);
                Console.WriteLine("Kopfspiel Zahnrad1: " + c1);
                double da1 = prg.Kopfkreisdurchmesser_a(d1, m1);
                Console.WriteLine("Kopfkreisdurchmesser Zahnrad1: " + da1);
                double df1 = prg.Fußkreisdurchmesser_a(d1, m1, c1);
                Console.WriteLine("Fußkreisdurchmesser Zahnrad1: " + df1);
                double dg1 = prg.Grundkreisdurchmesser(d1);
                Console.WriteLine("Grundkreisdurchmesser Zahnrad1: " + dg1);
                double ha1 = prg.Zahnkopfhöhe(m1);
                Console.WriteLine("Zahnkopfhöhe Zahnrad1: " + ha1);
                double hf1 = prg.Zahnfußhöhe(m1, c1);
                Console.WriteLine("Zahnfußhöhe Zahnrad1: " + hf1);
                double h1 = prg.Zahnhöhe(m1, c1);
                Console.WriteLine("Zahnhöhe Zahnrad1: " + h1);
                double v1 = prg.Volumen(da1, b1);
                Console.WriteLine("Volumen Zahnrad1: " + v1);

                Console.WriteLine("");

                //Ergebnisse Zahnrad2
                double m2 = prg.Modul(d2, z2);
                Console.WriteLine("Modul Zahnrad2: " + m2);
                double p2 = prg.Teilung(m2);
                Console.WriteLine("Teilung Zahnrad2: " + p2);
                double c2 = prg.Kopfspiel(m2);
                Console.WriteLine("Kopfspiel Zahnrad2: " + c2);
                double da2 = prg.Kopfkreisdurchmesser_a(d2, m2);
                Console.WriteLine("Kopfkreisdurchmesser Zahnrad2: " + da2);
                double df2 = prg.Fußkreisdurchmesser_a(d2, m2, c2);
                Console.WriteLine("Fußkreisdurchmesser Zahnrad2: " + df2);
                double dg2 = prg.Grundkreisdurchmesser(d2);
                Console.WriteLine("Grundkreisdurchmesser Zahnrad2: " + dg2);
                double ha2 = prg.Zahnkopfhöhe(m2);
                Console.WriteLine("Zahnkopfhöhe Zahnrad2: " + ha2);
                double hf2 = prg.Zahnfußhöhe(m2, c2);
                Console.WriteLine("Zahnfußhöhe Zahnrad2: " + hf2);
                double h2 = prg.Zahnhöhe(m2, c2);
                Console.WriteLine("Zahnhöhe Zahnrad2: " + h2);
                double v2 = prg.Volumen(da2, b2);
                Console.WriteLine("Volumen Zahnrad2: " + v2);

                Console.WriteLine("");

                //Achsabstand
                double aa = prg.Achsabstand_a(d2, d1);
                Console.WriteLine("Achsabstand: " + aa);
            }

            //innenverzahnte Zahnräder
            else if (ii == 2)
            {
                //Ergebnisse Zahnrad1
                double m1 = prg.Modul(d1, z1);
                Console.WriteLine("Modul Zahnrad1: " + m1);
                double p1 = prg.Teilung(m1);
                Console.WriteLine("Teilung Zahnrad1: " + p1);
                double c1 = prg.Kopfspiel(m1);
                Console.WriteLine("Kopfspiel Zahnrad1: " + c1);
                double da1 = prg.Kopfkreisdurchmesser_i(d1, m1);
                Console.WriteLine("Kopfkreisdurchmesser Zahnrad1: " + da1);
                double df1 = prg.Fußkreisdurchmesser_i(d1, m1, c1);
                Console.WriteLine("Fußkreisdurchmesser Zahnrad1: " + df1);
                double dg1 = prg.Grundkreisdurchmesser(d1);
                Console.WriteLine("Grundkreisdurchmesser Zahnrad1: " + dg1);
                double ha1 = prg.Zahnkopfhöhe(m1);
                Console.WriteLine("Zahnkopfhöhe Zahnrad1: " + ha1);
                double hf1 = prg.Zahnfußhöhe(m1, c1);
                Console.WriteLine("Zahnfußhöhe Zahnrad1: " + hf1);
                double h1 = prg.Zahnhöhe(m1, c1);
                Console.WriteLine("Zahnhöhe Zahnrad1: " + h1);
                double v1 = prg.Volumen(da1, b1);
                Console.WriteLine("Volumen Zahnrad1: " + v1);

                Console.WriteLine("");

                //Ergebnisse Zahnrad2
                double m2 = prg.Modul(d2, z2);
                Console.WriteLine("Modul Zahnrad2: " + m2);
                double p2 = prg.Teilung(m2);
                Console.WriteLine("Teilung Zahnrad2: " + p2);
                double c2 = prg.Kopfspiel(m2);
                Console.WriteLine("Kopfspiel Zahnrad2: " + c2);
                double da2 = prg.Kopfkreisdurchmesser_i(d2, m2);
                Console.WriteLine("Kopfkreisdurchmesser Zahnrad2: " + da2);
                double df2 = prg.Fußkreisdurchmesser_i(d2, m2, c2);
                Console.WriteLine("Fußkreisdurchmesser Zahnrad2: " + df2);
                double dg2 = prg.Grundkreisdurchmesser(d2);
                Console.WriteLine("Grundkreisdurchmesser Zahnrad2: " + dg2);
                double ha2 = prg.Zahnkopfhöhe(m2);
                Console.WriteLine("Zahnkopfhöhe Zahnrad2: " + ha2);
                double hf2 = prg.Zahnfußhöhe(m2, c2);
                Console.WriteLine("Zahnfußhöhe Zahnrad2: " + hf2);
                double h2 = prg.Zahnhöhe(m2, c2);
                Console.WriteLine("Zahnhöhe Zahnrad2: " + h2);
                double v2 = prg.Volumen(da2, b2);
                Console.WriteLine("Volumen Zahnrad2: " + v2);

                Console.WriteLine("");

                //Achsabstand
                double ai = prg.Achsabstand_i(d2, d1);
                Console.WriteLine("Achsabstand: " + ai);
            }

            else
            {
                Console.WriteLine("Fehler: Auswahl wurde nicht erkannt, starten Sie das Programm bitte neu!");
            }

            //Ende
            Console.ReadKey();

        }
    }
}