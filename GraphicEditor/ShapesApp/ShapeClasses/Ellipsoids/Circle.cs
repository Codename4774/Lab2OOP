using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ShapesApp
{
    public class Circle : Ellipse
    {
        public void SetCoords(TCoord coordCenter, int radius)
        {
            coords[0] = coordCenter;
            this.a = radius;
        }
        public Circle(TCoord coordCenter, int radius)
            : base()
        {
            coords = new TCoord[1];
            SetCoords(coordCenter, radius);
        }
        public int Radius { get { return a; } }
        public Circle() : base()
        {
            coords = new TCoord[1];
        }
    }
}
