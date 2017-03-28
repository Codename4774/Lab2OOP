using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ShapesApp
{
    public class Rect : Polygon
    {
        protected int height;
        private int length;
        public int Height { get { return height; } }
        public int Length { get { return length; } }
        public void SetCoords(TCoord coordBottomLeft, int length, int height)
        {
            coords[0] = coordBottomLeft;
            this.height = height;
            this.length = length; 
        }
        public Rect(TCoord coordBottomLeft, int length, int height)
            : base()
        {
            coords = new TCoord[1];
            SetCoords(coordBottomLeft, length, height);
        }
        public Rect() : base()
        {
            coords = new TCoord[1];
        }
    }
}
