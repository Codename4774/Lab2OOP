using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ShapesApp.DrawerClasses.Polygons
{
    public class TriangleDrawer : Drawer
    {
        private Triangle shape { set; get; }
        public override void draw()
        {
            const int countOfPointsTriangle = 3;
            Gl.glColor3f(shape.Color.R, shape.Color.G, shape.Color.B);
            Gl.glLineWidth(shape.PenWidth);
            Gl.glBegin(Gl.GL_LINE_LOOP);
            for (int i = 0; i < countOfPointsTriangle; i++)
                Gl.glVertex2d(shape.Coords[i].x, shape.Coords[i].y);
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
            shape.SetCoords(coords[0], coords[1], coords[2]);
        }
        public TriangleDrawer()
        {
            shape = new Triangle();
        }
    }
}
