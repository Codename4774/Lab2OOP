using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;


namespace ShapesApp
{
    public class Drawer
    {
        public virtual void addParams(List<TCoord> coords)
        {
        }
        public virtual void draw()
        { }
        public virtual bool isEnough(List<TCoord> coords)
        {
            return false;
        }
        public int getMinVal(int first, int second)
        {
            if (first < second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}

