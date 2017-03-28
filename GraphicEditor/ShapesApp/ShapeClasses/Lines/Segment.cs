using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ShapesApp
{
    public class Segment : Shape
    {
        public Segment(TCoord coord1, TCoord coord2) : base()
        {
            coords = new TCoord[2];
            SetCoords(coord1, coord2);
        }
        public void SetCoords(TCoord coord1, TCoord coord2)
        {
            coords[0] = coord1;
            coords[1] = coord2;
        }
        public Segment() : base()
        {
            coords = new TCoord[2];
        }
    }
}
