using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct TCoord
{
    public int x, y;
    public TCoord(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public struct TColor
{
    public int R, G, B;
    public TColor(int R, int G, int B)
    {
        this.R = R;
        this.G = G;
        this.B = B;
    }
}

namespace ShapesApp
{
    public abstract class Shape
    {
        //public abstract void Draw();
        private int penWidth;
        public int PenWidth
        {
            set
            {
                penWidth = value;
            }
            get
            {
                return penWidth;
            }
        }
        public TColor Color
        {
            set
            {
                color = value;
            }
            get 
            {
                return color;
            }
        }
        private TColor color;
        protected TCoord[] coords;
        public TCoord[] Coords { get { return coords; } }
        public Shape()
        {
            penWidth = 3;
            color = new TColor(0, 0, 0);
        }
}
}
