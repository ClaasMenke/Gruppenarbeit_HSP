using ImTools;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Berechnung_Zahnrad
{
    class Program
    {

        public const double preisstal = 1.1;
        public const double preismessig = 2.7;
        public const double dichtstahl = 8.8 * (10 ^ 3);
        public const double dichtmessig = 7.85 * (10 ^ 3);

        static void Main()

        {
            double d2 = 0;
            Console.WriteLine("Willkommen bei uns");
            Console.WriteLine("Sie koennen Zahnrad suchen und verbinden ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Bitte geben Sie den Moudle des zahnrad in 'm' ein und bestätigen Sie mit 'Enter'.");
            string Moudle1 = Console.ReadLine();
            double m1 = getmoudle1(Moudle1);

            Console.WriteLine("Bitte geben Sie den zähnezahl des zahnrad in 'm' ein und bestätigen Sie mit 'Enter'.");
            string zaehnezahl1 = Console.ReadLine();
            double z1 = getzaehnezahl1(zaehnezahl1);

            Console.WriteLine("Bitte geben Sie den Teilkreisdurchmesser des zahnrad in 'm' ein und bestätigen Sie mit 'Enter'.");
            string Teilkreisdurchmesser1 = Console.ReadLine();
            double d1 = getTeilkreisdurchmesser1(Teilkreisdurchmesser1);


            Console.WriteLine("Bitte geben Sie den Breite des zahnrad in 'm' ein und bestätigen Sie mit 'Enter'.");
            string Breite1 = Console.ReadLine();
            double b1 = getBreite1(Breite1);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("1.messig");
            Console.WriteLine("2.stahl");
            Console.WriteLine("Bitte wahlen Sie den werkstoff des zahnrad aus und eintippen 1,2 dann bestätigen Sie mit 'Enter'.");
            Console.WriteLine();
            string w = "";                                                                                                                      //w：wahlen Sie den werkstoff des zahnrad aus
            while (w != "1" && w != "2")
            {
                w = Console.ReadLine();

                if (w == "1")
                {
                    //Berechnung
                    double p1, da1, df1, h1, ha1, hf1, c1, v1, preis1, M1;
                    p1 = Math.PI * m1;
                    da1 = d1 + 2 * m1;
                    c1 = 0.16 * m1;
                    df1 = d1 - 2 * (m1 + c1);
                    h1 = 2 * m1 + c1;
                    ha1 = m1;
                    hf1 = m1 + c1;
                    v1 = Math.PI * da1 * da1 * b1 / 4;
                    M1 = v1 * dichtmessig;
                    preis1 = M1 * preismessig;
                    Console.WriteLine("    Teilung                 ={0}mm", p1);//*****************************
                    Console.WriteLine("    Kopfkreisdurchmesser    ={0}mm", da1);
                    Console.WriteLine("    Kopfspiel               ={0}mm", c1);
                    Console.WriteLine("    Fusskreisdurchmesser    ={0}mm", df1);
                    Console.WriteLine("    zahnhoehe               ={0}mm", h1);
                    Console.WriteLine("    zahnkopfhoehe           ={0}mm", ha1);
                    Console.WriteLine("    zahnfusshoehe           ={0}mm", hf1);
                    Console.WriteLine("    volumen                 ={0}mm^3", v1);
                    Console.WriteLine("    Masse                   ={0}kg", M1);
                    Console.WriteLine("    preis                   ={0}Euro", preis1);
                }

                else if (w == "2")
                {



                    //Berechnung
                    double p1, da1, df1, h1, ha1, hf1, c1, v12, preis12, M12;
                    p1 = Math.PI * m1;
                    da1 = d1 + 2 * m1;
                    c1 = 0.16 * m1;
                    df1 = d1 - 2 * (m1 + c1);
                    h1 = 2 * m1 + c1;
                    ha1 = m1;
                    hf1 = m1 + c1;
                    v12 = Math.PI * da1 * da1 * b1 / 4;
                    M12 = v12 * dichtstahl;
                    preis12 = M12 * preisstal;
                    Console.WriteLine("    Teilung               ={0}mm", p1);//*****************************
                    Console.WriteLine("    Kopfkreisdurchmesser  ={0}mm", da1);
                    Console.WriteLine("    Kopfspiel             ={0}mm", c1);
                    Console.WriteLine("    Fusskreisdurchmesser  ={0}mm", df1);
                    Console.WriteLine("    zahnhoehe             ={0}mm", h1);
                    Console.WriteLine("    zahnkopfhoehe         ={0}mm", ha1);
                    Console.WriteLine("    zahnfusshoehe         ={0}mm", hf1);
                    Console.WriteLine("    volumen               ={0}mm^3", v12);
                    Console.WriteLine("    Masse                 ={0}kg", M12);
                    Console.WriteLine("    preis                 ={0}Euro", preis12);


                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("bitte geben Sie 1 oder 2");
                }

            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("möchten Sie mit anderem zahnrad verbinden?");
            Console.WriteLine("1.ja");
            Console.WriteLine("2.nein");
            Console.WriteLine();
            Console.WriteLine("Bitte wahlen Sie aus und eintippen 1,2 dann bestätigen Sie mit 'Enter'.");
            string e = "";                                                                                                                     //e:entscheidung for verbindung
            while (e != "1" && e != "2")
            {
                e = Console.ReadLine();
                if (e == "1")
                {
                    Console.WriteLine();


                    Console.WriteLine("Bitte geben Sie den Moudle des zahnrad ein und bestätigen Sie mit 'Enter'.");
                    string Moudle2 = Console.ReadLine();
                    double m2 = getmoudle2(Moudle2);

                    Console.WriteLine("Bitte geben Sie den zähnezahl des zahnrad ein und bestätigen Sie mit 'Enter'.");
                    string zaehnezahl2 = Console.ReadLine();
                    double z2 = getzaehnezahl2(zaehnezahl2);

                    Console.WriteLine("Bitte geben Sie den Teilkreisdurchmesser des zahnrad ein und bestätigen Sie mit 'Enter'.");
                    string Teilkreisdurchmesser2 = Console.ReadLine();
                    d2 = getTeilkreisdurchmesser2(Teilkreisdurchmesser2);

                    Console.WriteLine("Bitte geben Sie den Breite des zahnrad ein und bestätigen Sie mit 'Enter'.");
                    string Breite2 = Console.ReadLine();
                    double b2 = getBreite2(Breite2);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("1.messig");
                    Console.WriteLine("2.stahl");
                    Console.WriteLine("Bitte wahlen Sie den werkstoff des zahnrad aus und eintippen 1,2 dann bestätigen Sie mit 'Enter'.");
                    string w2 = "";             //  werkstoff auswahl
                    while (w2 != "1" && w2 != "2")
                    {
                        w2 = Console.ReadLine();
                        if (w2 == "1")
                        {
                            //Berechnung
                            double p2, da2, df2, h2, ha2, hf2, c2, v21, preis21, M21;
                            p2 = Math.PI * m2;
                            da2 = d2 + 2 * m2;
                            c2 = 0.16 * m2;
                            df2 = d2 - 2 * (m2 + c2);
                            h2 = 2 * m2 + c2;
                            ha2 = m2;
                            hf2 = m2 + c2;
                            v21 = Math.PI * da2 * da2 * b2 / 4;
                            M21 = v21 * dichtmessig;
                            preis21 = M21 * preismessig;
                            Console.WriteLine("    Teilung               ={0}mm", p2);//*****************************
                            Console.WriteLine("    Kopfkreisdurchmesser  ={0}mm", da2);
                            Console.WriteLine("    Kopfspiel             ={0}mm", c2);
                            Console.WriteLine("    Fusskreisdurchmesser  ={0}mm", df2);
                            Console.WriteLine("    zahnhoehe             ={0}mm", h2);
                            Console.WriteLine("    zahnkopfhoehe         ={0}mm", ha2);
                            Console.WriteLine("    zahnfusshoehe         ={0}mm", hf2);
                            Console.WriteLine("    volumen               ={0}mm^3", v21);
                            Console.WriteLine("    Masse                 ={0}kg", M21);
                            Console.WriteLine("    preis                 ={0}Euro", preis21);

                        }

                        else if (w2 == "2")
                        {
                            //Berechnung
                            double p2, da2, df2, h2, ha2, hf2, c2, v22, preis22, M22;
                            p2 = Math.PI * m2;
                            da2 = d2 + 2 * m2;
                            c2 = 0.16 * m2;
                            df2 = d2 - 2 * (m2 + c2);
                            h2 = 2 * m2 + c2;
                            ha2 = m2;
                            hf2 = m2 + c2;
                            v22 = Math.PI * da2 * da2 * b2 / 4;
                            M22 = v22 * dichtstahl;
                            preis22 = M22 * preisstal;
                            Console.WriteLine("    Teilung               ={0}mm", p2);//*****************************
                            Console.WriteLine("    Kopfkreisdurchmesser  ={0}mm", da2);
                            Console.WriteLine("    Kopfspiel             ={0}mm", c2);
                            Console.WriteLine("    Fusskreisdurchmesser  ={0}mm", df2);
                            Console.WriteLine("    zahnhoehe             ={0}mm", h2);
                            Console.WriteLine("    zahnkopfhoehe         ={0}mm", ha2);
                            Console.WriteLine("    zahnfusshoehe         ={0}mm", hf2);
                            Console.WriteLine("    volumen               ={0}mm^3", v22);
                            Console.WriteLine("    Masse                 ={0}kg", M22);
                            Console.WriteLine("    preis                 ={0}Euro", preis22);
                        }

                        else

                        {

                            Console.WriteLine();
                            Console.WriteLine("bitte geben Sie 1 oder 2");

                        }

                    }

                }
                else if (e == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("vielen Dank!");
                    Console.ReadKey();
                    return;


                }
                else

                {

                    Console.WriteLine();
                    Console.WriteLine("bitte geben Sie 1 oder 2");



                }

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Bitte waehlen Sie aussenliegender order innenliegender gegenrad");
            Console.WriteLine("1. aussenliegend");
            Console.WriteLine("2.innenliegend");
            string aus = "";                                                                                                                   // aus:  waehlen Sie aussenliegender order innenliegender gegenrad
            double a;                                                                                                                          // a:    Achsabstand

            while (aus != "1" && aus != "2")
            {
                aus = Console.ReadLine();
                if (aus == "1")
                {
                    a = (d1 + d2) / 2;
                    Console.WriteLine("Achsabstand={0}mm", a);

                }
                else if (aus == "2")
                {
                    if (d1 > d2)
                    {
                        a = (d1 - d2) / 2;
                        Console.WriteLine("Achsabstand={0}mm", a);
                    }
                    else if (d1 < d2)
                    {
                        a = (d2 - d1) / 2;
                        Console.WriteLine("Achsabstand={0}mm", a);
                    }
                    else if (d2 == d1)
                    {
                        Console.WriteLine("falsch , Teilkreisdurchmesser muessen unterschiedlich sein");
                        Console.WriteLine("bitten sie 1 oder 2 eintippen!");
                        aus = "t";          //um noch mal zu machen
                    }

                }
                else
                {
                    Console.WriteLine("bitten sie 1 oder 2 eintippen!");

                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Also ,auf Wiedersehen und shoenen Tag noch！");
            Console.ReadKey();

        }
        public static double getmoudle1(string moudle1)
        {
            while (true)
            {
                try
                {

                    double m1 = Convert.ToDouble(moudle1);
                    if (m1 > 0)
                    {
                        return m1;
                    }
                    else if (m1 <= 0)
                    {
                        Console.WriteLine("bitten zahlen grosser als 0 gegeben");
                        moudle1 = Console.ReadLine();
                    }

                }
                catch
                {
                    Console.WriteLine("bitten zahnlen eintippen");
                    moudle1 = Console.ReadLine();
                }

            }

        }
        public static double getzaehnezahl1(string zaehnezahl1)
        {
            while (true)
            {
                try
                {
                    double z1 = Convert.ToDouble(zaehnezahl1);

                    if (z1 > 0)
                    {
                        return z1;
                    }
                    else if (z1 <= 0)
                    {
                        Console.WriteLine("bitten zahlen grosser als 0 gegeben");
                        zaehnezahl1 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    zaehnezahl1 = Console.ReadLine();
                }

            }


        }
        public static double getTeilkreisdurchmesser1(string Teilkreisdurchmesser1)
        {
            while (true)
            {
                try
                {
                    double d1 = Convert.ToDouble(Teilkreisdurchmesser1);

                    if (d1 > 0)
                    {
                        return d1;
                    }
                    else if (d1 <= 0)
                    {
                        Console.WriteLine("bitten zahlen grosser als 0 gegeben");
                        Teilkreisdurchmesser1 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    Teilkreisdurchmesser1 = Console.ReadLine();
                }

            }

        }
        public static double getBreite1(string Breite1)
        {
            while (true)
            {
                try
                {
                    double b1 = Convert.ToDouble(Breite1);

                    if (b1 > 0)
                    {
                        return b1;
                    }
                    else if (b1 <= 0)
                    {
                        Console.WriteLine("bitten zahlen grosser als 0 gegeben");
                        Breite1 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    Breite1 = Console.ReadLine();
                }

            }

        }
        public static double getmoudle2(string moudle2)
        {
            while (true)
            {
                try
                {
                    double m2 = Convert.ToDouble(moudle2);
                    if (m2 > 0)
                    {
                        return m2;
                    }
                    else if (m2 <= 0)
                    {
                        Console.WriteLine("bitten zahlen grosser als 0 gegeben");
                        moudle2 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahnlen eintippen");
                    moudle2 = Console.ReadLine();
                }

            }

        }
        public static double getzaehnezahl2(string zaehnezahl2)
        {
            while (true)
            {
                try
                {
                    double z2 = Convert.ToDouble(zaehnezahl2);
                    if (z2 > 0)
                    {
                        return z2;
                    }
                    else if (z2 <= 0)
                    {
                        Console.WriteLine("bitten zahlen grosser als 0 gegeben");
                        zaehnezahl2 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    zaehnezahl2 = Console.ReadLine();
                }

            }


        }
        public static double getTeilkreisdurchmesser2(string Teilkreisdurchmesser2)
        {
            while (true)
            {
                try
                {
                    double d2 = Convert.ToDouble(Teilkreisdurchmesser2);
                    if (d2 > 0)
                    {
                        return d2;
                    }
                    else if (d2 <= 0)
                    {
                        Console.WriteLine("bitten zahlen grosser als 0 gegeben");
                        Teilkreisdurchmesser2 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    Teilkreisdurchmesser2 = Console.ReadLine();
                }

            }

        }
        public static double getBreite2(string Breite2)
        {
            while (true)
            {
                try
                {
                    double b2 = Convert.ToDouble(Breite2);
                    if (b2 > 0)
                    {
                        return b2;
                    }
                    else if (b2 <= 0)
                    {
                        Console.WriteLine("bitten zahlen grosser als 0 gegeben");
                        Breite2 = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("bitten zahlen eintippen");
                    Breite2 = Console.ReadLine();
                }

            }

        }




    }
}






































