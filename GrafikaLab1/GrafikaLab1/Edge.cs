using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaLab1
{
    public abstract class Edge
    {
        public List<Point> ListOfPoints;
        public Vertex Start;
        public Vertex End;
        public Color c;
        public double Distance(Point point) => ListOfPoints.Min(x => Bresenham.Dist(point, x));

        protected Edge(Point x, Point y)
        {
            ListOfPoints = Bresenham.GetPoints(x, y);
            Start = new Vertex(x.X, x.Y);
            End = new Vertex(y.X, y.Y);
        }
    }

    public class NormalEdge : Edge
    {
        public NormalEdge(Point x, Point y) : base(x,y)
        {
            c=Color.Black;
        }
    }

    public class HorizontalEdge : Edge
    {
        public HorizontalEdge(Point x, Point y) : base(x, new Point(y.X, x.Y))
        {
            c = Color.Red;
        }
    }

    public class VerticalEdge : Edge
    {
        public VerticalEdge(Point x, Point y) : base(x, new Point(x.X, y.Y))
        {
            c = Color.Chartreuse;
        }
    }

    public class FixedLenghtEdge : Edge
    {
        public FixedLenghtEdge(Point x, Point y) : base(x, y)
        {
            
        }
    }
}
