using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;


namespace ShapesApp.DrawerClasses.Ellipsoids
{
    public class EllipseDrawer : Drawer
    {
        private Ellipse shape { set; get; }
        public override void draw()
        {
            const int pointCount = 360;
            const float step = (float)(2 * Math.PI / pointCount);
            Gl.glLineWidth(shape.PenWidth);
            Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glColor3f(shape.Color.R, shape.Color.G, shape.Color.B);
            for (double angle = 0; angle < (float)(2 * Math.PI); angle += step)
            {
                double dx = shape.A * Math.Cos(angle);
                double dy = shape.B * Math.Sin(angle);
                Gl.glVertex2d(dx + shape.Coords[0].x, dy + shape.Coords[0].y);
            }
            Gl.glEnd();
            Gl.glFlush();
        }

        public override bool isEnough(List<TCoord> coords)
        {
            if (coords.Count > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void addParams(List<TCoord> coords)
        {
            shape.SetCoords(coords[0], Math.Abs(coords[1].x - coords[0].x), Math.Abs(coords[2].y - coords[0].y));
        }
        public EllipseDrawer()
        {
            shape = new Ellipse();
        }
    }
}
