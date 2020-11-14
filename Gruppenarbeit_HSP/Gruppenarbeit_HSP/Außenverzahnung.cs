using System;
using System.Collections.Generic;
using System.Text;

namespace Gruppenarbeit_HSP
{
    class Außenverzahnung
    {
        Berechnungen brg = new Berechnungen();
        public void außenverzahnteZahnräder()
        {
            Console.Clear();

            //Eingangsparameter Zahnrad1
            Console.WriteLine("Bitte geben Sie den Modul [mm] von Zahnrad1 an und bestätigen anschließend mit Enter: ");
            double m11 = Convert.ToDouble(Console.ReadLine());      // Variable m11 wird erstellt und der Eingabe zugeordnet
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
            double p11 = brg.Teilung(m11);      // die in der Klasse program geschriebenen Berechnungen werden mithilfe der Eingabe ausgeführt
            Console.WriteLine("Teilung Zahnrad1: " + p11 + " mm");  // und mit diesem Text ausgeführt
            double c11 = brg.Kopfspiel(m11);
            Console.WriteLine("Kopfspiel Zahnrad1: " + c11 + " mm");
            double da11 = brg.Kopfkreisdurchmesser_a(m11, z11);
            Console.WriteLine("Kopfkreisdurchmesser Zahnrad1: " + da11 + " mm");
            double df11 = brg.Fußkreisdurchmesser_a(d11, m11, c11);
            Console.WriteLine("Fußkreisdurchmesser Zahnrad1: " + df11 + " mm");
            double dg11 = brg.Grundkreisdurchmesser(d11);
            Console.WriteLine("Grundkreisdurchmesser Zahnrad1: " + dg11 + " mm");
            double ha11 = brg.Zahnkopfhöhe(m11);
            Console.WriteLine("Zahnkopfhöhe Zahnrad1: " + ha11 + " mm");
            double hf11 = brg.Zahnfußhöhe(m11, c11);
            Console.WriteLine("Zahnfußhöhe Zahnrad1: " + hf11 + " mm");
            double h11 = brg.Zahnhöhe(m11, c11);
            Console.WriteLine("Zahnhöhe Zahnrad1: " + h11 + " mm");
            double v11 = brg.Volumen(da11, b11);
            Console.WriteLine("Volumen Zahnrad1: " + v11 + " mm^3");

            Console.WriteLine("");
            Console.WriteLine("");

            //Ergebnisse Zahnrad2
            double p12 = brg.Teilung(m12);
            Console.WriteLine("Teilung Zahnrad2: " + p12 + " mm");
            double c12 = brg.Kopfspiel(m12);
            Console.WriteLine("Kopfspiel Zahnrad2: " + c12 + " mm");
            double da12 = brg.Kopfkreisdurchmesser_a(m12, z12);
            Console.WriteLine("Kopfkreisdurchmesser Zahnrad2: " + da12 + " mm");
            double df12 = brg.Fußkreisdurchmesser_a(d12, m12, c12);
            Console.WriteLine("Fußkreisdurchmesser Zahnrad2: " + df12 + " mm");
            double dg12 = brg.Grundkreisdurchmesser(d12);
            Console.WriteLine("Grundkreisdurchmesser Zahnrad2: " + dg12 + " mm");
            double ha12 = brg.Zahnkopfhöhe(m12);
            Console.WriteLine("Zahnkopfhöhe Zahnrad2: " + ha12 + " mm");
            double hf12 = brg.Zahnfußhöhe(m12, c12);
            Console.WriteLine("Zahnfußhöhe Zahnrad2: " + hf12 + " mm");
            double h12 = brg.Zahnhöhe(m12, c12);
            Console.WriteLine("Zahnhöhe Zahnrad2: " + h12 + " mm");
            double v12 = brg.Volumen(da12, b12);
            Console.WriteLine("Volumen Zahnrad2: " + v12 + " mm^3");

            Console.WriteLine("");

            //Achsabstand
            double aa = brg.Achsabstand_a(d12, d11);
            Console.WriteLine("Achsabstand: " + aa + " mm");
        }
        
    }
}
