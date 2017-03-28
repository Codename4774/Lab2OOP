using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ShapesApp
{
    public class Triangle : Polygon
    {
        public const int countOfPointsTriangle = 3;
        public void SetCoords(TCoord coord1, TCoord coord2, TCoord coord3)
        {
            coords[0] = coord1;
            coords[1] = coord2;
            coords[2] = coord3;
        }
        public Triangle(TCoord coord1, TCoord coord2, TCoord coord3)
            : base()
        {
            coords = new TCoord[countOfPointsTriangle];
            SetCoords(coord1, coord2, coord3);
        }
        public Triangle()
        {
            coords = new TCoord[countOfPointsTriangle];
        }
    }
}
