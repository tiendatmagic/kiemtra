using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kiemtraketthucmon
{
    class Dongvat
    {
        private string Keu;

        public string DongvatKeu
        {
            get { return Keu; }
            set { Keu = value; }
        }

        public Dongvat(string stKeu)
        {
            this.Keu = stKeu;
        }

        public Dongvat()
        {
        }

        public string MauLong
        {
            get { return MauLong; }
            set { MauLong = value; }
        }

        public virtual void Talk()
        {
            if (DongvatKeu.Equals("Gau gau"))
                MessageBox.Show("Cho keu " + this.DongvatKeu);
            else if (DongvatKeu.Equals("Meo meo"))
                MessageBox.Show("Meo keu " + this.DongvatKeu);
        }
    }
}
