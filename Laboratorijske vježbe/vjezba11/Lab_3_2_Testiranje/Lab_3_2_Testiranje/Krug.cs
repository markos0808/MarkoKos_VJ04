using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2_Testiranje
{
    public class Krug
    {
        private float radius;
        public Krug(float Radius) {
            this.radius = Radius;

        }
        public float Povrsina (){
            return radius * radius * (float) Math.PI;
        }
        public float Opseg()
        {
            return 2 * radius * (float)Math.PI;
        }

    }
}
