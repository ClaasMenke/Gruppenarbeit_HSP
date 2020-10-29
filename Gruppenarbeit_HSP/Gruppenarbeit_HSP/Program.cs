using System;

namespace Gruppenarbeit_HSP
{
    class Program
    {

            static void Main(string[] args)
            {
                double m, p, c, hf, ha, df, db, d;
                int angle = 20;

                //Eingabe
                Console.WriteLine("Bitte geben Sie das Modul an: ");
                m = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Bitte geben Sie den Teilkreisdurchmesser an: ");
                d = Convert.ToInt32(Console.ReadLine());

                //Kopfspiel
                c = 0.167 * m;

                //Zahnfußhöhe
                hf = m + c;

                //Zahnkopfhöhe
                ha = m;

                //Teilung
                p = Math.PI * m;

                //Fußkreisdurchmesser
                df = d - 2 * (m + c);

                //Grundkreisdurchmesser
                db = d * Math.Cos(angle);

                c = Kopfspiel (m);  //Unterprogramm zur bestimmung der Kopfspiel
                
                static double Kopfspiel(double m)
                {

                    double c;
                    Console.WriteLine("Möchten Sie einen Kopfspiel eingeben? Ja=1 Nein=0");
                    int t = int.Parse(Console.ReadLine());
                if (t == 1)
                {
                    c = Convert.ToDouble(Console.ReadLine());
                    if (c >= 0.1 * m && c <= 0.3 * m)
                    {
                        return c;
                    }

                    else if (c < 0.1 * m || c > 0.3 * m)
                    {
                        Console.WriteLine("Bitte geben Sie einen gültigen Wert ein");
                        do

                            c = Convert.ToDouble(Console.ReadLine());
                        while (c >= 0.1 * m && c <= 0.3 * m);
                        {
                            return c;
                        }

                    }
                }
                else
                    c = 0.167 * m;
                return c;
                }

                //Ausgabe
                Console.WriteLine("Zahnfußhöhe: " + hf);
                Console.WriteLine("Zahnkopfhöhe: " + ha);
                Console.WriteLine("Teilung: " + p);
                Console.WriteLine("Fußkreisdurchmesser: " + df);
                Console.WriteLine("Grundkreisdurchmesser: " + db);
                Console.ReadKey();

            }
    }
}
