using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaLab1
{
    public class Polygon
    {
        public List<Edge> ListOfEdges;
        public List<Vertex> ListOfVertexes;

        public Polygon()
        {
            ListOfEdges = new List<Edge>();
            ListOfVertexes = new List<Vertex>();
        }

        public Edge ClosestEdge(Point p)
        {
            Edge edge = null;
            double minDist = Double.MaxValue;
            foreach (Edge e in ListOfEdges)
            {
                if (e.Distance(p) < minDist)
                {
                    minDist = e.Distance(p);
                    edge = e;
                }
            }
            if (minDist > 10)
                return null;
            else
                return edge;
        }

        public Vertex ClosestVertex(Point p)
        {
            Vertex v = null;
            double minDist = Double.MaxValue;
            foreach (Vertex ver in ListOfVertexes)
            {
                if (Bresenham.Dist(ver.Location, p) < minDist)
                {
                    minDist = Bresenham.Dist(ver.Location, p);
                    v = ver;
                }
            }
            if (minDist > 10)
                return null;
            return v;
        }
        public void MovedEdges(int xDiff, int yDiff, List<Edge> edgesToMove)
        {
            List<Edge> edges = new List<Edge>();
            foreach (var e in edgesToMove)
            {
                if (e is NormalEdge)
                {
                    edges.Add(new NormalEdge(new Point(e.Start.Location.X + xDiff, e.Start.Location.Y +yDiff), new Point(e.End.Location.X + xDiff, e.End.Location.Y + yDiff)));
                }
                if (e is HorizontalEdge)
                {
                    edges.Add(new HorizontalEdge(new Point(e.Start.Location.X + xDiff, e.Start.Location.Y + yDiff), new Point(e.End.Location.X + xDiff, e.End.Location.Y + yDiff)));
                }
                if (e is VerticalEdge)
                {
                    edges.Add(new VerticalEdge(new Point(e.Start.Location.X + xDiff, e.Start.Location.Y + yDiff), new Point(e.End.Location.X + xDiff, e.End.Location.Y + yDiff)));
                }
                if (e is FixedLenghtEdge)
                {
                    
                }
            }
            ListOfEdges = edges;
        }
    }
}
