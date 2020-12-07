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


        //Hilfsparameter Zahnrad1
        double teilkreisradiusZ1;
        double hilfskreisradiusZ1;
        double fußkreisradiusZ1;
        double kopfkreisradiusZ1;
        double verrundungsradiusZ1;
        double alphaZ1;
        double betaZ1;
        double beta_rZ1;
        double gammaZ1;
        double gamma_rZ1;
        double totalangleZ1;
        double totalangle_rZ1;



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

        #region HilfsparameterZ1
        //Hilfsparameter Evolventenverzahnung
        //Teilkreisradius Zahnrad1
        public double getTeilkreisRadiusZahnrad1()
        {
            return teilkreisradiusZ1;
        }
        public void setTeilkreisRadiusZahnrad1(double teilkreisradiusZ1)
        {
            this.teilkreisradiusZ1 = teilkreisradiusZ1;
        }

        //Hilfskreisradius Zahnrad1
        public double getHilfskreisRadiusZahnrad1()
        {
            return hilfskreisradiusZ1;
        }
        public void setHilfskreisradius(double hilfskreisradiusZ1)
        {
            this.hilfskreisradiusZ1 = hilfskreisradiusZ1;
        }

        //Fußkreisradius Zahnrad1
        public double getFußkreisRadiusZahnrad1()
        {
            return fußkreisradiusZ1;
        }
        public void setFußkreisRadiusZahnrad1(double fußkreisradiusZ1)
        {
            this.fußkreisradiusZ1 = fußkreisradiusZ1; 
        }

        //Kopfkreisradius Zahnrad1
        public double getKopfkreisRadiusZahnrad1()
        {
            return kopfkreisradiusZ1;
        }
        public void setKopfkreisRadiusZahnrad1(double kopfkreisradiusZ1)
        {
            this.kopfkreisradiusZ1 = kopfkreisradiusZ1;
        }

        //Verrundungsradius Zahnrad1
        public double getVerrundungsRadiusZahnrad1()
        {
            return verrundungsradiusZ1;
        }
        public void setVerrundungsRadiusZahnrad1(double verrundungsradiusZ1)
        {
            this.verrundungsradiusZ1 = verrundungsradiusZ1;
        }

        //Alpha Zahnrad1
        public double getAlphaZahnrad1()
        {
            return alphaZ1;
        }
        public void setAlphaZahnrad1(double alphaZ1)
        {
            this.alphaZ1 = alphaZ1;
        }

        //Beta Zahnrad1
        public double getBetaZahnrad1()
        {
            return betaZ1;
        }
        public void setBetaZahnrad1(double betaZ1)
        {
            this.betaZ1 = betaZ1;
        }

        //BetaRad Zahnrad1
        public double getBetaRadZahnrad1()
        {
            return beta_rZ1;
        }
        public void setBetaRadZahnrad1(double beta_rZ1)
        {
            this.beta_rZ1 = beta_rZ1;
        }

        //Gamma Zahnrad1
        public double getGammaZahnrad1()
        {
            return gammaZ1;
        }
        public void setGammaZahnrad1(double gammaZ1)
        {
            this.gammaZ1 = gammaZ1;
        }

        //GammaRad Zahnrad1
        public double getGammaRadZahnrad1()
        {
            return gamma_rZ1;
        }
        public void setGammaRadZahnrad1(double gamma_rZ1)
        {
            this.gamma_rZ1 = gamma_rZ1;
        }

        //TotalAngle Zahnrad1
        public double getTotalAngleZahnrad1()
        {
            return totalangleZ1;
        }
        public void setTotalAngleZahnrad1(double totalangleZ1)
        {
            this.totalangleZ1 = totalangleZ1;
        }

        //TotalAngleRad Zahnrad1
        public double getTotalAngleRadZahnrad1()
        {
            return totalangle_rZ1;
        }
        public void setTotalAngleRadZahnrad1(double totalangle_rZ1)
        {
            this.totalangle_rZ1 = totalangle_rZ1;
        }
        #endregion
    }
}
