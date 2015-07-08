using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z54
{
    class Zaposlenik
    {
        private int _id;
        private string _imePrezime;
        private float[] _mjesecnePlace;
        public int id { get; set; }
        public string imePrezime { get; set; }
        public float[] mjesecnePlace { get; set; }
        public float godisnjaZarada(float[] _mjesecnePlace)
        {
            float zbroj = 0;
            
            for (int i = 0; i < 12; i++)
            {
                zbroj += _mjesecnePlace[i];
            }
            return zbroj;
        }

        public float prosjek(float[] _mjesecnePlace)
        {
            float zbroj = 0;
            
            for (int i = 0; i < 12; i++)
            {
                zbroj += _mjesecnePlace[i];
            }
            return zbroj/12;

        }


    }
}
