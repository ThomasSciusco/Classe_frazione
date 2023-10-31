using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_frazione
{
    internal class Frazione
    {
        private int numeratore;
        private int denominatore;

        public int Numeratore
        {
            get { return numeratore; }
            set { numeratore = value; }
        }
        public int Denominatore
        {
            get { return denominatore; }
            set { denominatore = value; }
                
        }
        public Frazione(int numeratore, int denominatore)
        {
            Numeratore= numeratore;
            Denominatore= denominatore;
        }
        public Frazione(Frazione Altrafrazione)
        {
            Numeratore = Altrafrazione.Numeratore;
            Denominatore = Altrafrazione.Denominatore;
        }
        public void Semplifica ()
        {
            int mcd =MCD(Numeratore,Denominatore);
            Numeratore /= mcd;
            Denominatore /= mcd;
        }
    }
}
