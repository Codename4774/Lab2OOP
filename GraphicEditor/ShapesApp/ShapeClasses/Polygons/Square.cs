using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ShapesApp
{
    public class Square : Rect
    {
        public void SetCoords(TCoord coordBottomLeft, int side)
        {
            coords[0] = coordBottomLeft;
            this.height = side;
        }
        public Square(TCoord coordBottomLeft, int side)
            : base()
        {
            coords = new TCoord[1];
            SetCoords(coordBottomLeft, side);
        }
        public int Side { get { return height; } }
        public Square()
        {
            coords = new TCoord[1];
        }
    }
}
