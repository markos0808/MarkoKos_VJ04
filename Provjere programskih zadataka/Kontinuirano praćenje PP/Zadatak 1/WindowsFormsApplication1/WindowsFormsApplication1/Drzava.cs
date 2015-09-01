using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{
    class Drzava
    {
        string nazivDrzave;
        int brojStanovnika;
        float stopaRasta;
        int bs;
        
        
        
        public Drzava(string nazivD, int brojS, float stopaR,Form1 forma) 
        {
            this.nazivDrzave = nazivD;
            this.brojStanovnika = brojS;
            this.stopaRasta = stopaR;
            forma.textBoxLog.Text = "Naziv države: " + nazivDrzave + "" + Environment.NewLine + "Broj stanovnika: " + brojStanovnika + Environment.NewLine + "Stopa rasta: " + stopaRasta + "";
        }


        
        public void Izracunaj(Form1 forma)
        {
            for (int i = forma.trackBarGodina.Minimum+1; i <= forma.trackBarGodina.Maximum; i++)
            {
                    bs = brojStanovnika + (int)(brojStanovnika * stopaRasta);
                    brojStanovnika = bs;
                   

                    if (forma.trackBarGodina.Value == i)
                    {
                        forma.textBoxLog.Text = "Naziv države: " + nazivDrzave + "" + Environment.NewLine + "Broj stanovnika: " + bs + Environment.NewLine + "Stopa rasta: " + stopaRasta + "";
                    }
            }
             
            
          
        }
    }

  
}
