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

        public string tiengkeu
        {
            get
            {
                return Keu;
            }
            set
            {
                Keu = value;
            }
        }        

        public Dongvat()
        {
        }
                
        private string MauLong;

        public string maulong
        {
            get
            {
                return MauLong;
            }
            set
            {
                MauLong = value;
            }
        }



        public virtual void Keuu()
        {
            if (tiengkeu.Equals("Gâu gâu") && (maulong.Equals("Đen")))
                MessageBox.Show(this.tiengkeu+" Tôi là chó lông màu:"+ this.maulong);
            else if (tiengkeu.Equals("Meo meo") && (maulong.Equals("Vàng")))
                MessageBox.Show(this.tiengkeu+" Tôi là mèo lông màu:"+this.maulong);
        }
    }
}
