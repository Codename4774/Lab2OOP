using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ShapesApp.DrawerClasses.Polygons
{
    public class RectDrawer : Drawer
    {
        private Rect shape { set; get; }
        public override void draw()
        {

            Gl.glColor3f(shape.Color.R, shape.Color.G, shape.Color.B);
            Gl.glLineWidth(shape.PenWidth);
            Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glVertex2d(shape.Coords[0].x, shape.Coords[0].y);
            Gl.glVertex2d(shape.Coords[0].x, shape.Coords[0].y + shape.Height);
            Gl.glVertex2d(shape.Coords[0].x + shape.Length, shape.Coords[0].y + shape.Height);
            Gl.glVertex2d(shape.Coords[0].x + shape.Length, shape.Coords[0].y);
            Gl.glEnd();
            Gl.glFlush();
        }
        public override bool isEnough(List<TCoord> coords)
        {
            if (coords.Count == 2)
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
            TCoord coordBottomLeft = new TCoord(getMinVal(coords[1].x, coords[0].x), getMinVal(coords[1].y, coords[0].y));
            shape.SetCoords(coordBottomLeft, Math.Abs(coords[1].x - coords[0].x), Math.Abs(coords[1].y - coords[0].y));
        }
        public RectDrawer()
        {
            shape = new Rect();
        }
    }
}
