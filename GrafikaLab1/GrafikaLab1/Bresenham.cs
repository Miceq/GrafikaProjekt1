using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaLab1
{
    public static class Bresenham
    {
        public static double Dist(Point y, Point x) => Math.Sqrt(Math.Pow((y.X - x.X), 2) + Math.Pow((y.Y - x.Y), 2));
        public static List<Point> GetPoints(Point s, Point e)
        {
            int y0 = s.Y;
            int y1 = e.Y;
            int x0 = s.X;
            int x1 = e.X;
            List<Point> ret = new List<Point>();
            bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            if (steep)
            {
                int t;
                t = x0; // swap x0 and y0
                x0 = y0;
                y0 = t;
                t = x1; // swap x1 and y1
                x1 = y1;
                y1 = t;
            }
            if (x0 > x1)
            {
                int t;
                t = x0; // swap x0 and x1
                x0 = x1;
                x1 = t;
                t = y0; // swap y0 and y1
                y0 = y1;
                y1 = t;
            }
            int dx = x1 - x0;
            int dy = Math.Abs(y1 - y0);
            int error = dx / 2;
            int ystep = (y0 < y1) ? 1 : -1;
            int y = y0;
            for (int x = x0; x <= x1; x++)
            {
                ret.Add(new Point((steep ? y : x), (steep ? x : y)));
                error = error - dy;
                if (error < 0)
                {
                    y += ystep;
                    error += dx;
                }
            }
            return ret;
        }
    }
}
