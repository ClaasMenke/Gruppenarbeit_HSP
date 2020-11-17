using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Gruppenarbeit_HSP_neu
{
    class Program
    {

        Program()
        {
            Window Fenster = new Window();  //Um graphisches objekt anzuzeigen, element aus wpf = Window
            Fenster.Title = "Zahnradberechnungen";

            GUI ourGUI = new GUI();
            // ansprechen einer Variablen in gui ourGUI.labRad1.content = "Bitte eingeben von...."
            Fenster.Content = ourGUI;
            Fenster.ShowDialog();
            
          
            
       }

        [STAThread]         // wird in nur einem Kern ausgeführt
        static void Main(string[] args)
        {
            new Program();

            //Einleitung
            Console.WriteLine("Herzlich Willkommen.");
            Console.WriteLine("Diese Software hilft Ihnen bei der Berechnung von Zahnrädern.");
            Console.WriteLine("");

            //Anweisungen
            Console.WriteLine("Bitte wählen Sie ob Sie Zahnräder mit außenliegendem Gegenrad(1) oder Zahnräder mit innenliegendem Gegenrad(2) berechnen möchten und bestätigen anschließend mit Enter.");
            string ii = "";   // Variable ii wird durch Eingabe erhalten, int = eine Ganzzahl
            Console.WriteLine("");
            while (ii != "1" && ii != "2")
            {
                ii = Console.ReadLine();
                //außenverzahnte Zahnräder
                if (ii == "1")                // für den Fall der Eingabe von 1 läuft folgende Abfrage:
                {
                    Außenverzahnung Az1 = new Außenverzahnung();
                    Az1.außenverzahnteZahnräder();
                }

                //innenverzahnte Zahnräder
                else if (ii == "2")           // gleich wie zuvor, nur für den Fall der Eingabe von 2
                {
                    Innenverzahnung Iz1 = new Innenverzahnung();
                    Iz1.innenverzahnteZahnräder();
                }

                else
                {   // Wenn die Eingabe weder 1 noch 2 war
                    Console.Clear();    // Console wird geleert sodass nur noch folgendes zu sehen ist:
                    Console.WriteLine("Fehler: Auswahl wurde nicht erkannt\nBitte wählen Sie ob Sie Zahnräder mit außenliegendem Gegenrad(1) oder Zahnräder mit innenliegendem Gegenrad(2)  ");


                }
            }

            //Ende
            Console.ReadKey();  // wartet auf eine Eingabe vom Benutzer, verhindert das automatische
                                // schließen der Console

         
        }
    }
}
