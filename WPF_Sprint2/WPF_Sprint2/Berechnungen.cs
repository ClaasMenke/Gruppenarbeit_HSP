﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Sprint2
{
    class Berechnungen
    { 

        //Teilkreisdurchmesser
        public double Teilkreisdurchmesser(double m, double z)
        {
            double d = m * z;
            return d;
        }

        //Teilung
        public double Teilung(double m)     // public double Teilung = die erstellung einer Variablen, Datentyp schließt Kommazahlen mit ein
        {                                   // m = Modul
            double p = Math.PI * m;
            return Math.Round(p, 2);        // Ausgabe von p auf zwei Nachkommastellen gerundet
        }

        //Kopfspiel
        public double Kopfspiel(double m)
        {
            double c = 0.167 * m;           // 0.167 * m angenommen, da am häufigsten verwendet
            return Math.Round(c, 2);
        }

        //Kopfkreisdurchmesser außenverzahnt
        public double Kopfkreisdurchmesser_a(double m, double z)    // z = Zähnezahl
        {
            double da = m * (z + 2);
            return Math.Round(da, 2);
        }

        //Fußkreisdurchmesser außenverzahnt 
        public double Fußkreisdurchmesser_a(double d, double m, double c)   // d = Teilkreisdurchmesser
        {                                                                   // c = Kopfspiel
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
            double df = d + 2 * (m + c);
            return Math.Round(df, 2);
        }

        //Grundkreisdurchmesser
        public double Grundkreisdurchmesser(double d)
        {
            double nw = 20 * Math.PI / 180;     // nw = Normaleingriffswinkel (20 Grad nach Normverzahnung)
            double dg = d * Math.Cos(nw);       // dg = Grundkreisdurchmesser
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
            double h = 2 * m + c;
            return Math.Round(h, 2);
        }

        //Volumen
        public double Volumen(double da, double b) 
        {
            double v = Math.PI * Math.Pow(da / 2, 2) * b;     
            return Math.Round(v, 2);
        }

        //Achsabstand mit außenliegendem Gegenrad
        public double Achsabstand_a(double m, double z1, double z2)   // d1 = Durchmesser Zahnrad 1/ d2 = für Zr 2
        {
            double aa = (m * (z1 + z2)) / 2;
            return Math.Round(aa, 2);
        }

        //Achsabstand mit innenliegendem Gegenrad
        public double Achsabstand_i(double m, double z1, double z2)
        {
            double ai = (m * (z2 - z1)) / 2;
            return Math.Round(ai, 2);
        }

        //Masse
        public double Masse(double dichte, double v)
        {
            double masse = dichte * v;
            return Math.Round(masse, 2);
        }

        //Preis
        public double Geld(double preis, double masse)
        {
            double geld = preis * masse;
            return Math.Round(geld, 2);
            
        }
    }
}
