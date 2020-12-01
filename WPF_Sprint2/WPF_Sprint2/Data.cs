using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Sprint2
{
    class Data
    {
        double modulZ1;
        int zaehnezahlZ1;
        double breiteZ1;
        double teilkreisdurchmesserZ1;

        double modulZ2;
        int zaehnezahlZ2;
        double breiteZ2;
        double teilkreisdurchmesserZ2;

        //Modul
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
            return teilkreisdurchmesserZ1;
        }
        public void setTeilkreisdurchmesserZahnrad2(double teilkreisdurchmesserZ2)
        {
            this.teilkreisdurchmesserZ2 = teilkreisdurchmesserZ2;
        }
    }
}
