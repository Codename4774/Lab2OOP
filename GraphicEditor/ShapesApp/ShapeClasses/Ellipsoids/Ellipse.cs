using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ShapesApp
{
    public class Ellipse : Shape
    {

        public void SetCoords(TCoord coordCenter, int a, int b)
        {
            coords[0] = coordCenter;
            this.a = a;
            this.b = b;
        }
        public Ellipse(TCoord coordCenter, int a, int b) : base()
        {
            coords = new TCoord[1];
            SetCoords(coordCenter, a, b);
        }
        public Ellipse() : base()
        {
            coords = new TCoord[1];
        }
        protected int a;
        private int b;
        public int A { get { return a; } }
        public int B { get { return b; } }
    }

}
