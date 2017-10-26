using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafikaLab1
{
    public partial class Form1 : Form
    {
        private Polygon MyPolygon;
        private bool IsPolygonCreated = false;
        private Point MouseLocation;
        private Point NewMouseLocation;
        private Bitmap DrawArea;
        private bool MouseDown = false;
        public Form1()
        {
            InitializeComponent();
            DrawArea = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            this.DoubleBuffered = true;
        }

        public void DrawLine(Edge e, Color c)
        {
            foreach (Point p in e.ListOfPoints)
            {
                DrawArea.SetPixel(p.X, p.Y, c);
            }
        }

        public void DrawAll(Color c)
        {
            DrawArea.Dispose();
            DrawArea = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            if(MyPolygon == null)
                return;
            foreach (Vertex v in MyPolygon.ListOfVertexes)
            {
                for (int j = 0; j < 5; j++)
                    for (int k = 0; k < 5; k++)
                        try
                        {
                            DrawArea.SetPixel(v.Location.X - 2 + j, v.Location.Y - 2 + k, c);
                        }
                        catch (ArgumentOutOfRangeException) { }
            }
            foreach (Edge e in MyPolygon.ListOfEdges)
            {
                foreach (Point p in e.ListOfPoints)
                {
                    try
                    {
                        DrawArea.SetPixel(p.X, p.Y, c);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                    }
                }
            }
            pictureBox1.Image = DrawArea;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            MouseLocation = e.Location;
            if (DrawPolygonButton.Checked && !IsPolygonCreated)
            {
                if (MyPolygon == null)
                {
                    MyPolygon = new Polygon();
                }
                if (MyPolygon.ListOfVertexes.Count > 2)
                {
                    if (Math.Abs(MouseLocation.X - MyPolygon.ListOfVertexes[0].Location.X) < 5 &&
                        Math.Abs(MouseLocation.Y - MyPolygon.ListOfVertexes[0].Location.Y) < 5)
                    {
                        MyPolygon.ListOfEdges.Add(new NormalEdge(MyPolygon.ListOfVertexes.Last().Location, MyPolygon.ListOfVertexes.First().Location));
                        DrawAll(Color.Black);
                        IsPolygonCreated = true;
                    }
                    else
                    {
                        MyPolygon.ListOfEdges.Add(new NormalEdge(MyPolygon.ListOfVertexes.Last().Location, MouseLocation));
                        MyPolygon.ListOfVertexes.Add(new Vertex(MouseLocation.X, MouseLocation.Y));
                        DrawAll(Color.Black);
                    }
                }
                else if (MyPolygon.ListOfVertexes.Count == 1 || MyPolygon.ListOfVertexes.Count == 2)
                {
                    MyPolygon.ListOfEdges.Add(new NormalEdge(MyPolygon.ListOfVertexes.Last().Location, MouseLocation));
                    MyPolygon.ListOfVertexes.Add(new Vertex(MouseLocation.X, MouseLocation.Y));
                    DrawAll(Color.Black);
                }
                else
                {
                    MyPolygon.ListOfVertexes.Add(new Vertex(MouseLocation.X, MouseLocation.Y));
                    DrawAll(Color.Black);
                }                
            }
            if (MovePolygonButton.Checked && IsPolygonCreated)
            {
                if (MyPolygon.ClosestEdge(MouseLocation) == null)
                    return;
                else
                {
                    MouseDown = true;
                }
            }
            if (DeleteVertexButton.Checked && IsPolygonCreated)
            {
                Vertex v = MyPolygon.ClosestVertex(MouseLocation);
                if (v == null)
                    return;
                if (MyPolygon.ListOfVertexes.Count <= 3)
                    return;
                int index = MyPolygon.ListOfVertexes.FindIndex(ver => ver.Location == v.Location);
                MyPolygon.ListOfEdges.RemoveAt(index);
                MyPolygon.ListOfEdges.RemoveAt(index - 1 < 0 ? MyPolygon.ListOfEdges.Count-1 : index - 1);
                MyPolygon.ListOfVertexes.RemoveAt(index);
                Edge edge = new NormalEdge(MyPolygon.ListOfVertexes[index - 1 < 0 ? MyPolygon.ListOfVertexes.Count - 1 : index - 1].Location, 
                    MyPolygon.ListOfVertexes[index == MyPolygon.ListOfVertexes.Count ? 0 : index].Location);
                MyPolygon.ListOfEdges.Insert(index - 1 < 0 ? MyPolygon.ListOfEdges.Count : index - 1, edge);
                DrawAll(Color.Black);
            }
            if (AddVertexButton.Checked && IsPolygonCreated)
            {
                Edge edge = MyPolygon.ClosestEdge(MouseLocation);
                if (edge == null)
                    return;
                int index = MyPolygon.ListOfEdges.FindIndex(ed => ed.Equals(edge));
                Vertex v = new Vertex((edge.Start.Location.X + edge.End.Location.X) /2, (edge.Start.Location.Y + edge.End.Location.Y) / 2);
                MyPolygon.ListOfVertexes.Insert(index + 1, v);
                Edge edge1 = new NormalEdge(MyPolygon.ListOfVertexes[index].Location, MyPolygon.ListOfVertexes[index+1].Location);
                MyPolygon.ListOfEdges.RemoveAt(index);
                MyPolygon.ListOfEdges.Insert(index, edge1);
                edge1 = new NormalEdge(MyPolygon.ListOfVertexes[index + 1].Location, MyPolygon.ListOfVertexes[index + 2 == MyPolygon.ListOfVertexes.Count ? 0 : index +2].Location);
                MyPolygon.ListOfEdges.Insert(index+1, edge1);
                DrawAll(Color.Black);
            }
            if (MoveVertexButton.Checked && IsPolygonCreated)
            {
                Vertex v = MyPolygon.ClosestVertex(MouseLocation);
                if (v == null)
                    return;
                MouseDown = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (DrawPolygonButton.Checked && !IsPolygonCreated)
            {
                if (MyPolygon == null)
                    return;
                if (MyPolygon.ListOfVertexes.Count != 0)
                {
                    NewMouseLocation = e.Location;
                    DrawArea.Dispose();
                    DrawArea = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    DrawAll(Color.Black);
                    DrawLine(new NormalEdge(MyPolygon.ListOfVertexes.Last().Location, NewMouseLocation), Color.Black);
                }
            }
            if (MovePolygonButton.Checked && IsPolygonCreated)
            {
                if (!MouseDown)
                    return;
                NewMouseLocation = e.Location;
                int xDiff = NewMouseLocation.X - MouseLocation.X;
                int yDiff = NewMouseLocation.Y - MouseLocation.Y;
                Polygon p = new Polygon();
                foreach (Vertex v in MyPolygon.ListOfVertexes)
                {
                    try
                    {
                        p.ListOfVertexes.Add(new Vertex(v.Location.X + xDiff, v.Location.Y + yDiff));
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                    }
                }
                p.MovedEdges(xDiff, yDiff, MyPolygon.ListOfEdges);
                MyPolygon = p;
                DrawAll(Color.Black);
                MouseLocation = NewMouseLocation;
            }
            if (MoveVertexButton.Checked && IsPolygonCreated)
            {
                if(!MouseDown)
                    return;
                Vertex v = MyPolygon.ClosestVertex(MouseLocation);
                if (v == null)
                    return;
                NewMouseLocation = e.Location;
                int index = MyPolygon.ListOfVertexes.FindIndex(ver => ver.Equals(v));
                int xDiff = NewMouseLocation.X - MouseLocation.X;
                int yDiff = NewMouseLocation.Y - MouseLocation.Y;
                v.Location.X += xDiff;
                v.Location.Y += yDiff;
                Edge edge = new NormalEdge(MyPolygon.ListOfVertexes[index - 1 < 0 ? MyPolygon.ListOfVertexes.Count-1 : index - 1].Location, v.Location);
                MyPolygon.ListOfEdges.RemoveAt(index - 1 < 0 ? MyPolygon.ListOfEdges.Count - 1 : index - 1);
                MyPolygon.ListOfEdges.Insert(index - 1 < 0 ? MyPolygon.ListOfEdges.Count : index - 1, edge);
                edge = new NormalEdge(v.Location, MyPolygon.ListOfVertexes[index + 1 == MyPolygon.ListOfVertexes.Count ? 0 : index +1].Location);
                MyPolygon.ListOfEdges.RemoveAt(index);
                MyPolygon.ListOfEdges.Insert(index, edge);
                DrawAll(Color.Black);
                MouseLocation = NewMouseLocation;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }

        private void DeletePolygonButton_Click(object sender, EventArgs e)
        {
            IsPolygonCreated = false;
            MyPolygon = null;
            DrawArea.Dispose();
            DrawArea = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = DrawArea;
        }
    }
}
