using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppenarbeit_HSP_neu
{
    class Außenverzahnung
    {
        Berechnungen brg = new Berechnungen();
        public void außenverzahnteZahnräder()
        {
            Console.Clear();

            //Eingangsparameter Zahnrad1
            Console.WriteLine("Bitte geben Sie den Modul [mm] von Zahnrad1 an und bestätigen anschließend mit Enter: ");
            string moudle11 = Console.ReadLine();
            double m11 = getmodule11(moudle11);      // Variable m11 wird erstellt und der Eingabe zugeordnet

            Console.WriteLine("Bitte geben Sie die Zähnezahl von Zahnrad1 an und bestätigen anschließend mit Enter: ");
            string zahnrad11 = Console.ReadLine();
            double z11 = getzahnrad11(zahnrad11);

            Console.WriteLine("Bitte geben Sie den Teilkreisdurchmesser [mm] von Zahnrad1 an und bestätigen anschließend mit Enter: ");
            string Teilkreisdurchmesser11 = Console.ReadLine();
            double d11 = getTeilkreisdurchmesser11(Teilkreisdurchmesser11);

            Console.WriteLine("Bitte geben Sie die Breite [mm] von Zahnrad1 an und bestätigen sie mit Enter: ");
            string Breite11 = Console.ReadLine();
            double b11 = getBreite11(Breite11);

            Console.WriteLine("");
            Console.WriteLine("");

            //Eingangsparameter Zahnrad2
            Console.WriteLine("Bitte geben Sie den Modul [mm] von Zahnrad2 an und bestätigen anschließend mit Enter: ");
            string moudle12 = Console.ReadLine();
            double m12 = getmodule11(moudle12);

            Console.WriteLine("Bitte geben Sie die Zähnezahl von Zahnrad2 an und bestätigen anschließend mit Enter: ");
            string zahnrad12 = Console.ReadLine();
            double z12 = getzahnrad12(zahnrad12);

            Console.WriteLine("Bitte geben Sie den Teilkreisdurchmesser [mm] von Zahnrad2 an und bestätigen anschließend mit Enter: ");
            string Teilkreisdurchmesser12 = Console.ReadLine();
            double d12 = getTeilkreisdurchmesser12(Teilkreisdurchmesser12);

            Console.WriteLine("Bitte geben Sie die Breite [mm] von Zahnrad2 an und bestätigen sie mit Enter: ");
            string Breite12 = Console.ReadLine();
            double b12 = getBreite12(Breite12);

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
        public static double getmodule11(string moudle11)
        {
            while (true)
                try
                {
                    double m11 = Convert.ToDouble(moudle11);
                    if (m11 > 0)
                    {
                        return m11;
                    }
                    else if (m11 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        moudle11 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    moudle11 = Console.ReadLine();
                }
        }
        public static double getzahnrad11(string zahnrad11)
        {
            while (true)
                try
                {
                    double z11 = Convert.ToDouble(zahnrad11);
                    if (z11 > 0)
                    {
                        return z11;
                    }
                    else if (z11 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        zahnrad11 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    zahnrad11 = Console.ReadLine();
                }
        }
        public static double getTeilkreisdurchmesser11(string Teilkreisdurchmesser11)
        {
            while (true)
                try
                {
                    double d11 = Convert.ToDouble(Teilkreisdurchmesser11);
                    if (d11 > 0)
                    {
                        return d11;
                    }
                    else if (d11 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        Teilkreisdurchmesser11 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    Teilkreisdurchmesser11 = Console.ReadLine();
                }
        }
        public static double getBreite11(string Breite11)
        {
            while (true)
                try
                {
                    double b11 = Convert.ToDouble(Breite11);
                    if (b11 > 0)
                    {
                        return b11;
                    }
                    else if (b11 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        Breite11 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    Breite11 = Console.ReadLine();
                }
        }
        public static double getmodule12(string moudle12)
        {
            while (true)
                try
                {
                    double m12 = Convert.ToDouble(moudle12);
                    if (m12 > 0)
                    {
                        return m12;
                    }
                    else if (m12 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        moudle12 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    moudle12 = Console.ReadLine();
                }
        }
        public static double getzahnrad12(string zahnrad12)
        {
            while (true)
                try
                {
                    double z12 = Convert.ToDouble(zahnrad12);
                    if (z12 > 0)
                    {
                        return z12;
                    }
                    else if (z12 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        zahnrad12 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    zahnrad12 = Console.ReadLine();
                }
        }
        public static double getTeilkreisdurchmesser12(string Teilkreisdurchmesser12)
        {
            while (true)
                try
                {
                    double d12 = Convert.ToDouble(Teilkreisdurchmesser12);
                    if (d12 > 0)
                    {
                        return d12;
                    }
                    else if (d12 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        Teilkreisdurchmesser12 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    Teilkreisdurchmesser12 = Console.ReadLine();
                }
        }
        public static double getBreite12(string Breite12)
        {
            while (true)
                try
                {
                    double b12 = Convert.ToDouble(Breite12);
                    if (b12 > 0)
                    {
                        return b12;
                    }
                    else if (b12 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        Breite12 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    Breite12 = Console.ReadLine();
                }
        }
    }
}
