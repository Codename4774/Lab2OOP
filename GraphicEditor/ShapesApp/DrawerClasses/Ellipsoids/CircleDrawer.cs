using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ShapesApp.DrawerClasses.Ellipsoids
{
    public class CirlceDrawer : Drawer
    {
        private Circle shape { set; get; }
        public override void draw()
        {
            const int pointCount = 360;
            const float step = (float)(2 * Math.PI / pointCount);
            Gl.glColor3f(shape.Color.R, shape.Color.G, shape.Color.B);
            Gl.glLineWidth(shape.PenWidth);
            Gl.glBegin(Gl.GL_LINE_LOOP);
            for (double angle = 0; angle < (float)(2 * Math.PI); angle += step)
            {
                double dx = shape.A * Math.Cos(angle);
                double dy = shape.A * Math.Sin(angle);
                Gl.glVertex2d(dx + shape.Coords[0].x, dy + shape.Coords[0].y);
            }
            Gl.glEnd();
            Gl.glFlush();
        }
        public override bool isEnough(List<TCoord> coords)
        {
            if (coords.Count > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int calcDistance(TCoord coord1, TCoord coord2)
        {
            int deltaX = Math.Abs(coord1.x - coord2.x);
            int deltaY = Math.Abs(coord1.y - coord2.y);

            return ((int)(Math.Sqrt(deltaX * deltaX + deltaY * deltaY)));
        }
        public override void addParams(List<TCoord> coords)
        {
            shape.SetCoords(coords[0], calcDistance(coords[0], coords[1]));
        }
        public CirlceDrawer()
        {
            shape = new Circle();
        }
    }
}
