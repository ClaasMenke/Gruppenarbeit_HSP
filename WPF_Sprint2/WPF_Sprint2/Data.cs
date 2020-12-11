using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Sprint2
{
    class Data
    {
        //Eingangsparameter Zahnrad1
        double modulZ1;
        int zaehnezahlZ1;
        double breiteZ1;
        double teilkreisdurchmesserZ1;

        //Ausgangsparameter Zahnrad1
        double teilungZ1;
        double kopfspielZ1;
        double kopfkreisdurchmesser_aZ1;
        double fußkreisdurchmesser_aZ1;
        double kopfkreisdurchmesser_iZ1;
        double fußkreisdurchmesser_iZ1;
        double grundkreisdurchmesserZ1;
        double zahnkopfhoeheZ1;
        double zahnfußhoeheZ1;
        double zahnhoeheZ1;
        double volumenZ1;


        //Eingangsparameter Zahnrad2
        double modulZ2;
        int zaehnezahlZ2;
        double breiteZ2;
        double teilkreisdurchmesserZ2;

        //Ausgangsparameter Zahnrad2
        double teilungZ2;
        double kopfspielZ2;
        double kopfkreisdurchmesser_aZ2;
        double fußkreisdurchmesser_aZ2;
        double grundkreisdurchmesserZ2;
        double zahnkopfhoeheZ2;
        double zahnfußhoeheZ2;
        double zahnhoeheZ2;
        double volumenZ2;

        //Achsabstand
        double achsabstand_a;
        double achsabstand_i;

        #region Zahnrad1
        //Eingangsparameter Zahnrad1
        //Modul Zahnrad1
        public double getModulZahnrad1()
        {
            return modulZ1;
        }
        public void setModulZahnrad1(double modulZ1)
        {
            this.modulZ1 = modulZ1;
        }

        //Zähnezahl Zahnrad1
        public int getZaehnezahlZahnrad1()
        {
            return zaehnezahlZ1;
        }
        public void setZaehnezahlZahnrad1(int zaehnezahlZ1)
        {
            this.zaehnezahlZ1 = zaehnezahlZ1;
        }

        //Breite Zahnrad1
        public double getBreiteZahnrad1()
        {
            return breiteZ1;
        }
        public void setBreiteZahnrad1(double breiteZ1)
        {
            this.breiteZ1 = breiteZ1;
        }

        //Teilkreisdurchmesser Zahnrad1
        public double getTeilkreisdurchmesserZahnrad1()
        {
            return teilkreisdurchmesserZ1;
        }
        public void setTeilkreisdurchmesserZahnrad1(double teilkreisdurchmesserZ1)
        {
            this.teilkreisdurchmesserZ1 = teilkreisdurchmesserZ1;
        }

        //Ausgangsparameter Zahnrad1
        //Teilung 
        public double getTeilungZahnrad1()
        {
            return teilungZ1;
        }
        public void setTeilungZahnrad1(double teilungZ1)
        {
            this.teilungZ1 = teilungZ1;
        }

        //Kopfspiel Zahnrad1
        public double getKopfspielZahnrad1()
        {
            return kopfspielZ1;
        }
        public void setKopfspielZahnrad1(double kopfspielZ1)
        {
            this.kopfspielZ1 = kopfspielZ1;
        }

        //Kopfkreisdurchmesser_a Zahnrad1
        public double getKopfkreisdurchmesser_aZahnrad1()
        {
            return kopfkreisdurchmesser_aZ1;
        }
        public void setKopfkreisdurchmesser_aZahnrad1(double kopfkreisdurchmesser_aZ1)
        {
            this.kopfkreisdurchmesser_aZ1 = kopfkreisdurchmesser_aZ1;
        }

        //Fußkreisdurchmesser_a Zahnrad1
        public double getFußkreisdurchmesser_aZahnrad1()
        {
            return fußkreisdurchmesser_aZ1;
        }
        public void setFußkreisdurchmesser_aZahnrad1(double fußkreisdurchmesser_aZ1)
        {
            this.fußkreisdurchmesser_aZ1 = fußkreisdurchmesser_aZ1;
        }

        //Kopfkreisdurchmesser_i Zahnrad1
        public double getKopfkreisdurchmesser_iZahnrad1()
        {
            return kopfkreisdurchmesser_iZ1;
        }
        public void setKopfkreisdurchmesser_iZahnrad1(double kopfkreisdurchmesser_iZ1)
        {
            this.kopfkreisdurchmesser_iZ1 = kopfkreisdurchmesser_iZ1;
        }

        //Fußkreisdurchmesser_i Zahnrad1
        public double getFußkreisdurchmesser_iZahnrad1()
        {
            return fußkreisdurchmesser_iZ1;
        }
        public void setFußkreisdurchmesser_iZahnrad1(double fußkreisdurchmesser_iZ1)
        {
            this.fußkreisdurchmesser_iZ1 = fußkreisdurchmesser_iZ1;
        }

        //Grundkreisdurchmesser Zahnrad1
        public double getGrundkreisdurchmesserZahnrad1()
        {
            return grundkreisdurchmesserZ1;
        }
        public void setGrundkreisdurchmesserZahnrad1(double grundkreisdurchmesserZ1)
        {
            this.grundkreisdurchmesserZ1 = grundkreisdurchmesserZ1;
        }

        //Zahnkopfhöhe Zahnrad1
        public double getZahnkopfhoeheZahnrad1()
        {
            return zahnkopfhoeheZ1;
        }
        public void setZahnkopfhoeheZahnrad1(double zahnkopfhoeheZ1)
        {
            this.zahnkopfhoeheZ1 = zahnkopfhoeheZ1;
        }

        //Zahnfußhoehe Zahnrad1
        public double getZahnfußhoeheZahnrad1()
        {
            return zahnfußhoeheZ1;
        }
        public void setZahnfußhoeheZahnrad1(double zahnfußhoeheZ1)
        {
            this.zahnfußhoeheZ1 = zahnfußhoeheZ1;
        }

        //Zahnhoehe Zahnrad1
        public double getZahnhoeheZahnrad1()
        {
            return zahnhoeheZ1;
        }
        public void setZahnhoeheZahnrad1(double zahnhoeheZ1)
        {
            this.zahnhoeheZ1 = zahnhoeheZ1;
        }

        //Volumen Zahnrad1
        public double getVolumenZahnrad1()
        {
            return volumenZ1;
        }
        public void setVolumenZahnrad1(double volumenZ1)
        {
            this.volumenZ1 = volumenZ1;
        }
        #endregion

        #region Zahnrad2
        //Eingangsparameter Zahnrad2
        //Modul Zahnrad2
        public double getModulZahnrad2()
        {
            return modulZ2;
        }
        public void setModulZahnrad2(double modulZ2)
        {
            this.modulZ2 = modulZ2;
        }
        
        //Zaehnezahl Zahnrad2
        public int getZaehnezahlZahnrad2()
        {
            return zaehnezahlZ2;
        }
        public void setZaehnezahlZahnrad2(int zaehnezahlZ2)
        {
            this.zaehnezahlZ2 = zaehnezahlZ2;
        }

        //Breite Zahnrad2
        public double getBreiteZahnrad2()
        {
            return breiteZ2;
        }
        public void setBreiteZahnrad2(double breiteZ2)
        {
            this.breiteZ2 = breiteZ2;
        }

        //Teilkreisdurchmesser Zahnrad2
        public double getTeilkreisdurchmesserZahnrad2()
        {
            return teilkreisdurchmesserZ2;
        }
        public void setTeilkreisdurchmesserZahnrad2(double teilkreisdurchmesserZ2)
        {
            this.teilkreisdurchmesserZ2 = teilkreisdurchmesserZ2;
        }

        //Ausgangsparameter Zahnrad2
        //Teilung Zahnrad2
        public double getTeilungZahnrad2()
        {
            return teilungZ2;
        }
        public void setTeilungZahnrad2(double teilungZ2)
        {
            this.teilungZ2 = teilungZ2;
        }

        //Kopfspiel Zahnrad2
        public double getKopfspielZahnrad2()
        {
            return kopfspielZ2;
        }
        public void setKopfspielZahnrad2(double kopfspielZ2)
        {
            this.kopfspielZ2 = kopfspielZ2;
        }

        //Kopfkreisdurchmesser_a Zahnrad2
        public double getKopfkreisdurchmesser_aZahnrad2()
        {
            return kopfkreisdurchmesser_aZ2;
        }
        public void setKopfkreisdurchmesser_aZahnrad2(double kopfkreisdurchmesser_aZ2)
        {
            this.kopfkreisdurchmesser_aZ2 = kopfkreisdurchmesser_aZ2;
        }

        //Fußkreisdurchmesser_a Zahnrad2
        public double getFußkreisdurchmesser_aZahnrad2()
        {
            return fußkreisdurchmesser_aZ2;
        }
        public void setFußkreisdurchmesser_aZahnrad2(double fußkreisdurchmesser_aZ2)
        {
            this.fußkreisdurchmesser_aZ2 = fußkreisdurchmesser_aZ2;
        }

        //Grundkreisdurchmesser Zahnrad2
        public double getGrundkreisdurchmesserZahnrad2()
        {
            return grundkreisdurchmesserZ2;
        }
        public void setGrundkreisdurchmesserZahnrad2(double grundkreisdurchmesserZ2)
        {
            this.grundkreisdurchmesserZ2 = grundkreisdurchmesserZ2;
        }

        //Zahnkopfhöhe Zahnrad2
        public double getZahnkopfhoeheZahnrad2()
        {
            return zahnkopfhoeheZ2;
        }
        public void setZahnkopfhoeheZahnrad2(double zahnkopfhoeheZ2)
        {
            this.zahnkopfhoeheZ2 = zahnkopfhoeheZ2;
        }

        //Zahnfußhoehe Zahnrad2
        public double getZahnfußhoeheZahnrad2()
        {
            return zahnfußhoeheZ2;
        }
        public void setZahnfußhoeheZahnrad2(double zahnfußhoeheZ2)
        {
            this.zahnfußhoeheZ2 = zahnfußhoeheZ2;
        }

        //Zahnhoehe Zahnrad2
        public double getZahnhoeheZahnrad2()
        {
            return zahnhoeheZ2;
        }
        public void setZahnhoeheZahnrad2(double zahnhoeheZ2)
        {
            this.zahnhoeheZ2 = zahnhoeheZ2;
        }

        //Volumen Zahnrad2
        public double getVolumenZahnrad2()
        {
            return volumenZ2;
        }
        public void setVolumenZahnrad2(double volumenZ2)
        {
            this.volumenZ2 = volumenZ2;
        }
        #endregion

        //Achsabstand außen
        public double getAchsabstand_a()
        {
            return achsabstand_a;
        }
        public void setAchsabstand_a(double achsabstand_a)
        {
            this.achsabstand_a = achsabstand_a;
        }

        //Achsabstand innen
        public double getAchsabstand_i()
        {
            return achsabstand_i;
        }
        public void setAchsabstand_i(double achsabstand_i)
        {
            this.achsabstand_i = achsabstand_i;
        }
    }
}
