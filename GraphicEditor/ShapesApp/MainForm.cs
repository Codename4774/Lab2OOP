using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform.Windows;
using ShapesApp;
using ShapesApp.DrawerClasses;

namespace ShapesApp
{

    public partial class ShapesForm : Form
    {
        private Drawer drawer;
        private DrawFactory factory = new DrawFactory();
        private List<TCoord> TempCoords {set; get;}

        public ShapesForm()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT );
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluOrtho2D(0.0, (float)AnT.Width, 0.0, (float)AnT.Height);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glDrawBuffer(Gl.GL_FRONT);
            TempCoords = new List<TCoord>();
        }

        private void ButtonSegment_Click(object sender, EventArgs e)
        {
            TempCoords.Clear();
            drawer = factory.getDrawerSegment();
        }

        private void ButtonRect_Click(object sender, EventArgs e)
        {
            TempCoords.Clear();
            drawer = factory.getDrawerRect();
        }

        private void AnT_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TempCoords.Add(new TCoord(e.X, AnT.Height - e.Y));
            }
            else
            {
                if (drawer.isEnough(TempCoords))
                {
                    drawer.addParams(TempCoords);
                    drawer.draw();
                    TempCoords.Clear();
                    Gl.glDrawBuffer(Gl.GL_FRONT);
                }
            }

        }

        private void ButtonPolygon_Click(object sender, EventArgs e)
        {
            TempCoords.Clear();
            drawer = factory.getDrawerPol();
        }

        private void ButtonJoggedLine_Click(object sender, EventArgs e)
        {
            TempCoords.Clear();
            drawer = factory.getDrawerJoggedLine();
        }

        private void ButtonSquare_Click(object sender, EventArgs e)
        {
            TempCoords.Clear();
            drawer = factory.getDrawerSquare();
        }

        private void ButtonTriangle_Click(object sender, EventArgs e)
        {
            TempCoords.Clear();
            drawer = factory.getDrawerTriangle();
        }

        private void ButtonClircle_Click(object sender, EventArgs e)
        {
            TempCoords.Clear();
            drawer = factory.getDrawerCirlce();
        }

        private void ButtonEllipse_Click(object sender, EventArgs e)
        {
            TempCoords.Clear();
            drawer = factory.getDrawerEllipse();
        }
    }
}
