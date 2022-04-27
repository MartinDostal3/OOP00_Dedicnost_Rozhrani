using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP00_Dedicnost
{
    class Vedouci : Zamestnanec
    {
        private double priplatekZaVedeni = 0 ;
        public Vedouci(string jmeno, string prijmeni, double hodinovaMzda, double priplatekZaVedeni) : base(jmeno,prijmeni,hodinovaMzda)
        {
            this.priplatekZaVedeni = priplatekZaVedeni;
           
        }
        
    }
}
