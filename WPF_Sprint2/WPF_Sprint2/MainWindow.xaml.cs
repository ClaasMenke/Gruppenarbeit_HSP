﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Sprint2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Berechnungen brg = new Berechnungen();
        Data dat = new Data();
        string modus = null;
        double preis = 0;
        double dichte = 0;
        //Methode zum leeren der TextBoxen und Ergebnislabel & Sichtbarkeit des TabControl
        private void ClearLabelUndTextbox()
        {
            tbx_Modul_Zahnrad1.Clear();
            tbx_Modul_Zahnrad1.Background = Brushes.White;
            tbx_Zaehnezahl_Zahnrad1.Clear();
            tbx_Zaehnezahl_Zahnrad1.Background = Brushes.White;
            lab_Teilkreisdurchmesser_Zahnrad1Ergebnis.Content = "wird berechnet...";
            tbx_Breite_Zahnrad1.Clear();
            tbx_Breite_Zahnrad1.Background = Brushes.White;

            lab_Modul_Zahnrad2Ergebnis.Content = "ist gleich Modul ZR1";
            tbx_Zaehnezahl_Zahnrad2.Clear();
            tbx_Zaehnezahl_Zahnrad2.Background = Brushes.White;
            lab_Teilkreisdurchmesser_Zahnrad2Ergebnis.Content = "wird berechnet...";
            tbx_Breite_Zahnrad2.Clear();
            tbx_Breite_Zahnrad2.Background = Brushes.White;

            lab_Teilung_Zahnrad1Ergebnis.Content = "";
            lab_Kopfspiel_Zahnrad1Ergebnis.Content = "";
            lab_Kopfkreisdurchmesser_Zahnrad1Ergebnis.Content = "";
            lab_Fußkreisdurchmesser_Zahnrad1Ergebnis.Content = "";
            lab_Grundkreisdurchmesser_Zahnrad1Ergebnis.Content = "";
            lab_Zahnkopfhoehe_Zahnrad1Ergebnis.Content = "";
            lab_Zahnfußhoehe_Zahnrad1Ergebnis.Content = "";
            lab_Zahnhoehe_Zahnrad1Ergebnis.Content = "";
            lab_Volumen_Zahnrad1Ergebnis.Content = "";
            lab_Masse_Zahnrad1Ergebnis.Content = "";
            lab_Preis_Zahnrad1Ergebnis.Content = "";

            lab_Teilung_Zahnrad2Ergebnis.Content = "";
            lab_Kopfspiel_Zahnrad2Ergebnis.Content = "";
            lab_Kopfkreisdurchmesser_Zahnrad2Ergebnis.Content = "";
            lab_Fußkreisdurchmesser_Zahnrad2Ergebnis.Content = "";
            lab_Grundkreisdurchmesser_Zahnrad2Ergebnis.Content = "";
            lab_Zahnkopfhoehe_Zahnrad2Ergebnis.Content = "";
            lab_Zahnfußhoehe_Zahnrad2Ergebnis.Content = "";
            lab_Zahnhoehe_Zahnrad2Ergebnis.Content = "";
            lab_Volumen_Zahnrad2Ergebnis.Content = "";
            lab_Masse_Zahnrad2Ergebnis.Content = "";
            lab_Preis_Zahnrad2Ergebnis.Content = "";
            lab_AchsabstandErgebnis.Content = "";

            tbc_allgemein.Visibility = Visibility.Visible;
            tbi_Eingabe.Focus();
            btn_Berechne.Visibility = Visibility.Visible;
        }

        private void KeineEingabe()
        {
            MessageBox.Show("Fehler!\nBitte geben Sie die benötigten Werte ein.");
            tbi_Eingabe.Focus();
            tbx_Modul_Zahnrad1.Background = Brushes.OrangeRed;
            tbx_Zaehnezahl_Zahnrad1.Background = Brushes.OrangeRed;
            tbx_Zaehnezahl_Zahnrad2.Background = Brushes.OrangeRed;
            tbx_Breite_Zahnrad1.Background = Brushes.OrangeRed;
            tbx_Breite_Zahnrad2.Background = Brushes.OrangeRed;
        }

        private void Hilfsparameter()
        {
            brg.TeilkreisRadius(dat.getModulZahnrad1(), dat.getZaehnezahlZahnrad1());
            brg.HilfskreisRadius(dat.getTeilkreisRadiusZahnrad1());
            brg.FußkreisRadius(dat.getTeilkreisRadiusZahnrad1(), dat.getModulZahnrad1());
            brg.KopfkreisRadius(dat.getTeilkreisRadiusZahnrad1(), dat.getModulZahnrad1());
            brg.VerrundungsRadius(dat.getModulZahnrad1());

            brg.Alpha();
            brg.Beta(dat.getZaehnezahlZahnrad1());
            brg.BetaRad(dat.getBetaZahnrad1());
            brg.Gamma(dat.getAlphaZahnrad1(), dat.getBetaZahnrad1());
            brg.GammaRad(dat.getGammaZahnrad1());
            brg.TotalAngle(dat.getZaehnezahlZahnrad1());
            brg.TotalAngleRad(dat.getTotalAngleZahnrad1());
        }

        //Methode für ein einzelne Außenverzahntes Zahnrad
        private void AußenverzahnungEinzel()
        {
            //EingangsParameter Zahnrad einzeln
            tbi_Ausgabe.Focus();

            double m1 = Convert.ToDouble(tbx_Modul_Zahnrad1.Text);
            dat.setModulZahnrad1(m1);
            int z1 = Convert.ToInt32(tbx_Zaehnezahl_Zahnrad1.Text);
            dat.setZaehnezahlZahnrad1(z1);
            double b1 = Convert.ToDouble(tbx_Breite_Zahnrad1.Text);
            dat.setBreiteZahnrad1(b1);

            //Ergebnis Teilkreisdurchmesser
            double d1 = brg.Teilkreisdurchmesser(dat.getModulZahnrad1(), dat.getZaehnezahlZahnrad1());
            dat.setTeilkreisdurchmesserZahnrad1(d1);
            lab_Teilkreisdurchmesser_Zahnrad1Ergebnis.Content = d1 + " mm";

            //Ergebnisse Zahnrad einzeln
            double p1 = brg.Teilung(dat.getModulZahnrad1());
            lab_Teilung_Zahnrad1Ergebnis.Content = p1 + " mm";
            double c1 = brg.Kopfspiel(dat.getModulZahnrad1());
            lab_Kopfspiel_Zahnrad1Ergebnis.Content = c1 + " mm";
            double da1 = brg.Kopfkreisdurchmesser_a(dat.getModulZahnrad1(), dat.getZaehnezahlZahnrad1());
            lab_Kopfkreisdurchmesser_Zahnrad1Ergebnis.Content = da1 + " mm";
            double df1 = brg.Fußkreisdurchmesser_a(dat.getTeilkreisdurchmesserZahnrad1(), dat.getModulZahnrad1(), c1);
            lab_Fußkreisdurchmesser_Zahnrad1Ergebnis.Content = df1 + " mm";
            double dg1 = brg.Grundkreisdurchmesser(dat.getTeilkreisdurchmesserZahnrad1());
            lab_Grundkreisdurchmesser_Zahnrad1Ergebnis.Content = dg1 + " mm";
            double ha1 = brg.Zahnkopfhöhe(dat.getModulZahnrad1());
            lab_Zahnkopfhoehe_Zahnrad1Ergebnis.Content = ha1 + " mm";
            double hf1 = brg.Zahnfußhöhe(dat.getModulZahnrad1(), c1);
            lab_Zahnfußhoehe_Zahnrad1Ergebnis.Content = hf1 + " mm";
            double h1 = brg.Zahnhöhe(dat.getModulZahnrad1(), c1);
            lab_Zahnhoehe_Zahnrad1Ergebnis.Content = h1 + " mm";
            double v1 = brg.Volumen(da1, dat.getBreiteZahnrad1());
            lab_Volumen_Zahnrad1Ergebnis.Content = v1 + " mm^3";

            double MASSE = brg.Masse(dichte, v1);
            lab_Masse_Zahnrad1Ergebnis.Content = MASSE + "kg";             //ergebnis der Masse
            double geld = brg.Geld(preis, MASSE);
            lab_Preis_Zahnrad1Ergebnis.Content = geld + "Euro";            //ergebnis der Preis

        }

        //Methode für ein einzelnes Innenverzahntes Zahnrad
        private void InnenverzahnungEinzel()
        {
            //EingangsParameter Zahnrad einzeln
            tbi_Ausgabe.Focus();

            double m1 = Convert.ToDouble(tbx_Modul_Zahnrad1.Text);
            dat.setModulZahnrad1(m1);
            int z1 = Convert.ToInt32(tbx_Zaehnezahl_Zahnrad1.Text);
            dat.setZaehnezahlZahnrad1(z1);
            double b1 = Convert.ToDouble(tbx_Breite_Zahnrad1.Text);
            dat.setBreiteZahnrad1(b1);

            double d1 = brg.Teilkreisdurchmesser(dat.getModulZahnrad1(), dat.getZaehnezahlZahnrad1());
            dat.setTeilkreisdurchmesserZahnrad1(d1);
            lab_Teilkreisdurchmesser_Zahnrad1Ergebnis.Content = d1 + " mm";


            //Ergebnisse Zahnrad einzeln
            double p1 = brg.Teilung(dat.getModulZahnrad1());
            lab_Teilung_Zahnrad1Ergebnis.Content = p1 + " mm";
            double c1 = brg.Kopfspiel(dat.getModulZahnrad1());
            lab_Kopfspiel_Zahnrad1Ergebnis.Content = c1 + " mm";
            double da1 = brg.Kopfkreisdurchmesser_i(dat.getModulZahnrad1(), dat.getZaehnezahlZahnrad1());
            lab_Kopfkreisdurchmesser_Zahnrad1Ergebnis.Content = da1 + " mm";
            double df1 = brg.Fußkreisdurchmesser_i(dat.getTeilkreisdurchmesserZahnrad1(), dat.getModulZahnrad1(), c1);
            lab_Fußkreisdurchmesser_Zahnrad1Ergebnis.Content = df1 + " mm";
            double dg1 = brg.Grundkreisdurchmesser(dat.getTeilkreisdurchmesserZahnrad1());
            lab_Grundkreisdurchmesser_Zahnrad1Ergebnis.Content = dg1 + " mm";
            double ha1 = brg.Zahnkopfhöhe(dat.getModulZahnrad1());
            lab_Zahnkopfhoehe_Zahnrad1Ergebnis.Content = ha1 + " mm";
            double hf1 = brg.Zahnfußhöhe(dat.getModulZahnrad1(), c1);
            lab_Zahnfußhoehe_Zahnrad1Ergebnis.Content = hf1 + " mm";
            double h1 = brg.Zahnhöhe(dat.getModulZahnrad1(), c1);
            lab_Zahnhoehe_Zahnrad1Ergebnis.Content = h1 + " mm";
            double v1 = brg.Volumen(da1, dat.getBreiteZahnrad1());
            lab_Volumen_Zahnrad1Ergebnis.Content = v1 + " mm^3";


            double MASSE = brg.Masse(dichte, v1);
            lab_Masse_Zahnrad1Ergebnis.Content = MASSE + "kg";             //ergebnis der Masse
            double geld = brg.Geld(preis, MASSE);
            lab_Preis_Zahnrad1Ergebnis.Content = geld + "Euro";            //ergebnis der Preis
        }

        //Metode für das jeweilige Gegenrad
        private void Gegenrad()
        {
            //EingangsParameter zweites Zahnrad
            double m12 = Convert.ToDouble(tbx_Modul_Zahnrad1.Text);
            dat.setModulZahnrad2(m12);
            lab_Modul_Zahnrad2Ergebnis.Content = m12 + " mm";
            int z12 = Convert.ToInt32(tbx_Zaehnezahl_Zahnrad2.Text);
            dat.setZaehnezahlZahnrad2(z12);
            double b12 = Convert.ToDouble(tbx_Breite_Zahnrad2.Text);
            dat.setBreiteZahnrad2(b12);

            double d12 = brg.Teilkreisdurchmesser(dat.getModulZahnrad2(), dat.getZaehnezahlZahnrad2());
            dat.setTeilkreisdurchmesserZahnrad2(d12);
            lab_Teilkreisdurchmesser_Zahnrad2Ergebnis.Content = d12 + " mm";

            //Ergebnisse Zahrad2
            double p12 = brg.Teilung(dat.getModulZahnrad2());
            lab_Teilung_Zahnrad2Ergebnis.Content = p12 + " mm";
            double c12 = brg.Kopfspiel(dat.getModulZahnrad2());
            lab_Kopfspiel_Zahnrad2Ergebnis.Content = c12 + " mm";
            double da12 = brg.Kopfkreisdurchmesser_a(dat.getModulZahnrad2(), dat.getZaehnezahlZahnrad2());
            lab_Kopfkreisdurchmesser_Zahnrad2Ergebnis.Content = da12 + " mm";
            double df12 = brg.Fußkreisdurchmesser_a(dat.getTeilkreisdurchmesserZahnrad2(), dat.getModulZahnrad2(), c12);
            lab_Fußkreisdurchmesser_Zahnrad2Ergebnis.Content = df12 + " mm";
            double dg12 = brg.Grundkreisdurchmesser(dat.getTeilkreisdurchmesserZahnrad2());
            lab_Grundkreisdurchmesser_Zahnrad2Ergebnis.Content = dg12 + " mm";
            double ha12 = brg.Zahnkopfhöhe(dat.getModulZahnrad2());
            lab_Zahnkopfhoehe_Zahnrad2Ergebnis.Content = ha12 + " mm";
            double hf12 = brg.Zahnfußhöhe(dat.getModulZahnrad2(), c12);
            lab_Zahnfußhoehe_Zahnrad2Ergebnis.Content = hf12 + " mm";
            double h12 = brg.Zahnhöhe(dat.getModulZahnrad2(), c12);
            lab_Zahnhoehe_Zahnrad2Ergebnis.Content = h12 + " mm";
            double v12 = brg.Volumen(da12, dat.getBreiteZahnrad2());
            lab_Volumen_Zahnrad2Ergebnis.Content = v12 + " mm^3";


            double MASSE2 = brg.Masse(dichte, v12);
            lab_Masse_Zahnrad2Ergebnis.Content = MASSE2 + "kg";             //ergebnis der Masse
            double geld2 = brg.Geld(preis, MASSE2);
            lab_Preis_Zahnrad2Ergebnis.Content = geld2 + "Euro";            //ergebnis der Preis
        }

        public MainWindow()
        {
            InitializeComponent();
            tbc_allgemein.Visibility = Visibility.Hidden;
            btn_Berechne.Visibility = Visibility.Hidden;
        }

        //TreeView Auswahl
        private void tvi_WerkstoffauswahlStahl_Selected(object sender, RoutedEventArgs e)
        {
            preis = 1.1;
            dichte = 7.85 * Math.Pow(10, -6);
            tvi_WerkstoffauswahlStahl.Background = Brushes.LightBlue;
            tvi_WerkstoffauswahlMessing.Background = Brushes.White;
        }

        private void tvi_WerkstoffauswahlMessing_Selected(object sender, RoutedEventArgs e)
        {
            preis = 2.7;
            dichte = 8.96 * Math.Pow(10, -6);
            tvi_WerkstoffauswahlMessing.Background = Brushes.LightBlue;
            tvi_WerkstoffauswahlStahl.Background = Brushes.White;
        }
        
        private void tvi_außen1_Selected(object sender, RoutedEventArgs e)
        {
            modus = "außen1";

            ClearLabelUndTextbox();

            grd_EingabeZahnrad2.Visibility = Visibility.Hidden;
            grd_AusgabeZahnrad2.Visibility = Visibility.Hidden;

            lab_EingabeZahnrad1.Content = "Für ein einzelnes außenverzahntes Stirnrad:";
            lab_AusgabeZahnrad1.Content = "Einzelnes außenverzahntes Stirnrad:";

            tvi_außen1.Background = Brushes.LightBlue;
            tvi_außen2.Background = Brushes.White;
            tvi_innen1.Background = Brushes.White;
            tvi_innen2.Background = Brushes.White;
        }

        private void tvi_außen2_Selected(object sender, RoutedEventArgs e)
        {
            modus = "außen2";

            ClearLabelUndTextbox();

            grd_EingabeZahnrad2.Visibility = Visibility.Visible;
            grd_AusgabeZahnrad2.Visibility = Visibility.Visible;

            lab_EingabeZahnrad1.Content = "Für das erste außenverzahnte Stirnrad:";
            lab_EingabeZahnrad2.Content = "Für das zweite außenverzahnte Stirnrad:";
            lab_AusgabeZahnrad1.Content = "Erstes außenverzahntes Stirnrad:";
            lab_AusgabeZahnrad2.Content = "Zweites außenverzahntes Stirnrad:";

            tvi_außen2.Background = Brushes.LightBlue;
            tvi_außen1.Background = Brushes.White;
            tvi_innen1.Background = Brushes.White;
            tvi_innen2.Background = Brushes.White;
        }

        private void tvi_innen1_Selected(object sender, RoutedEventArgs e)
        {
            modus = "innen1";

            ClearLabelUndTextbox();

            grd_EingabeZahnrad2.Visibility = Visibility.Hidden;
            grd_AusgabeZahnrad2.Visibility = Visibility.Hidden;

            lab_EingabeZahnrad1.Content = "Für ein einzelnes innenverzahntes Stirnrad:";
            lab_AusgabeZahnrad1.Content = "Einzelnes innenverzahntes Stirnrad:";


            tvi_innen1.Background = Brushes.LightBlue;
            tvi_innen2.Background = Brushes.White;
            tvi_außen1.Background = Brushes.White;
            tvi_außen2.Background = Brushes.White;
        }

        private void tvi_innen2_Selected(object sender, RoutedEventArgs e)
        {
            modus = "innen2";

            ClearLabelUndTextbox();

            grd_EingabeZahnrad2.Visibility = Visibility.Visible;
            grd_AusgabeZahnrad2.Visibility = Visibility.Visible;

            lab_EingabeZahnrad1.Content = "Für das erste, innenverzahnte Stirnrad:";
            lab_EingabeZahnrad2.Content = "Für das zweite, außenverzahnte Stirnrad:";
            lab_AusgabeZahnrad1.Content = "Erstes, innenverzahntes Stirnrad:";
            lab_AusgabeZahnrad2.Content = "Zweites, außenverzahntes Stirnrad:";

            tvi_innen2.Background = Brushes.LightBlue;
            tvi_innen1.Background = Brushes.White;
            tvi_außen1.Background = Brushes.White;
            tvi_außen2.Background = Brushes.White;

        }

        //Exit Button
        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Berechne Button
        private void btn_Berechne_Click_1(object sender, RoutedEventArgs e)
        {
            if (modus == "außen1")
            {
                try
                {
                    AußenverzahnungEinzel();
                    Hilfsparameter();
                }
                catch
                {
                    KeineEingabe();
                }
            }

            else if (modus == "außen2")
            {
                try
                {
                    AußenverzahnungEinzel();
                    Gegenrad();


                    //Ergebnis Achsabstand außenliegend
                    double aa = brg.Achsabstand_a(Convert.ToDouble(tbx_Modul_Zahnrad1.Text), Convert.ToInt32(tbx_Zaehnezahl_Zahnrad2.Text), Convert.ToInt32(tbx_Zaehnezahl_Zahnrad1.Text));
                    lab_AchsabstandErgebnis.Content = aa + " mm";
                }
                catch
                {
                    KeineEingabe();
                }
            }

            else if (modus == "innen1")
            {
                try
                {
                    InnenverzahnungEinzel();
                }
                catch
                {
                    KeineEingabe();
                }
            }

            else if (modus == "innen2")
            {
                try
                {
                    InnenverzahnungEinzel();
                    Gegenrad();

                    //Ergebnis Achsabstand außenliegend
                    double aa = brg.Achsabstand_i(Convert.ToDouble(tbx_Modul_Zahnrad1.Text), Convert.ToInt32(tbx_Zaehnezahl_Zahnrad2.Text), Convert.ToInt32(tbx_Zaehnezahl_Zahnrad1.Text));
                    lab_AchsabstandErgebnis.Content = aa + " mm";
                }
                catch
                {
                    KeineEingabe();
                }
            }
        }
        #region LostFocusMethoden
        //LostFocus Methoden (verlassen der Textbox oder ungültiger Wert)
        private void tbx_Modul_Zahnrad1_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Double res;

            if (Double.TryParse(tb.Text, out res) && res > 0)
            {
                tb.Background = Brushes.LightGreen;
            }
            else
            {
                MessageBox.Show("Fehler!\nBitte geben Sie einen gültigen Wert (größer als 0) ein.");
                tb.Background = Brushes.OrangeRed;
            }
        }

        private void tbx_Zaehnezahl_Zahnrad1_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Double res;

            if (Double.TryParse(tb.Text, out res) && res > 0)
            {
                tb.Background = Brushes.LightGreen;
            }
            else
            {
                MessageBox.Show("Fehler!\nBitte geben Sie einen gültigen Wert (größer als 0) ein.");
                tb.Background = Brushes.OrangeRed;
            }
        }

        private void tbx_Breite_Zahnrad1_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Double res;

            if (Double.TryParse(tb.Text, out res) && res > 0)
            {
                tb.Background = Brushes.LightGreen;
            }
            else
            {
                MessageBox.Show("Fehler!\nBitte geben Sie einen gültigen Wert (größer als 0) ein.");
                tb.Background = Brushes.OrangeRed;
            }
        }

        private void tbx_Zaehnezahl_Zahnrad2_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Double res;

            if (Double.TryParse(tb.Text, out res) && res > 0)
            {
                tb.Background = Brushes.LightGreen;
            }
            else
            {
                MessageBox.Show("Fehler!\nBitte geben Sie einen gültigen Wert (größer als 0) ein.");
                tb.Background = Brushes.OrangeRed;
            }
        }

        private void tbx_Breite_Zahnrad2_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Double res;

            if (Double.TryParse(tb.Text, out res) && res > 0)
            {
                tb.Background = Brushes.LightGreen;
            }
            else
            {
                MessageBox.Show("Fehler!\nBitte geben Sie einen gültigen Wert (größer als 0) ein.");
                tb.Background = Brushes.OrangeRed;
            }
        }
        #endregion

        private void btn_Catia_Click(object sender, RoutedEventArgs e)
        {
            CatiaConnection cc = new CatiaConnection();

            if (modus == "außen1")
            {
                    if (cc.CatiaLaeuft())
                    {
                        cc.ErzeugePart();

                        cc.ErstelleLeereSkizze();

                        cc.AußenverzahnungEinzel(dat);
                    }
            }

        }
    }
}
