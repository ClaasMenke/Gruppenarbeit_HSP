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
