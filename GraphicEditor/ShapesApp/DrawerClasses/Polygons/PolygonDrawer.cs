using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ShapesApp.DrawerClasses.Polygons
{
    public class PolDrawer : Drawer
    {
        private Polygon shape { set; get; }
        public override void draw()
        {
            Gl.glColor3f(shape.Color.R, shape.Color.G, shape.Color.B);
            Gl.glLineWidth(shape.PenWidth);
            Gl.glBegin(Gl.GL_LINE_LOOP);
            for (int i = 0; i < shape.Coords.Length; i++)
                Gl.glVertex2d(shape.Coords[i].x, shape.Coords[i].y);
            Gl.glEnd();
            Gl.glFlush();
        }
        public override bool isEnough(List<TCoord> tempCoords)
        {
            if (tempCoords.Count > 1)
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
            TCoord[] temp = new TCoord[coords.Count - 2];
            Array.Copy(coords.ToArray(), 2, temp, 0, coords.Count - 2);
            shape.SetCoords(coords[0], coords[1], temp);
        }
        public PolDrawer()
        {
            shape = new Polygon();
        }
    }
}
