using INFITF;
using MECMOD;
using PARTITF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_Sprint2
{
    class CatiaConnection
    {
        INFITF.Application hsp_catiaApp;
        MECMOD.PartDocument hsp_catiaPart;
        MECMOD.Sketch hsp_catiaProfil;

        internal bool CatiaLaeuft()
        {
            try
            {
                object catiaObj = System.Runtime.InteropServices.Marshal.GetActiveObject("CATIA.Application");
                hsp_catiaApp = (INFITF.Application)catiaObj;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal void ErzeugePart()
        {
            Documents catDocuments = hsp_catiaApp.Documents;
            hsp_catiaPart = (PartDocument)catDocuments.Add("Part");
        }
        internal void ErstelleLeereSkizze()
        {
            //geometrisches set auswählen und umbenennen
            HybridBodies catHybridBodies1 = hsp_catiaPart.Part.HybridBodies;
            HybridBody catHybridBody1;

            try
            {
                catHybridBody1 = catHybridBodies1.Item("Geometrisches Set.1");
            }
            catch (Exception)
            {
                MessageBox.Show("Kein geometrisches Set gefunden! " + Environment.NewLine +
                    "Ein PART manuell erzeugen und ein darauf achten, dass 'Geometisches Set' aktiviert ist.",
                    "Fehler", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            catHybridBody1.set_Name("Profile");

            //Neue Skizze im ausgewählten geometrischen Set anlegen
            Sketches catSketches1 = catHybridBody1.HybridSketches;
            OriginElements catOriginElements = hsp_catiaPart.Part.OriginElements;
            Reference catReference1 = (Reference)catOriginElements.PlaneYZ;
            hsp_catiaProfil = catSketches1.Add(catReference1);

            //Achsensystem in Skizze erzeugen
            ErzeugeAchsensystem();

            //Part aktualisieren
            hsp_catiaPart.Part.Update();
        }

        private void ErzeugeAchsensystem()
        {
            object[] arr = new object[] {0.0, 0.0, 0.0,
                                         0.0, 1.0, 0.0,
                                         0.0, 0.0, 1.0 };
            hsp_catiaProfil.SetAbsoluteAxisData(arr);
        }

        internal void ErzeugeAußenverzahnungSkizze()
        {
            //Skizze umbenennen
            hsp_catiaProfil.set_Name("Außenverzahnung");

            //Skizze öffnen 
            Factory2D catFactory2D1 = hsp_catiaProfil.OpenEdition();

            
        }
    }
}
