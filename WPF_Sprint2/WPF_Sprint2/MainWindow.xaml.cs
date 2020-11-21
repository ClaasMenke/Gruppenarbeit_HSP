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
        public MainWindow()
        {
            InitializeComponent();
            tbc_außen.Visibility = Visibility.Hidden;
            tbc_innen.Visibility = Visibility.Hidden;
        }
        private void tvi_außen1_Selected(object sender, RoutedEventArgs e)
        {
            tbc_innen.Visibility = Visibility.Hidden;
            tbc_außen.Visibility = Visibility.Visible;

            btn_Berechne_außenEinzel.Visibility = Visibility.Visible;
            btn_Berechne_außenGegenrad.Visibility = Visibility.Hidden;
            btn_Berechne_innenEinzel.Visibility = Visibility.Hidden;
            btn_Berechne_innenGegenrad.Visibility = Visibility.Hidden;

            grd_EingabeAußenEinzel.Visibility = Visibility.Visible;
            grd_EingabeAußenGegenrad1.Visibility = Visibility.Hidden;
            grd_EingabeAußenGegenrad2.Visibility = Visibility.Hidden;
            grd_AusgabeAußenEinzel.Visibility = Visibility.Visible;
            grd_AusgabeAußenGegenrad1.Visibility = Visibility.Hidden;
            grd_AusgabeAußenGegenrad2.Visibility = Visibility.Hidden;
        }

        private void tvi_außen2_Selected(object sender, RoutedEventArgs e)
        {
            tbc_innen.Visibility = Visibility.Hidden;
            tbc_außen.Visibility = Visibility.Visible;

            btn_Berechne_außenEinzel.Visibility = Visibility.Hidden;
            btn_Berechne_außenGegenrad.Visibility = Visibility.Visible;
            btn_Berechne_innenEinzel.Visibility = Visibility.Hidden;
            btn_Berechne_innenGegenrad.Visibility = Visibility.Hidden;

            grd_EingabeAußenGegenrad1.Visibility = Visibility.Visible;
            grd_EingabeAußenGegenrad2.Visibility = Visibility.Visible;
            grd_EingabeAußenEinzel.Visibility = Visibility.Hidden;
            grd_AusgabeAußenEinzel.Visibility = Visibility.Hidden;
            grd_AusgabeAußenGegenrad1.Visibility = Visibility.Visible;
            grd_AusgabeAußenGegenrad2.Visibility = Visibility.Visible;
        }

        private void tvi_innen1_Selected(object sender, RoutedEventArgs e)
        {
            tbc_außen.Visibility = Visibility.Hidden;
            tbc_innen.Visibility = Visibility.Visible;

            btn_Berechne_außenEinzel.Visibility = Visibility.Hidden;
            btn_Berechne_außenGegenrad.Visibility = Visibility.Hidden;
            btn_Berechne_innenEinzel.Visibility = Visibility.Visible;
            btn_Berechne_innenGegenrad.Visibility = Visibility.Hidden;

            grd_EingabeInnenEinzel.Visibility = Visibility.Visible;
            grd_EingabeInnenGegenrad1.Visibility = Visibility.Hidden;
            grd_EingabeInnenGegenrad2.Visibility = Visibility.Hidden;
            grd_AusgabeInnenEinzel.Visibility = Visibility.Visible;
            grd_AusgabeInnenGegenrad1.Visibility = Visibility.Hidden;
            grd_AusgabeInnenGegenrad2.Visibility = Visibility.Hidden;
        }

        private void tvi_innen2_Selected(object sender, RoutedEventArgs e)
        {
            tbc_außen.Visibility = Visibility.Hidden;
            tbc_innen.Visibility = Visibility.Visible;

            btn_Berechne_außenEinzel.Visibility = Visibility.Hidden;
            btn_Berechne_außenGegenrad.Visibility = Visibility.Hidden;
            btn_Berechne_innenEinzel.Visibility = Visibility.Hidden;
            btn_Berechne_innenGegenrad.Visibility = Visibility.Visible;

            grd_EingabeInnenEinzel.Visibility = Visibility.Hidden;
            grd_EingabeInnenGegenrad1.Visibility = Visibility.Visible;
            grd_EingabeInnenGegenrad2.Visibility = Visibility.Visible;
            grd_AusgabeInnenEinzel.Visibility = Visibility.Hidden;
            grd_AusgabeInnenGegenrad1.Visibility = Visibility.Visible;
            grd_AusgabeInnenGegenrad2.Visibility = Visibility.Visible;
        }

        //Exit Button
        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Berechnungen für ein einzelnes außenverzahntes Stirnrad
        private void btn_Berechne_außenEinzel_Click_1(object sender, RoutedEventArgs e)
        {
            double m1 = Convert.ToDouble(tbx_Modul_außenEinzel.Text);
            int z1 = Convert.ToInt32(tbx_Zaehnezahl_außenEinzel.Text);
            double d1 = Convert.ToDouble(tbx_Teilkreisdurchmesser_außenEinzel.Text);
            double b1 = Convert.ToDouble(tbx_Breite_außenEinzel.Text);


            //Ergebnisse Zahnrad1 
            double p1 = brg.Teilung(m1);
            lab_Teilung_außenEinzelErgebnis.Content = p1 + " mm";
            double c1 = brg.Kopfspiel(m1);
            lab_Kopfspiel_außenEinzelErgebnis.Content = c1 + " mm";
            double da1 = brg.Kopfkreisdurchmesser_a(m1, z1);
            lab_Kopfkreisdurchmesser_außenEinzelErgebnis.Content = da1 + " mm";
            double df1 = brg.Fußkreisdurchmesser_a(d1, m1, c1);
            lab_Fußkreisdurchmesser_außenEinzelErgebnis.Content = df1 + " mm";
            double dg1 = brg.Grundkreisdurchmesser(d1);
            lab_Grundkreisdurchmesser_außenEinzelErgebnis.Content = dg1 + " mm";
            double ha1 = brg.Zahnkopfhöhe(m1);
            lab_Zahnkopfhoehe_außenEinzelErgebnis.Content = ha1 + " mm";
            double hf1 = brg.Zahnfußhöhe(m1, c1);
            lab_Zahnfußhoehe_außenEinzelErgebnis.Content = hf1 + " mm";
            double h1 = brg.Zahnhöhe(m1, c1);
            lab_Zahnhoehe_außenEinzelErgebnis.Content = h1 + " mm";
            double v1 = brg.Volumen(da1, b1);
            lab_Volumen_außenEinzelErgebnis.Content = v1 + " mm^3";
        }
        //Berechnungen für.. mit außenliegendem Gegenrad
        private void btn_Berechne_außenGegenrad_Click_1(object sender, RoutedEventArgs e)
        {
            //EingangsParameter erstes Zahnrad
            double m11 = Convert.ToDouble(tbx_Modul_außenGegenrad1.Text);
            int z11 = Convert.ToInt32(tbx_Zaehnezahl_außenGegenrad1.Text);
            double d11 = Convert.ToDouble(tbx_Teilkreisdurchmesser_außenGegenrad1.Text);
            double b11 = Convert.ToDouble(tbx_Breite_außenGegenrad1.Text);

            //EingangsParameter zweites Zahnrad
            double m12 = Convert.ToDouble(tbx_Modul_außenGegenrad2.Text);
            int z12 = Convert.ToInt32(tbx_Zaehnezahl_außenGegenrad2.Text);
            double d12 = Convert.ToDouble(tbx_Teilkreisdurchmesser_außenGegenrad2.Text);
            double b12 = Convert.ToDouble(tbx_Breite_außenGegenrad2.Text);

            //Ergebnisse Zahnrad 1
            double p11 = brg.Teilung(m11);
            lab_Teilung_außenGegenrad1Ergebnis.Content = p11 + " mm";
            double c11 = brg.Kopfspiel(m11);
            lab_Kopfspiel_außenGegenrad1Ergebnis.Content = c11 + " mm";
            double da11 = brg.Kopfkreisdurchmesser_a(m11, z11);
            lab_Kopfkreisdurchmesser_außenGegenrad1Ergebnis.Content = da11 + " mm";
            double df11 = brg.Fußkreisdurchmesser_a(d11, m11, c11);
            lab_Fußkreisdurchmesser_außenGegenrad1Ergebnis.Content = df11 + " mm";
            double dg11 = brg.Grundkreisdurchmesser(d11);
            lab_Grundkreisdurchmesser_außenGegenrad1Ergebnis.Content = dg11 + " mm";
            double ha11 = brg.Zahnkopfhöhe(m11);
            lab_Zahnkopfhoehe_außenGegenrad1Ergebnis.Content = ha11 + " mm";
            double hf11 = brg.Zahnfußhöhe(m11, c11);
            lab_Zahnfußhoehe_außenGegenrad1Ergebnis.Content = hf11 + " mm";
            double h11 = brg.Zahnhöhe(m11, c11);
            lab_Zahnhoehe_außenGegenrad1Ergebnis.Content = h11 + " mm";
            double v11 = brg.Volumen(da11, b11);
            lab_Volumen_außenGegenrad1Ergebnis.Content = v11 + " mm^3";

            //Ergebnisse Zahrad2
            double p12 = brg.Teilung(m12);
            lab_Teilung_außenGegenrad2Ergebnis.Content = p12 + " mm";
            double c12 = brg.Kopfspiel(m12);
            lab_Kopfspiel_außenGegenrad2Ergebnis.Content = c12 + " mm";
            double da12 = brg.Kopfkreisdurchmesser_a(m12, z12);
            lab_Kopfkreisdurchmesser_außenGegenrad2Ergebnis.Content = da12 + " mm";
            double df12 = brg.Fußkreisdurchmesser_a(d12, m12, c12);
            lab_Fußkreisdurchmesser_außenGegenrad2Ergebnis.Content = df12 + " mm";
            double dg12 = brg.Grundkreisdurchmesser(d12);
            lab_Grundkreisdurchmesser_außenGegenrad2Ergebnis.Content = dg12 + " mm";
            double ha12 = brg.Zahnkopfhöhe(m12);
            lab_Zahnkopfhoehe_außenGegenrad2Ergebnis.Content = ha12 + " mm";
            double hf12 = brg.Zahnfußhöhe(m12, c12);
            lab_Zahnfußhoehe_außenGegenrad2Ergebnis.Content = hf12 + " mm";
            double h12 = brg.Zahnhöhe(m12, c12);
            lab_Zahnhoehe_außenGegenrad2Ergebnis.Content = h12 + " mm";
            double v12 = brg.Volumen(da12, b12);
            lab_Volumen_außenGegenrad2Ergebnis.Content = v12 + " mm^3";

            //Ergebnis Achsabstand
            double aa = brg.Achsabstand_a(d12, d11);
            lab_Achsabstand_außenErgebnis.Content = aa + " mm";
        }

        //Berechnung innenverzahntes Stirnrad einzeln
        private void btn_Berechne_innenEinzel_Click_1(object sender, RoutedEventArgs e)
        {
            double m2 = Convert.ToDouble(tbx_Modul_innenEinzel.Text);
            int z2 = Convert.ToInt32(tbx_Zaehnezahl_innenEinzel.Text);
            double d2 = Convert.ToDouble(tbx_Teilkreisdurchmesser_innenEinzel.Text);
            double b2 = Convert.ToDouble(tbx_Breite_innenEinzel.Text);


            //Ergebnisse Zahnrad 
            double p2 = brg.Teilung(m2);
            lab_Teilung_innenEinzelErgebnis.Content = p2 + " mm";
            double c2 = brg.Kopfspiel(m2);
            lab_Kopfspiel_innenEinzelErgebnis.Content = c2 + " mm";
            double da2 = brg.Kopfkreisdurchmesser_i(m2, z2);
            lab_Kopfkreisdurchmesser_innenEinzelErgebnis.Content = da2 + " mm";
            double df2 = brg.Fußkreisdurchmesser_i(d2, m2, c2);
            lab_Fußkreisdurchmesser_innenEinzelErgebnis.Content = df2 + " mm";
            double dg2 = brg.Grundkreisdurchmesser(d2);
            lab_Grundkreisdurchmesser_innenEinzelErgebnis.Content = dg2 + " mm";
            double ha2 = brg.Zahnkopfhöhe(m2);
            lab_Zahnkopfhoehe_innenEinzelErgebnis.Content = ha2 + " mm";
            double hf2 = brg.Zahnfußhöhe(m2, c2);
            lab_Zahnfußhoehe_innenEinzelErgebnis.Content = hf2 + " mm";
            double h2 = brg.Zahnhöhe(m2, c2);
            lab_Zahnhoehe_innenEinzelErgebnis.Content = h2 + " mm";
            double v2 = brg.Volumen(da2, b2);
            lab_Volumen_innenEinzelErgebnis.Content = v2 + " mm^3";
        }

        //Berechnungen innenverzahnt mit Gegenrad
        private void btn_Berechne_innenGegenrad_Click_1(object sender, RoutedEventArgs e)
        {
            //EingangsParameter erstes Zahnrad
            double m21 = Convert.ToDouble(tbx_Modul_innenGegenrad1.Text);
            int z21 = Convert.ToInt32(tbx_Zaehnezahl_innenGegenrad1.Text);
            double d21 = Convert.ToDouble(tbx_Teilkreisdurchmesser_innenGegenrad1.Text);
            double b21 = Convert.ToDouble(tbx_Breite_innenGegenrad1.Text);

            //EingangsParameter zweites Zahnrad
            double m22 = Convert.ToDouble(tbx_Modul_innenGegenrad2.Text);
            int z22 = Convert.ToInt32(tbx_Zaehnezahl_innenGegenrad2.Text);
            double d22 = Convert.ToDouble(tbx_Teilkreisdurchmesser_innenGegenrad2.Text);
            double b22 = Convert.ToDouble(tbx_Breite_innenGegenrad2.Text);

            //Ergebnisse Zahnrad 1 (innenverzahnt)
            double p21 = brg.Teilung(m21);
            lab_Teilung_innenGegenrad1Ergebnis.Content = p21 + " mm";
            double c21 = brg.Kopfspiel(m21);
            lab_Kopfspiel_innenGegenrad1Ergebnis.Content = c21 + " mm";
            double da21 = brg.Kopfkreisdurchmesser_i(m21, z21);
            lab_Kopfkreisdurchmesser_innenGegenrad1Ergebnis.Content = da21 + " mm";
            double df21 = brg.Fußkreisdurchmesser_i(d21, m21, c21);
            lab_Fußkreisdurchmesser_innenGegenrad1Ergebnis.Content = df21 + " mm";
            double dg21 = brg.Grundkreisdurchmesser(d21);
            lab_Grundkreisdurchmesser_innenGegenrad1Ergebnis.Content = dg21 + " mm";
            double ha21 = brg.Zahnkopfhöhe(m21);
            lab_Zahnkopfhoehe_innenGegenrad1Ergebnis.Content = ha21 + " mm";
            double hf21 = brg.Zahnfußhöhe(m21, c21);
            lab_Zahnfußhoehe_innenGegenrad1Ergebnis.Content = hf21 + " mm";
            double h21 = brg.Zahnhöhe(m21, c21);
            lab_Zahnhoehe_innenGegenrad1Ergebnis.Content = h21 + " mm";
            double v21 = brg.Volumen(da21, b21);
            lab_Volumen_innenGegenrad1Ergebnis.Content = v21 + " mm^3";

            //Ergebnisse Zahrad2 (außenverzahnt)
            double p22 = brg.Teilung(m22);
            lab_Teilung_innenGegenrad2Ergebnis.Content = p22 + " mm";
            double c22 = brg.Kopfspiel(m22);
            lab_Kopfspiel_innenGegenrad2Ergebnis.Content = c22 + " mm";
            double da22 = brg.Kopfkreisdurchmesser_a(m22, z22);
            lab_Kopfkreisdurchmesser_innenGegenrad2Ergebnis.Content = da22 + " mm";
            double df22 = brg.Fußkreisdurchmesser_a(d22, m22, c22);
            lab_Fußkreisdurchmesser_innenGegenrad2Ergebnis.Content = df22 + " mm";
            double dg22 = brg.Grundkreisdurchmesser(d22);
            lab_Grundkreisdurchmesser_innenGegenrad2Ergebnis.Content = dg22 + " mm";
            double ha22 = brg.Zahnkopfhöhe(m22);
            lab_Zahnkopfhoehe_innenGegenrad2Ergebnis.Content = ha22 + " mm";
            double hf22 = brg.Zahnfußhöhe(m22, c22);
            lab_Zahnfußhoehe_innenGegenrad2Ergebnis.Content = hf22 + " mm";
            double h22 = brg.Zahnhöhe(m22, c22);
            lab_Zahnhoehe_innenGegenrad2Ergebnis.Content = h22 + " mm";
            double v22 = brg.Volumen(da22, b22);
            lab_Volumen_innenGegenrad2Ergebnis.Content = v22 + " mm^3";

            //Ergebnis Achsabstand
            double ai = brg.Achsabstand_i(d22, d21);
            lab_Achsabstand_innenErgebnis.Content = ai + " mm";
        }
    }
}
