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
    }
}
