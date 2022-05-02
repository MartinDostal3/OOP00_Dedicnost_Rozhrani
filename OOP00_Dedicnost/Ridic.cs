using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP00_Dedicnost
{
    class Ridic : Zamestnanec
    {
        private string skupina;
        private int ujetoCelkem = 0;

        public Ridic(string jmeno, string prijmeni, double hodinovaMzda) : base(jmeno, prijmeni, hodinovaMzda)
        {
        }
        public Ridic(string jmeno, string prijmeni, double hodinovaMzda, string skupina) : base(jmeno, prijmeni, hodinovaMzda)
        {
            this.skupina = skupina;
        }
        public string GetSkupina()
        {
            return skupina;
        }
        public void SetSkupina(string skupina)
        {
            this.skupina = skupina;
        }

        public int GetOdpracHodiny() // u zamestnance jsme nenaprogramovali
        {
            return odpracHodiny;
        }
        public int GetUjetoCelkem()
        {
            return ujetoCelkem;
        }
        public override void OdpracujHodiny(int hodiny)
        {
            ujetoCelkem += (hodiny * 80);
            base.OdpracujHodiny(hodiny);
        }

        public override double VypoctiMzdu()
        {
            if(ujetoCelkem > 5000)
            {
                return base.VypoctiMzdu() + 3000;
            }

            else
            {
                return base.VypoctiMzdu();
            }
            


        }
        public override string ToString()
        {
            return base.ToString() + "\nskupina ŘO: " + skupina
                                   + "\nujeto celkem: " + ujetoCelkem + " km";
        }







    }
}
