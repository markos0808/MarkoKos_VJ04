using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z70
{
    class Vrijeme
    {
        int sat, minuta;
        string a, b;

        public Vrijeme(int n, int m)
        {
            this.sat = n;
            this.minuta = m;
        }

        public string racVrijeme()
        {
            if (minuta > 0 && minuta <= 15) b = " i četvrt sata ";
            if (minuta > 15 && minuta <= 30) b = " i pol sata ";
            if (minuta > 30 && minuta <= 45) b = " i tri četvrti sata ";
            if (minuta > 45 && minuta <= 60) b = " , a uskoro će biti sat vremena više ";

            if(sat==12 || sat==24) a= " dvanaest ";
            if(sat==11 || sat==23) a= " jedanaest ";
            if(sat==10 || sat==22) a= " deset ";
            if(sat==9 || sat==21) a= " devet ";
            if(sat==8 || sat==20) a= " osam ";
            if(sat==7 || sat==19) a= " sedam ";
            if(sat==6 || sat==18) a= " šest ";
            if(sat==5 || sat==17) a= " pet ";
            if(sat==4 || sat==16) a= " četiri ";
            if(sat==3 || sat==15) a= " tri ";
            if(sat==2 || sat==14) a= " dva ";
            if(sat==1 || sat==13) a= " jedan ";

            return (a + b).ToString();
        }
    }
}
