using ProductStructureTypeLib;
using HybridShapeTypeLib;
using INFITF;
using KnowledgewareTypeLib;
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

        internal void AußenverzahnungEinzel(Data dat)
        {

            //Skizze umbenennen
            hsp_catiaProfil.set_Name("Außenverzahnung");

            //Skizze öffnen 
            Factory2D catFactory2D1 = hsp_catiaProfil.OpenEdition();

            Point2D catP2D_1 = catFactory2D1.CreatePoint(0, dat.getHilfskreisRadiusZahnrad1());
            

            //Kreis
            Circle2D catC2D_1 = catFactory2D1.CreateClosedCircle(0, 0, dat.getFußkreisRadiusZahnrad1());
            catC2D_1.Construction = true;          

            //konstruktionskreis Kopfkreisradius
            Circle2D catC2D_2 = catFactory2D1.CreateClosedCircle(0, 0, dat.getKopfkreisRadiusZahnrad1());
            catC2D_2.Construction = true;

            //Konstrukitionskreis Hilfskreis
            Circle2D catC2D_3 = catFactory2D1.CreateClosedCircle(0, 0, dat.getHilfskreisRadiusZahnrad1());
            catC2D_3.Construction = true;

            //Konstruktionskreis Teilkreisradius
            Circle2D catC2D_4 = catFactory2D1.CreateClosedCircle(0, 0, dat.getTeilkreisRadiusZahnrad1());
            catC2D_4.Construction = true;

            //Hilfkreis Evolvente
            //Circle2D catC2D_5 = catFactory2D1.CreateClosedCircle(0, 0, dat.getVerrundungsRadiusZahnrad1());
            //catC2D_5.CenterPoint = ;

            //Kreismuster
            ShapeFactory SF = (ShapeFactory)hsp_catiaPart.Part.ShapeFactory;
            HybridShapeFactory HSF = (HybridShapeFactory)hsp_catiaPart.Part.HybridShapeFactory;
            Part myPart = hsp_catiaPart.Part;

            //Refrenzen und Skizze
            Factory2D Factory2D1 = hsp_catiaProfil.Factory2D;
            HybridShapePointCoord Ursprung = HSF.AddNewPointCoord(0, 0, 0);
            Reference RefUrsprung = myPart.CreateReferenceFromObject(Ursprung);
            HybridShapeDirection XDir = HSF.AddNewDirectionByCoord(1, 0, 0);
            Reference RefXDir = myPart.CreateReferenceFromObject(XDir);

            //Kreismuster mit Daten füllen
            CircPattern Kreismuster = SF.AddNewSurfacicCircPattern(Factory2D1, 1, 2, 0, 0, 1, 1, RefUrsprung, RefXDir, false, 0, true, false);
            Kreismuster.CircularPatternParameters = CatCircularPatternParameters.catInstancesandAngularSpacing;
            AngularRepartition angularRepartition1 = Kreismuster.AngularRepartition;
            Angle angle1 = angularRepartition1.AngularSpacing;
            angle1.Value = Convert.ToDouble(360 / Convert.ToInt32(dat.getZaehnezahlZahnrad1()));
            AngularRepartition angularRepartition2 = Kreismuster.AngularRepartition;
            IntParam intParam1 = angularRepartition2.InstancesCount;
            intParam1.Value = Convert.ToInt32(dat.getZaehnezahlZahnrad1()) + 1;

            //geschlossene Kontur
            Reference Ref_Kreismuster = myPart.CreateReferenceFromObject(Kreismuster);
            HybridShapeAssemble Verbindung = HSF.AddNewJoin(Ref_Kreismuster, Ref_Kreismuster);
            Reference Ref_Verbindung = myPart.CreateReferenceFromObject(Verbindung);

            HSF.GSMVisibility(Ref_Verbindung, 0);

            myPart.Update();

            Bodies bodies = myPart.Bodies;
            Body myBody = bodies.Add();
            myBody.set_Name("Zahnrad");
            myBody.InsertHybridShape(Verbindung);

            myPart.Update();

            myPart.InWorkObject = myBody;
            Pad myPad = SF.AddNewPadFromRef(Ref_Verbindung, dat.getBreiteZahnrad1());
            myPart.Update();
        }
    }
}
