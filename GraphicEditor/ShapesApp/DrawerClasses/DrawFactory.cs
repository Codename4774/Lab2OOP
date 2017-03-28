using ShapesApp.DrawerClasses.Ellipsoids;
using ShapesApp.DrawerClasses.Lines;
using ShapesApp.DrawerClasses.Polygons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ShapesApp.DrawerClasses
{
    public class DrawFactory
    {
        public Drawer getDrawerRect()
        {
            RectDrawer res = new RectDrawer();
            return res;
        }
        public Drawer getDrawerPol()
        {
            PolDrawer res = new PolDrawer();
            return res;
        }
        public Drawer getDrawerSegment()
        {
            SegmentDrawer res = new SegmentDrawer();
            return res;
        }

        public Drawer getDrawerJoggedLine()
        {
            JoggedLineDrawer res = new JoggedLineDrawer();
            return res;
        }
        public Drawer getDrawerSquare()
        {
            SquareDrawer res = new SquareDrawer();
            return res;
        }

        public Drawer getDrawerTriangle()
        {
            TriangleDrawer res = new TriangleDrawer();
            return res;
        }
        public Drawer getDrawerCirlce()
        {
            CirlceDrawer res = new CirlceDrawer();
            return res;
        }

        public Drawer getDrawerEllipse()
        {
            EllipseDrawer res = new EllipseDrawer();
            return res;
        }
    }
}
