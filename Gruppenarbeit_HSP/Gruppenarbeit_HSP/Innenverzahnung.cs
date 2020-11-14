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
            string moudle21 = Console.ReadLine();
            double m21 = getmodule21(moudle21);

            Console.WriteLine("Bitte geben Sie die Zähnezahl von Zahnrad1 (innenverzahnt) an und bestätigen anschließend mit Enter: ");
            string zahnrad21 = Console.ReadLine();
            double z21 = getzahnrad21(zahnrad21);

            Console.WriteLine("Bitte geben Sie den Teilkreisdurchmesser [mm] von Zahnrad1 (innenverzahnt) an und bestätigen anschließend mit Enter: ");
            string Teilkreisdurchmesser21 = Console.ReadLine();
            double d21 = getTeilkreisdurchmesser21(Teilkreisdurchmesser21);

            Console.WriteLine("Bitte geben Sie die Breite [mm] von Zahnrad1 (innenverzahnt) an und bestätigen sie mit Enter: ");
            string Breite21 = Console.ReadLine();
            double b21 = getBreite21(Breite21);

            Console.WriteLine("");
            Console.WriteLine("");

            //Eingangsparameter Zahnrad2
            Console.WriteLine("Bitte geben Sie den Modul [mm] von Zahnrad2 an und bestätigen anschließend mit Enter: ");
            string moudle22 = Console.ReadLine();
            double m22 = getmodule22(moudle22);

            Console.WriteLine("Bitte geben Sie die Zähnezahl von Zahnrad2 an und bestätigen anschließend mit Enter: ");
            string zahnrad22 = Console.ReadLine();
            double z22 = getzahnrad21(zahnrad22);

            Console.WriteLine("Bitte geben Sie den Teilkreisdurchmesser [mm] von Zahnrad2 an und bestätigen anschließend mit Enter: ");
            string Teilkreisdurchmesser22 = Console.ReadLine();
            double d22= getTeilkreisdurchmesser22(Teilkreisdurchmesser22);

            Console.WriteLine("Bitte geben Sie die Breite [mm] von Zahnrad2 an und bestätigen sie mit Enter: ");
            string Breite22 = Console.ReadLine();
            double b22 = getBreite21(Breite22);

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
        public static double getmodule21(string moudle21)
        {
            while (true)
                try
                {
                    double m21 = Convert.ToDouble(moudle21);
                    if (m21 > 0)
                    {
                        return m21;
                    }
                    else if (m21 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        moudle21 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    moudle21 = Console.ReadLine();
                }
        }
        public static double getzahnrad21(string zahnrad21)
        {
            while (true)
                try
                {
                    double z21 = Convert.ToDouble(zahnrad21);
                    if (z21 > 0)
                    {
                        return z21;
                    }
                    else if (z21 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        zahnrad21 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    zahnrad21 = Console.ReadLine();
                }
        }
        public static double getTeilkreisdurchmesser21(string Teilkreisdurchmesser21)
        {
            while (true)
                try
                {
                    double d21 = Convert.ToDouble(Teilkreisdurchmesser21);
                    if (d21 > 0)
                    {
                        return d21;
                    }
                    else if (d21 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        Teilkreisdurchmesser21 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    Teilkreisdurchmesser21 = Console.ReadLine();
                }
        }
        public static double getBreite21(string Breite21)
        {
            while (true)
                try
                {
                    double b21 = Convert.ToDouble(Breite21);
                    if (b21 > 0)
                    {
                        return b21;
                    }
                    else if (b21 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        Breite21 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    Breite21 = Console.ReadLine();
                }
        }
        public static double getmodule22(string moudle22)
        {
            while (true)
                try
                {
                    double m22 = Convert.ToDouble(moudle22);
                    if (m22 > 0)
                    {
                        return m22;
                    }
                    else if (m22 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        moudle22 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    moudle22 = Console.ReadLine();
                }
        }
        public static double getzahnrad22(string zahnrad22)
        {
            while (true)
                try
                {
                    double z22 = Convert.ToDouble(zahnrad22);
                    if (z22 > 0)
                    {
                        return z22;
                    }
                    else if (z22 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        zahnrad22 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    zahnrad22 = Console.ReadLine();
                }
        }
        public static double getTeilkreisdurchmesser22(string Teilkreisdurchmesser22)
        {
            while (true)
                try
                {
                    double d22 = Convert.ToDouble(Teilkreisdurchmesser22);
                    if (d22 > 0)
                    {
                        return d22;
                    }
                    else if (d22 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        Teilkreisdurchmesser22 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    Teilkreisdurchmesser22= Console.ReadLine();
                }
        }
        public static double getBreite22(string Breite22)
        {
            while (true)
                try
                {
                    double b22 = Convert.ToDouble(Breite22);
                    if (b22 > 0)
                    {
                        return b22;
                    }
                    else if (b22 <= 0)
                    {
                        Console.WriteLine("bitten zahlen groessen als 0 gegebn");
                        Breite22 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    Breite22 = Console.ReadLine();
                }
        }
    }
}
