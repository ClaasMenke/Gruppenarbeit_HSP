using System;

namespace Gruppenarbeit_HSP
{
    class Program
    {

        //Teilung
        public double Teilung(double m)
        {
            double p = Math.PI * m;
            return Math.Round(p, 2);
        }

        //Kopfspiel
        public double Kopfspiel(double m)
        {
            double c = 0.167 * m;
            return Math.Round(c, 2);
        }

        //Kopfkreisdurchmesser außenverzahnt
        public double Kopfkreisdurchmesser_a(double m, double z)
        {
            double da = m * (z + 2);
            return Math.Round(da, 2);
        }

        //Fußkreisdurchmesser außenverzahnt 
        public double Fußkreisdurchmesser_a(double d, double m, double c)
        {
            double df = d - 2 * (m + c);
            return Math.Round(df, 2);
        }

        //Kopfkreisdurchmesser innenverzahnt
        public double Kopfkreisdurchmesser_i(double m, double z)
        {
            double da = m * (z - 2); 
            return Math.Round(da, 2);
        }

        //Fußkreisdurchmesser innenverzahnt
        public double Fußkreisdurchmesser_i(double d, double m, double c)
        {
            double df = 2 + 2 * (m + c);
            return Math.Round(df, 2);
        }

        //Grundkreisdurchmesser
        public double Grundkreisdurchmesser(double d)
        {
            double nw = 20 * Math.PI / 180;
            double dg = d * Math.Cos(nw);
            return Math.Round(dg, 2);
        }

        //Zahnkopfhöhe
        public double Zahnkopfhöhe(double m)
        {
            double ha = m;
            return Math.Round(ha, 2);
        }

        //Zahnfußhöhe
        public double Zahnfußhöhe(double m, double c)
        {
            double hf = m + c;
            return Math.Round(hf, 2);
        }

        //Zahnhöhe
        public double Zahnhöhe(double m, double c)
        {
            double h = 2 + m + c;
            return Math.Round(h, 2);
        }

        //Volumen
        public double Volumen(double da, double b)
        {
            double v = Math.Pow(da / 2, 2) * b;
            return Math.Round(v, 2);
        }

        //Achsabstand mit außenliegendem Gegenrad
        public double Achsabstand_a(double d1, double d2)
        {
            double aa = (d2 + d1) / 2;
            return Math.Round(aa, 2);
        }

