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

namespace Gruppenarbeit_HSP_neu
{
    /// <summary>
    /// Interaktionslogik für GUI.xaml
    /// </summary>
    public partial class GUI : UserControl
    {
        public GUI()
        {
            InitializeComponent();
            tbc_außen.Visibility = Visibility.Hidden;
            tbc_innen.Visibility = Visibility.Hidden;
   
        }

        //wenn TreeviewItem "außenverzahnte Stirnräder..Zahnrad einzeln" ausgewählt ist
        private void tvi_außen1_Selected(object sender, RoutedEventArgs e)
        {
            tbc_innen.Visibility = Visibility.Hidden;
            tbc_außen.Visibility = Visibility.Visible;
            grd_EingabeAußenEinzel.Visibility = Visibility.Visible;
            grd_EingabeAußenGegenrad1.Visibility = Visibility.Hidden;
            grd_EingabeAußenGegenrad2.Visibility = Visibility.Hidden;
            grd_AusgabeAußenEinzel.Visibility = Visibility.Visible;
            grd_AusgabeAußenGegenrad1.Visibility = Visibility.Hidden;
            grd_AusgabeAußenGegenrad2.Visibility = Visibility.Hidden;

        }

        // wenn TreeviewItem "innenverzahnte Stirnräder.. Zahnrad einzeln" ausgewählt ist
        private void tvi_innen1_Selected(object sender, RoutedEventArgs e)
        {
            tbc_außen.Visibility = Visibility.Hidden;
            tbc_innen.Visibility = Visibility.Visible;
            grd_EingabeInnenEinzel.Visibility = Visibility.Visible;
            grd_EingabeInnenGegenrad1.Visibility = Visibility.Hidden;
            grd_EingabeInnenGegenrad2.Visibility = Visibility.Hidden;
            grd_AusgabeInnenEinzel.Visibility = Visibility.Visible;
            grd_AusgabeInnenGegenrad1.Visibility = Visibility.Hidden;
            grd_AusgabeInnenGegenrad2.Visibility = Visibility.Hidden;
        }

        //wenn TvI "außenverzahnte Stirnräder... mit Gegenrad" ausgewählt ist
        private void tvi_außen2_Selected(object sender, RoutedEventArgs e)
        {
            tbc_innen.Visibility = Visibility.Hidden;
            tbc_außen.Visibility = Visibility.Visible;
            grd_EingabeAußenGegenrad1.Visibility = Visibility.Visible;
            grd_EingabeAußenGegenrad2.Visibility = Visibility.Visible;
            grd_EingabeAußenEinzel.Visibility = Visibility.Hidden;
            grd_AusgabeAußenEinzel.Visibility = Visibility.Hidden;
            grd_AusgabeAußenGegenrad1.Visibility = Visibility.Visible;
            grd_AusgabeAußenGegenrad2.Visibility = Visibility.Visible;
        }

        //wenn TvI "innenverzahnte Stirnräder... mit Gegenrad" ausgewählt ist
        private void tvi_innen2_Selected(object sender, RoutedEventArgs e)
        {
            tbc_außen.Visibility = Visibility.Hidden;
            tbc_innen.Visibility = Visibility.Visible;
            grd_EingabeInnenEinzel.Visibility = Visibility.Hidden;
            grd_EingabeInnenGegenrad1.Visibility = Visibility.Visible;
            grd_EingabeInnenGegenrad2.Visibility = Visibility.Visible;
            grd_AusgabeInnenEinzel.Visibility = Visibility.Hidden;
            grd_AusgabeInnenGegenrad1.Visibility = Visibility.Visible;
            grd_AusgabeInnenGegenrad2.Visibility = Visibility.Visible;
        }

        //Button Exit
        private void btn_Exit_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();
    }

   
}
