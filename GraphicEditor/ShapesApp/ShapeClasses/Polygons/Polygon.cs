using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ShapesApp
{
    public class Polygon : Shape
    {

        public void SetCoords(TCoord coord1, TCoord coord2, params TCoord[] otherCoords)
        {
            TCoord[] temp = new TCoord[otherCoords.Length + 2];
            temp[0] = coord1;
            temp[1] = coord2;
            for (int i = 2; i < temp.Length; i++)
            {
                temp[i] = otherCoords[i - 2];
            }
            coords = temp;
        }
        public Polygon(TCoord coord1, TCoord coord2, params TCoord[] otherCoords)
            : base()
        {
            coords = new TCoord[otherCoords.Length + 2];
            SetCoords(coord1, coord2, otherCoords);
        }
        public Polygon() : base()
        {
            coords = new TCoord[0];
        }
    }
}