        //Achsabstand mit innenliegendem Gegenrad
        public double Achsabstand_i(double d1, double d2)
        {
            double ai = (d2 - d1) / 2;
            return Math.Round(ai, 2);
        }
        static void Main(string[] args)
        {

            //Einleitung
            Console.WriteLine("Herzlich Willkommen.");
            Console.WriteLine("Diese Software hilft Ihnen bei der Berechnung von Zahnrädern.");
            Console.WriteLine("");

            //Anweisungen
            Console.WriteLine("Bitte wählen Sie ob Sie Zahnräder mit außenliegendem Gegenrad(1) oder Zahnräder mit innenliegendem Gegenrad(2) berechnen möchten und bestätigen anschließend mit Enter.");
            int ii = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Program prg = new Program();

            //außenverzahnte Zahnräder
            if (ii == 1)
            {
                Console.Clear();

                //Eingangsparameter Zahnrad1
                Console.WriteLine("Bitte geben Sie den Modul [mm] von Zahnrad1 an und bestätigen anschließend mit Enter: ");
                double m11 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie die Zähnezahl von Zahnrad1 an und bestätigen anschließend mit Enter: ");
                int z11 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie den Teilkreisdurchmesser [mm] von Zahnrad1 an und bestätigen anschließend mit Enter: ");
                double d11 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie die Breite [mm] von Zahnrad1 an und bestätigen sie mit Enter: ");
                double b11 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("");

                //Eingangsparameter Zahnrad2
                Console.WriteLine("Bitte geben Sie den Modul [mm] von Zahnrad2 an und bestätigen anschließend mit Enter: ");
                double m12 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie die Zähnezahl von Zahnrad2 an und bestätigen anschließend mit Enter: ");
                int z12 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie den Teilkreisdurchmesser [mm] von Zahnrad2 an und bestätigen anschließend mit Enter: ");
                double d12 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie die Breite [mm] von Zahnrad2 an und bestätigen sie mit Enter: ");
                double b12 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("");

                //Ergebnisse Zahnrad1
                double p11 = prg.Teilung(m11);
                Console.WriteLine("Teilung Zahnrad1: " + p11 + " mm");
                double c11 = prg.Kopfspiel(m11);
                Console.WriteLine("Kopfspiel Zahnrad1: " + c11 + " mm");
                double da11 = prg.Kopfkreisdurchmesser_a(m11, z11);
                Console.WriteLine("Kopfkreisdurchmesser Zahnrad1: " + da11 + " mm");
                double df11 = prg.Fußkreisdurchmesser_a(d11, m11, c11);
                Console.WriteLine("Fußkreisdurchmesser Zahnrad1: " + df11 + " mm");
                double dg11 = prg.Grundkreisdurchmesser(d11);
                Console.WriteLine("Grundkreisdurchmesser Zahnrad1: " + dg11 + " mm");
                double ha11 = prg.Zahnkopfhöhe(m11);
                Console.WriteLine("Zahnkopfhöhe Zahnrad1: " + ha11 + " mm");
                double hf11 = prg.Zahnfußhöhe(m11, c11);
                Console.WriteLine("Zahnfußhöhe Zahnrad1: " + hf11 + " mm");
                double h11 = prg.Zahnhöhe(m11, c11);
                Console.WriteLine("Zahnhöhe Zahnrad1: " + h11 + " mm");
                double v11 = prg.Volumen(da11, b11);
                Console.WriteLine("Volumen Zahnrad1: " + v11 + " mm^3");

                Console.WriteLine("");
                Console.WriteLine("");

                //Ergebnisse Zahnrad2
                double p12 = prg.Teilung(m12);
                Console.WriteLine("Teilung Zahnrad2: " + p12 + " mm");
                double c12 = prg.Kopfspiel(m12);
                Console.WriteLine("Kopfspiel Zahnrad2: " + c12 + " mm");
                double da12 = prg.Kopfkreisdurchmesser_a(m12, z12);
                Console.WriteLine("Kopfkreisdurchmesser Zahnrad2: " + da12 + " mm");
                double df12 = prg.Fußkreisdurchmesser_a(d12, m12, c12);
                Console.WriteLine("Fußkreisdurchmesser Zahnrad2: " + df12 + " mm");
                double dg12 = prg.Grundkreisdurchmesser(d12);
                Console.WriteLine("Grundkreisdurchmesser Zahnrad2: " + dg12 + " mm");
                double ha12 = prg.Zahnkopfhöhe(m12);
                Console.WriteLine("Zahnkopfhöhe Zahnrad2: " + ha12 + " mm");
                double hf12 = prg.Zahnfußhöhe(m12, c12);
                Console.WriteLine("Zahnfußhöhe Zahnrad2: " + hf12 + " mm");
                double h12 = prg.Zahnhöhe(m12, c12);
                Console.WriteLine("Zahnhöhe Zahnrad2: " + h12 + " mm");
                double v12 = prg.Volumen(da12, b12);
                Console.WriteLine("Volumen Zahnrad2: " + v12 + " mm^3");

                Console.WriteLine("");

                //Achsabstand
                double aa = prg.Achsabstand_a(d12, d11);
                Console.WriteLine("Achsabstand: " + aa + " mm");
            }

            //innenverzahnte Zahnräder
            else if (ii == 2)
            {
                Console.Clear();

                //Eingangsparameter Zahnrad1
                Console.WriteLine("Bitte geben Sie den Modul [mm] von Zahnrad1 (innenverzahnt) an und bestätigen anschließend mit Enter: ");
                double m21 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie die Zähnezahl von Zahnrad1 (innenverzahnt) an und bestätigen anschließend mit Enter: ");
                int z21 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie den Teilkreisdurchmesser [mm] von Zahnrad1 (innenverzahnt) an und bestätigen anschließend mit Enter: ");
                double d21 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie die Breite [mm] von Zahnrad1 (innenverzahnt) an und bestätigen sie mit Enter: ");
                double b21 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("");

                //Eingangsparameter Zahnrad2
                Console.WriteLine("Bitte geben Sie den Modul [mm] von Zahnrad2 an und bestätigen anschließend mit Enter: ");
                double m22 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie die Zähnezahl von Zahnrad2 an und bestätigen anschließend mit Enter: ");
                int z22 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie den Teilkreisdurchmesser [mm] von Zahnrad2 an und bestätigen anschließend mit Enter: ");
                double d22 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie die Breite [mm] von Zahnrad2 an und bestätigen sie mit Enter: ");
                double b22 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("");

                //Ergebnisse Zahnrad1
                double p21 = prg.Teilung(m21);
                Console.WriteLine("Teilung Zahnrad1: " + p21 + " mm");
                double c21 = prg.Kopfspiel(m21);
                Console.WriteLine("Kopfspiel Zahnrad1: " + c21 + " mm");
                double da21 = prg.Kopfkreisdurchmesser_i(m21, z21);
                Console.WriteLine("Kopfkreisdurchmesser Zahnrad1: " + da21 + " mm");
                double df21 = prg.Fußkreisdurchmesser_i(d21, m21, c21);
                Console.WriteLine("Fußkreisdurchmesser Zahnrad1: " + df21 + " mm");
                double dg21 = prg.Grundkreisdurchmesser(d21);
                Console.WriteLine("Grundkreisdurchmesser Zahnrad1: " + dg21 + " mm");
                double ha21 = prg.Zahnkopfhöhe(m21);
                Console.WriteLine("Zahnkopfhöhe Zahnrad1: " + ha21 + " mm");
                double hf21 = prg.Zahnfußhöhe(m21, c21);
                Console.WriteLine("Zahnfußhöhe Zahnrad1: " + hf21 + " mm");
                double h21 = prg.Zahnhöhe(m21, c21);
                Console.WriteLine("Zahnhöhe Zahnrad1: " + h21 + " mm");
                double v21 = prg.Volumen(da21, b21);
                Console.WriteLine("Volumen Zahnrad1: " + v21 + " mm^3");

                Console.WriteLine("");
                Console.WriteLine("");

                //Ergebnisse Zahnrad2
                double p22 = prg.Teilung(m22);
                Console.WriteLine("Teilung Zahnrad2: " + p22 + " mm");
                double c22 = prg.Kopfspiel(m22);
                Console.WriteLine("Kopfspiel Zahnrad2: " + c22);
                double da22 = prg.Kopfkreisdurchmesser_a(m22, z22);
                Console.WriteLine("Kopfkreisdurchmesser Zahnrad2: " + da22 + " mm");
                double df22 = prg.Fußkreisdurchmesser_a(d22, m22, c22);
                Console.WriteLine("Fußkreisdurchmesser Zahnrad2: " + df22 + " mm");
                double dg22 = prg.Grundkreisdurchmesser(d22);
                Console.WriteLine("Grundkreisdurchmesser Zahnrad2: " + dg22 + " mm");
                double ha22 = prg.Zahnkopfhöhe(m22);
                Console.WriteLine("Zahnkopfhöhe Zahnrad2: " + ha22 + " mm");
                double hf22 = prg.Zahnfußhöhe(m22, c22);
                Console.WriteLine("Zahnfußhöhe Zahnrad2: " + hf22 + " mm");
                double h22 = prg.Zahnhöhe(m22, c22);
                Console.WriteLine("Zahnhöhe Zahnrad2: " + h22 + " mm");
                double v22 = prg.Volumen(da22, b22);
                Console.WriteLine("Volumen Zahnrad2: " + v22 + " mm^3");

                Console.WriteLine("");

                //Achsabstand
                double ai = prg.Achsabstand_i(d22, d21);
                Console.WriteLine("Achsabstand: " + ai + " mm");
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Fehler: Auswahl wurde nicht erkannt, starten Sie das Programm bitte neu!");
            }

            //Ende
            Console.ReadKey();

        }
    }
}