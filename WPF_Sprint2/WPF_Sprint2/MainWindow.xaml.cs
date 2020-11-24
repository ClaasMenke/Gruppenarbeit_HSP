using System;
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
            tbx_Teilkreisdurchmesser_Zahnrad1.Clear();
            tbx_Teilkreisdurchmesser_Zahnrad1.Background = Brushes.White;
            tbx_Breite_Zahnrad1.Clear();
            tbx_Breite_Zahnrad1.Background = Brushes.White;

            tbx_Modul_Zahnrad2.Clear();
            tbx_Modul_Zahnrad2.Background = Brushes.White;
            tbx_Zaehnezahl_Zahnrad2.Clear();
            tbx_Zaehnezahl_Zahnrad2.Background = Brushes.White;
            tbx_Teilkreisdurchmesser_Zahnrad2.Clear();
            tbx_Teilkreisdurchmesser_Zahnrad2.Background = Brushes.White;
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

            lab_Teilung_Zahnrad2Ergebnis.Content = "";
            lab_Kopfspiel_Zahnrad2Ergebnis.Content = "";
            lab_Kopfkreisdurchmesser_Zahnrad2Ergebnis.Content = "";
            lab_Fußkreisdurchmesser_Zahnrad2Ergebnis.Content = "";
            lab_Grundkreisdurchmesser_Zahnrad2Ergebnis.Content = "";
            lab_Zahnkopfhoehe_Zahnrad2Ergebnis.Content = "";
            lab_Zahnfußhoehe_Zahnrad2Ergebnis.Content = "";
            lab_Zahnhoehe_Zahnrad2Ergebnis.Content = "";
            lab_Volumen_Zahnrad2Ergebnis.Content = "";
            lab_AchsabstandErgebnis.Content = "";

            tbc_allgemein.Visibility = Visibility.Visible;
            tbi_Eingabe.Focus();
        }

        //Methode für ein einzelne Außenverzahntes Zahnrad
        private void AußenverzahnungEinzel()
        {
            //EingangsParameter Zahnrad einzeln
            tbi_Ausgabe.Focus();

            double m1 = Convert.ToDouble(tbx_Modul_Zahnrad1.Text);
            int z1 = Convert.ToInt32(tbx_Zaehnezahl_Zahnrad1.Text);
            double d1 = Convert.ToDouble(tbx_Teilkreisdurchmesser_Zahnrad1.Text);
            double b1 = Convert.ToDouble(tbx_Breite_Zahnrad1.Text);


            //Ergebnisse Zahnrad einzeln
            double p1 = brg.Teilung(m1);
            lab_Teilung_Zahnrad1Ergebnis.Content = p1 + " mm";
            double c1 = brg.Kopfspiel(m1);
            lab_Kopfspiel_Zahnrad1Ergebnis.Content = c1 + " mm";
            double da1 = brg.Kopfkreisdurchmesser_a(m1, z1);
            lab_Kopfkreisdurchmesser_Zahnrad1Ergebnis.Content = da1 + " mm";
            double df1 = brg.Fußkreisdurchmesser_a(d1, m1, c1);
            lab_Fußkreisdurchmesser_Zahnrad1Ergebnis.Content = df1 + " mm";
            double dg1 = brg.Grundkreisdurchmesser(d1);
            lab_Grundkreisdurchmesser_Zahnrad1Ergebnis.Content = dg1 + " mm";
            double ha1 = brg.Zahnkopfhöhe(m1);
            lab_Zahnkopfhoehe_Zahnrad1Ergebnis.Content = ha1 + " mm";
            double hf1 = brg.Zahnfußhöhe(m1, c1);
            lab_Zahnfußhoehe_Zahnrad1Ergebnis.Content = hf1 + " mm";
            double h1 = brg.Zahnhöhe(m1, c1);
            lab_Zahnhoehe_Zahnrad1Ergebnis.Content = h1 + " mm";
            double v1 = brg.Volumen(da1, b1);
            lab_Volumen_Zahnrad1Ergebnis.Content = v1 + " mm^3";

            double MASSE = brg.Masse(dichte, v1);
            lab_Masse_ergebnis.Content = MASSE + "kg";             //ergebnis der Masse
            double geld = brg.Geld(preis, MASSE);
            lab_preis_ergebnis.Content = geld + "Euro";            //ergebnis der Preis

        }

        //Methode für ein einzelnes Innenverzahntes Zahnrad
        private void InnenverzahnungEinzel()
        {
            //EingangsParameter Zahnrad einzeln
            tbi_Ausgabe.Focus();

            double m1 = Convert.ToDouble(tbx_Modul_Zahnrad1.Text);
            int z1 = Convert.ToInt32(tbx_Zaehnezahl_Zahnrad1.Text);
            double d1 = Convert.ToDouble(tbx_Teilkreisdurchmesser_Zahnrad1.Text);
            double b1 = Convert.ToDouble(tbx_Breite_Zahnrad1.Text);


            //Ergebnisse Zahnrad einzeln
            double p1 = brg.Teilung(m1);
            lab_Teilung_Zahnrad1Ergebnis.Content = p1 + " mm";
            double c1 = brg.Kopfspiel(m1);
            lab_Kopfspiel_Zahnrad1Ergebnis.Content = c1 + " mm";
            double da1 = brg.Kopfkreisdurchmesser_i(m1, z1);
            lab_Kopfkreisdurchmesser_Zahnrad1Ergebnis.Content = da1 + " mm";
            double df1 = brg.Fußkreisdurchmesser_i(d1, m1, c1);
            lab_Fußkreisdurchmesser_Zahnrad1Ergebnis.Content = df1 + " mm";
            double dg1 = brg.Grundkreisdurchmesser(d1);
            lab_Grundkreisdurchmesser_Zahnrad1Ergebnis.Content = dg1 + " mm";
            double ha1 = brg.Zahnkopfhöhe(m1);
            lab_Zahnkopfhoehe_Zahnrad1Ergebnis.Content = ha1 + " mm";
            double hf1 = brg.Zahnfußhöhe(m1, c1);
            lab_Zahnfußhoehe_Zahnrad1Ergebnis.Content = hf1 + " mm";
            double h1 = brg.Zahnhöhe(m1, c1);
            lab_Zahnhoehe_Zahnrad1Ergebnis.Content = h1 + " mm";
            double v1 = brg.Volumen(da1, b1);
            lab_Volumen_Zahnrad1Ergebnis.Content = v1 + " mm^3";


            double MASSE = brg.Masse(dichte, v1);
            lab_Masse_ergebnis.Content = MASSE + "kg";             //ergebnis der Masse
            double geld = brg.Geld(preis, MASSE);
            lab_preis_ergebnis.Content = geld + "Euro";            //ergebnis der Preis
        }

        //Metode für das jeweilige Gegenrad
        private void Gegenrad()
        {
            //EingangsParameter zweites Zahnrad
            double m12 = Convert.ToDouble(tbx_Modul_Zahnrad2.Text);
            int z12 = Convert.ToInt32(tbx_Zaehnezahl_Zahnrad2.Text);
            double d12 = Convert.ToDouble(tbx_Teilkreisdurchmesser_Zahnrad2.Text);
            double b12 = Convert.ToDouble(tbx_Breite_Zahnrad2.Text);

            //Ergebnisse Zahrad2
            double p12 = brg.Teilung(m12);
            lab_Teilung_Zahnrad2Ergebnis.Content = p12 + " mm";
            double c12 = brg.Kopfspiel(m12);
            lab_Kopfspiel_Zahnrad2Ergebnis.Content = c12 + " mm";
            double da12 = brg.Kopfkreisdurchmesser_a(m12, z12);
            lab_Kopfkreisdurchmesser_Zahnrad2Ergebnis.Content = da12 + " mm";
            double df12 = brg.Fußkreisdurchmesser_a(d12, m12, c12);
            lab_Fußkreisdurchmesser_Zahnrad2Ergebnis.Content = df12 + " mm";
            double dg12 = brg.Grundkreisdurchmesser(d12);
            lab_Grundkreisdurchmesser_Zahnrad2Ergebnis.Content = dg12 + " mm";
            double ha12 = brg.Zahnkopfhöhe(m12);
            lab_Zahnkopfhoehe_Zahnrad2Ergebnis.Content = ha12 + " mm";
            double hf12 = brg.Zahnfußhöhe(m12, c12);
            lab_Zahnfußhoehe_Zahnrad2Ergebnis.Content = hf12 + " mm";
            double h12 = brg.Zahnhöhe(m12, c12);
            lab_Zahnhoehe_Zahnrad2Ergebnis.Content = h12 + " mm";
            double v12 = brg.Volumen(da12, b12);
            lab_Volumen_Zahnrad2Ergebnis.Content = v12 + " mm^3";


            double MASSE2 = brg.Masse(dichte, v12);
            lab_masse_ergebnis2.Content = MASSE2 + "kg";             //ergebnis der Masse
            double geld2 = brg.Geld(preis, MASSE2);
            label_preis2_ergebnise.Content = geld2 + "Euro";            //ergebnis der Preis
        }

        public MainWindow()
        {
            InitializeComponent();
            tbc_allgemein.Visibility = Visibility.Hidden;
        }

        //TreeView Auswahl
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
                AußenverzahnungEinzel();
            }

            else if (modus == "außen2")
            {
                AußenverzahnungEinzel();
                Gegenrad();

                //Ergebnis Achsabstand außenliegend
                double aa = brg.Achsabstand_a(Convert.ToDouble(tbx_Teilkreisdurchmesser_Zahnrad2.Text), Convert.ToDouble(tbx_Teilkreisdurchmesser_Zahnrad1.Text));
                lab_AchsabstandErgebnis.Content = aa + " mm";
            }

            else if (modus == "innen1")
            {
                InnenverzahnungEinzel();
            }

            else if (modus == "innen2")
            {
                InnenverzahnungEinzel();
                Gegenrad();

                //Ergebnis Achsabstand außenliegend
                double aa = brg.Achsabstand_i(Convert.ToDouble(tbx_Teilkreisdurchmesser_Zahnrad2.Text), Convert.ToDouble(tbx_Teilkreisdurchmesser_Zahnrad1.Text));
                lab_AchsabstandErgebnis.Content = aa + " mm";
            }
        }

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

        private void tbx_Teilkreisdurchmesser_Zahnrad1_LostFocus(object sender, RoutedEventArgs e)
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

        private void tbx_Modul_Zahnrad2_LostFocus(object sender, RoutedEventArgs e)
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

        private void tbx_Teilkreisdurchmesser_Zahnrad2_LostFocus(object sender, RoutedEventArgs e)
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
        private void Wk_zahnrad_messig_Selected(object sender, RoutedEventArgs e)
        {
            preis = 2.7;
            dichte = 8.96 * Math.Pow(10, -6);
            Wk_zahnrad_messig.Background = Brushes.LightBlue;
            Wk_zhanrad_stahl.Background = Brushes.White;
        }

        private void Wk_zhanrad_stahl_Selected(object sender, RoutedEventArgs e)
        {
            preis = 1.1;
            dichte = 7.85 * Math.Pow(10, -6);
            Wk_zhanrad_stahl.Background = Brushes.LightBlue;
            Wk_zahnrad_messig.Background = Brushes.White;
        }
    }
}
