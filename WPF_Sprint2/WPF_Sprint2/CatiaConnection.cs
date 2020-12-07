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
        PartDocument hsp_catiaPart;
        Sketch hsp_catiaProfil;

        public bool CatiaLaeuft()
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

        public void ErzeugePart()
        {
            Documents catDocuments = hsp_catiaApp.Documents;
            hsp_catiaPart = (PartDocument)catDocuments.Add("Part");
        }
        public void ErstelleLeereSkizze()
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

        public void AußenverzahnungEinzel(Data dat)
        {
            //Nullpunte
            double x0 = 0;
            double y0 = 0;

            //Punkte
            //Koordinaten MitellPkt. Evolventen Kreis
            double MPEvolvente_x = dat.getHilfskreisRadiusZahnrad1() * Math.Cos(dat.getGammaRadZahnrad1());
            double MPEvolvente_y = dat.getHilfskreisRadiusZahnrad1() * Math.Sin(dat.getGammaRadZahnrad1());

            //Schnittpkt. Evolvente & TeilkreisRadius
            double SPEvolventeTeilkreis_x = -dat.getTeilkreisRadiusZahnrad1() * Math.Sin(dat.getBetaRadZahnrad1());
            double SPEvolventeTeilkreis_y = dat.getTeilkreisRadiusZahnrad1() * Math.Cos(dat.getBetaRadZahnrad1());

            //Radius EvolventenKreis 
            double Evolvente_r = Math.Sqrt(Math.Pow((MPEvolvente_x - SPEvolventeTeilkreis_x),2) + Math.Pow((MPEvolvente_y - SPEvolventeTeilkreis_y),2));

            //Schnittpunkt Evolventenkreis & Kopfkreis
            double SPEvolventenKopfkreis_x = SchnittPunkt_x(x0, y0, dat.getKopfkreisRadiusZahnrad1(), MPEvolvente_x, MPEvolvente_y, Evolvente_r);
            double SPEvolventenKopfkreis_y = Schnittpunkt_y(x0, y0, dat.getKopfkreisRadiusZahnrad1(), MPEvolvente_x, MPEvolvente_y, Evolvente_r);

            //Koordinaten MittelPkt. VerrundungsRadius
            double MPVerrundung_x = SchnittPunkt_x(x0, y0, dat.getFußkreisRadiusZahnrad1() + dat.getVerrundungsRadiusZahnrad1(), MPEvolvente_x, MPEvolvente_y, Evolvente_r + dat.getVerrundungsRadiusZahnrad1());
            double MPVerrundung_y = Schnittpunkt_y(x0, y0, dat.getFußkreisRadiusZahnrad1() + dat.getVerrundungsRadiusZahnrad1(), MPEvolvente_x, MPEvolvente_y, Evolvente_r + dat.getVerrundungsRadiusZahnrad1());

            //Schnittpunkt Evolventenkreis & Verrundung
            double SPEvolventeVerrundung_x = SchnittPunkt_x(MPEvolvente_x, MPEvolvente_y, Evolvente_r, MPVerrundung_x, MPVerrundung_y, dat.getVerrundungsRadiusZahnrad1());
            double SPEvolventeVerrundung_y = Schnittpunkt_y(MPEvolvente_x, MPEvolvente_y, Evolvente_r, MPVerrundung_x, MPVerrundung_y, dat.getVerrundungsRadiusZahnrad1());

            //Schnittpunkt Fußkreis & Verrundung
            double SPFußkreisVerrundung_x = SchnittPunkt_x(x0, y0, dat.getFußkreisRadiusZahnrad1(), MPVerrundung_x, MPVerrundung_y, dat.getVerrundungsRadiusZahnrad1());
            double SPFußkreisVerrundung_y = Schnittpunkt_y(x0, y0, dat.getFußkreisRadiusZahnrad1(), MPVerrundung_x, MPVerrundung_y, dat.getVerrundungsRadiusZahnrad1());

            //Anfangspunkt Fußkreis
            double HW = dat.getTotalAngleRadZahnrad1() - Math.Atan(Math.Abs(SPFußkreisVerrundung_x) / Math.Abs(SPFußkreisVerrundung_y));
            double APFußkreis_x = -dat.getFußkreisRadiusZahnrad1() * Math.Sin(HW);
            double APFußkreis_y = dat.getFußkreisRadiusZahnrad1() * Math.Cos(HW);



            //Skizze umbenennen
            hsp_catiaProfil.set_Name("Außenverzahnung");
            //Skizze öffnen 
            Factory2D catFactory2D1 = hsp_catiaProfil.OpenEdition();

            //Punkte
            Point2D catP2D_Ursprung = catFactory2D1.CreatePoint(x0, y0);

            Point2D catP2D_APFußkreis = catFactory2D1.CreatePoint(APFußkreis_x, APFußkreis_y);
            Point2D catP2D_FußkreisVerrundung1 = catFactory2D1.CreatePoint(SPFußkreisVerrundung_x, SPFußkreisVerrundung_y);
            Point2D catP2D_Fußkreisverrundung2 = catFactory2D1.CreatePoint(-SPFußkreisVerrundung_x, SPFußkreisVerrundung_y);

            Point2D catP2D_MPVerrundung1 = catFactory2D1.CreatePoint(MPVerrundung_x, MPVerrundung_y);
            Point2D catP2D_MPVerrundung2 = catFactory2D1.CreatePoint(-MPVerrundung_x, MPVerrundung_y);

            Point2D catP2D_EvolventeVerrundung1 = catFactory2D1.CreatePoint(SPEvolventeVerrundung_x, SPEvolventeVerrundung_y);
            Point2D catP2D_EvolventeVerrundung2 = catFactory2D1.CreatePoint(-SPEvolventeVerrundung_x, SPEvolventeVerrundung_y);

            Point2D catP2D_MPEvolvente1 = catFactory2D1.CreatePoint(MPEvolvente_x, MPEvolvente_y);
            Point2D catP2D_MPEvolvente2 = catFactory2D1.CreatePoint(-MPEvolvente_x, MPEvolvente_y);

            Point2D catP2D_EvolventenKopfkreis1 = catFactory2D1.CreatePoint(SPEvolventenKopfkreis_x, SPEvolventenKopfkreis_y);
            Point2D catP2D_EvolventenKopfkreis2 = catFactory2D1.CreatePoint(-SPEvolventenKopfkreis_x, SPEvolventenKopfkreis_y);

            //Kreise
            Circle2D catC2DFußkreis = catFactory2D1.CreateCircle(x0, y0, dat.getFußkreisRadiusZahnrad1(), 0, Math.PI * 2);
            catC2DFußkreis.CenterPoint = catP2D_Ursprung;
            catC2DFußkreis.StartPoint = catP2D_FußkreisVerrundung1;
            catC2DFußkreis.EndPoint = catP2D_APFußkreis;

            Circle2D catC2D_Verrundung1 = catFactory2D1.CreateCircle(MPVerrundung_x, MPVerrundung_y, dat.getVerrundungsRadiusZahnrad1(), 0, Math.PI * 2);
            catC2D_Verrundung1.CenterPoint = catP2D_MPVerrundung1;
            catC2D_Verrundung1.StartPoint = catP2D_FußkreisVerrundung1;
            catC2D_Verrundung1.EndPoint = catP2D_EvolventeVerrundung1;

            Circle2D catC2D_Evolventenkreis1 = catFactory2D1.CreateCircle(MPEvolvente_x, MPEvolvente_y, Evolvente_r, 0, Math.PI * 2);
            catC2D_Evolventenkreis1.CenterPoint = catP2D_MPEvolvente1;
            catC2D_Evolventenkreis1.StartPoint = catP2D_EvolventenKopfkreis1;
            catC2D_Evolventenkreis1.EndPoint = catP2D_MPVerrundung1;

            Circle2D catC2D_Kopfkreis = catFactory2D1.CreateCircle(x0, y0, dat.getKopfkreisRadiusZahnrad1(), 0, Math.PI * 2);
            catC2D_Kopfkreis.CenterPoint = catP2D_Ursprung;
            catC2D_Kopfkreis.StartPoint = catP2D_EvolventenKopfkreis2;
            catC2D_Kopfkreis.EndPoint = catP2D_EvolventenKopfkreis1;

            Circle2D catC2D_Evolventenkreis2 = catFactory2D1.CreateCircle(-MPEvolvente_x, MPEvolvente_y, Evolvente_r, 0, Math.PI * 2);
            catC2D_Evolventenkreis2.CenterPoint = catP2D_MPEvolvente2;
            catC2D_Evolventenkreis2.StartPoint = catP2D_EvolventeVerrundung2;
            catC2D_Evolventenkreis2.EndPoint = catP2D_EvolventenKopfkreis2;

            Circle2D catC2D_Verrundung2 = catFactory2D1.CreateCircle(-MPVerrundung_x, MPVerrundung_y, dat.getVerrundungsRadiusZahnrad1(), 0, Math.PI * 2);
            catC2D_Verrundung2.CenterPoint = catP2D_MPVerrundung2;
            catC2D_Verrundung2.StartPoint = catP2D_EvolventeVerrundung2;
            catC2D_Verrundung2.EndPoint = catP2D_Fußkreisverrundung2;

            hsp_catiaProfil.CloseEdition();

            //hsp_catiaPart.Part.Update();



            /*Constraints catConstraints = hsp_catiaProfil.Constraints;

            Point2D catP2D_U = catFactory2D1.CreatePoint(0, 0);
            Point2D catP2D_1 = catFactory2D1.CreatePoint(0, dat.getHilfskreisRadiusZahnrad1());
            Point2D catP2D_2 = catFactory2D1.CreatePoint(0, dat.getKopfkreisRadiusZahnrad1());

            Line2D catL2D_1 = catFactory2D1.CreateLine(0, 0, 0, dat.getHilfskreisRadiusZahnrad1());
            catL2D_1.StartPoint = catP2D_U;
            catL2D_1.EndPoint = catP2D_1;
            catL2D_1.Construction = true;
            Line2D catL2D_2 = catFactory2D1.CreateLine(0, 0, 0, dat.getKopfkreisRadiusZahnrad1());
            catL2D_2.StartPoint = catP2D_U;
            catL2D_2.EndPoint = catP2D_2;
            catL2D_2.Construction = true;

            //Kreis
            Circle2D catC2D_1 = catFactory2D1.CreateClosedCircle(0, 0, dat.getFußkreisRadiusZahnrad1());
            catC2D_1.Construction = true;

            Reference catRef_1 = hsp_catiaPart.Part.CreateReferenceFromObject(catL2D_1);
            Reference catRef_2 = hsp_catiaPart.Part.CreateReferenceFromObject(catL2D_2);
            Constraint catConst_1 = catConstraints.AddBiEltCst(CatConstraintType.catCstTypeAngle, catRef_1, catRef_2);
            catConst_1.Mode = CatConstraintMode.catCstModeDrivingDimension;
            catConst_1.AngleSector = CatConstraintAngleSector.catCstAngleSector0;


            Angle catAngle1 = catConst_1.
            catAngle1.Value = dat.getAlphaZahnrad1();

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
            //catC2D_5.CenterPoint = ;*/
        }

        public void ErzeugeKreismuster(Data dat)
        {
            //Kreismuster
            ShapeFactory SF = (ShapeFactory)hsp_catiaPart.Part.ShapeFactory;
            HybridShapeFactory HSF = (HybridShapeFactory)hsp_catiaPart.Part.HybridShapeFactory;


            //Refrenzen und Skizze
            Factory2D Factory2D1 = hsp_catiaProfil.Factory2D;
            HybridShapePointCoord Ursprung = HSF.AddNewPointCoord(0, 0, 0);
            Reference RefUrsprung = hsp_catiaPart.Part.CreateReferenceFromObject(Ursprung);
            HybridShapeDirection XDir = HSF.AddNewDirectionByCoord(1, 0, 0);
            Reference RefXDir = hsp_catiaPart.Part.CreateReferenceFromObject(XDir);

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
            Reference Ref_Kreismuster = hsp_catiaPart.Part.CreateReferenceFromObject(Kreismuster);
            HybridShapeAssemble Verbindung = HSF.AddNewJoin(Ref_Kreismuster, Ref_Kreismuster);
            Reference Ref_Verbindung = hsp_catiaPart.Part.CreateReferenceFromObject(Verbindung);

            HSF.GSMVisibility(Ref_Verbindung, 0);

            //hsp_catiaPart.Part.Update();

            Bodies bodies = hsp_catiaPart.Part.Bodies;
            Body myBody = bodies.Add();
            myBody.set_Name("Zahnrad");
            myBody.InsertHybridShape(Verbindung);

            //hsp_catiaPart.Part.Update();

            hsp_catiaPart.Part.InWorkObject = myBody;
            Pad myPad = SF.AddNewPadFromRef(Ref_Verbindung, dat.getBreiteZahnrad1());
            hsp_catiaPart.Part.Update();
        }
        
        
        //Schnittpunkt_x
        private double SchnittPunkt_x(double xMP1, double yMP1, double r1, double xMP2, double yMP2, double r2)
        {
            double d = Math.Sqrt(Math.Pow((xMP1 - xMP2), 2) + Math.Pow((yMP1 - yMP2), 2));
            double L = (Math.Pow(r1, 2) - Math.Pow(r2, 2) + Math.Pow(d, 2)) / (d * 2);
            double h;
            double wz = 0.00001;

            if((r1 - L) < wz)
            {
                MessageBox.Show("Fehler!");
            }
            if (Math.Abs(r1 - L) < wz)
            {
                h = 0;
            }
            else
            {
                h = Math.Sqrt(Math.Pow(r1, 2) - Math.Pow(L, 2));
            }

            return L * (xMP2 - xMP1) / d - (h * (yMP2 - yMP1) / d + xMP1);
        }
        //Schnittpunkt_y
        private double Schnittpunkt_y(double xMP1, double xMP2, double r1, double yMP1, double yMP2, double r2)
        {
            double d = Math.Sqrt(Math.Pow((xMP1 - xMP2), 2) + Math.Pow((yMP1 - yMP2), 2));
            double L = (Math.Pow(r1, 2) - Math.Pow(r2, 2) + Math.Pow(d, 2)) / (d * 2);
            double h;
            double wz = 0.00001;

            if ((r1 - L) < -wz)
            {
                MessageBox.Show("Fehler!");
            }
            if (Math.Abs(r1 - L) < wz)
            {
                h = 0;
            }
            else
            {
                h = Math.Sqrt(Math.Pow(r1, 2) - Math.Pow(L, 2));
            }

            return L * (xMP2 - xMP1) / d + (h * (yMP2 - yMP1) / d + xMP1);
        }
    }
}
