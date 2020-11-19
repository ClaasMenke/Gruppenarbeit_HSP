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

        private void tvi_außen1_Selected(object sender, RoutedEventArgs e)
        {
            tbc_innen.Visibility = Visibility.Hidden;
            tbc_außen.Visibility = Visibility.Visible;
            grd_außenEinzel.Visibility = Visibility.Visible;
            grd_außenGegenrad1.Visibility = Visibility.Hidden;
            grd_außenGegenrad2.Visibility = Visibility.Hidden;

        }


        private void tvi_innen1_Selected(object sender, RoutedEventArgs e)
        {
            tbc_außen.Visibility = Visibility.Hidden;
            tbc_innen.Visibility = Visibility.Visible;
            grd_innenEinzel.Visibility = Visibility.Visible;
            grd_innenGegenrad1.Visibility = Visibility.Hidden;
            grd_innenGegenrad2.Visibility = Visibility.Hidden;
        }

        private void tvi_außen2_Selected(object sender, RoutedEventArgs e)
        {
            tbc_innen.Visibility = Visibility.Hidden;
            tbc_außen.Visibility = Visibility.Visible;
            grd_außenGegenrad1.Visibility = Visibility.Visible;
            grd_außenGegenrad2.Visibility = Visibility.Visible;
            grd_außenEinzel.Visibility = Visibility.Hidden;
        }

        private void tvi_innen2_Selected(object sender, RoutedEventArgs e)
        {
            tbc_außen.Visibility = Visibility.Hidden;
            tbc_innen.Visibility = Visibility.Visible;
            grd_innenEinzel.Visibility = Visibility.Hidden;
            grd_innenGegenrad1.Visibility = Visibility.Visible;
            grd_innenGegenrad2.Visibility = Visibility.Visible;
        }

    }

   
}
