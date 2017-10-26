using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaLab1
{
    public class Vertex
    {
        public Point Location;

        public Vertex(int x, int y)
        {
            Location = new Point(x,y);
        }
    }
}
