using System;
using System.Collections.Generic;
using System.Text;

namespace Gruppenarbeit_HSP
{
    class Innenverzahnung
    {
        Berechnungen brg = new Berechnungen();
        public void innenverzahnteZahnräder()
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
            double p21 = brg.Teilung(m21);
            Console.WriteLine("Teilung Zahnrad1: " + p21 + " mm");
            double c21 = brg.Kopfspiel(m21);
            Console.WriteLine("Kopfspiel Zahnrad1: " + c21 + " mm");
            double da21 = brg.Kopfkreisdurchmesser_i(m21, z21);
            Console.WriteLine("Kopfkreisdurchmesser Zahnrad1: " + da21 + " mm");
            double df21 = brg.Fußkreisdurchmesser_i(d21, m21, c21);
            Console.WriteLine("Fußkreisdurchmesser Zahnrad1: " + df21 + " mm");
            double dg21 = brg.Grundkreisdurchmesser(d21);
            Console.WriteLine("Grundkreisdurchmesser Zahnrad1: " + dg21 + " mm");
            double ha21 = brg.Zahnkopfhöhe(m21);
            Console.WriteLine("Zahnkopfhöhe Zahnrad1: " + ha21 + " mm");
            double hf21 = brg.Zahnfußhöhe(m21, c21);
            Console.WriteLine("Zahnfußhöhe Zahnrad1: " + hf21 + " mm");
            double h21 = brg.Zahnhöhe(m21, c21);
            Console.WriteLine("Zahnhöhe Zahnrad1: " + h21 + " mm");
            double v21 = brg.Volumen(da21, b21);
            Console.WriteLine("Volumen Zahnrad1: " + v21 + " mm^3");

            Console.WriteLine("");
            Console.WriteLine("");

            //Ergebnisse Zahnrad2
            double p22 = brg.Teilung(m22);
            Console.WriteLine("Teilung Zahnrad2: " + p22 + " mm");
            double c22 = brg.Kopfspiel(m22);
            Console.WriteLine("Kopfspiel Zahnrad2: " + c22);
            double da22 = brg.Kopfkreisdurchmesser_a(m22, z22);
            Console.WriteLine("Kopfkreisdurchmesser Zahnrad2: " + da22 + " mm");
            double df22 = brg.Fußkreisdurchmesser_a(d22, m22, c22);
            Console.WriteLine("Fußkreisdurchmesser Zahnrad2: " + df22 + " mm");
            double dg22 = brg.Grundkreisdurchmesser(d22);
            Console.WriteLine("Grundkreisdurchmesser Zahnrad2: " + dg22 + " mm");
            double ha22 = brg.Zahnkopfhöhe(m22);
            Console.WriteLine("Zahnkopfhöhe Zahnrad2: " + ha22 + " mm");
            double hf22 = brg.Zahnfußhöhe(m22, c22);
            Console.WriteLine("Zahnfußhöhe Zahnrad2: " + hf22 + " mm");
            double h22 = brg.Zahnhöhe(m22, c22);
            Console.WriteLine("Zahnhöhe Zahnrad2: " + h22 + " mm");
            double v22 = brg.Volumen(da22, b22);
            Console.WriteLine("Volumen Zahnrad2: " + v22 + " mm^3");

            Console.WriteLine("");

            //Achsabstand
            double ai = brg.Achsabstand_i(d22, d21);
            Console.WriteLine("Achsabstand: " + ai + " mm");
        }
    }
}
