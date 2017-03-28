using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace ShapesApp.DrawerClasses.Lines
{
    public class SegmentDrawer : Drawer
    {
        private Segment shape { set; get; }

        public override void draw()
        {
            Gl.glColor3f(shape.Color.R, shape.Color.G, shape.Color.B);
            Gl.glLineWidth(shape.PenWidth);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2d(shape.Coords[0].x, shape.Coords[0].y);
            Gl.glVertex2d(shape.Coords[1].x, shape.Coords[1].y);
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

        public override void addParams(List<TCoord> coords)
        {
            shape.SetCoords(coords[0], coords[1]);
        }

        public SegmentDrawer()
        {
            shape = new Segment();
        }

    }
}
