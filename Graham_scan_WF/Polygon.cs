using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graham_scan_WF
{
    public class Polygon
    {
        public List<Point> pointsList = new List<Point>();
        //List<Point> nicepointsList = new List<Point>();
        PictureBox pictureBox;
        Graphics graphics;

        public Polygon(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            graphics = pictureBox.CreateGraphics();
        }

        public void Draw()
        {
            //Point[] points = new Point[nicepointsList.Count];
            //points = nicepointsList.ToArray();
            Point[] points = new Point[pointsList.Count];
            points = pointsList.ToArray();
            Pen pen = new Pen(Color.Red);
            Brush brush = Brushes.Black;
            graphics.Clear(Color.White);
            if (points.Length >= 3)
                Solve(ref points);
            if(points.Length > 1)
                graphics.DrawPolygon(pen, points);            
            
            foreach(Point e in pointsList)
            {
                graphics.FillEllipse(brush, e.X - 5, e.Y - 5, 10, 10);
            }            
        }

        public void AddPoint(int x,int y)
        {
            if (x > 60000)
                throw new ArgumentOutOfRangeException();
            pointsList.Add(new Point(x, y));
            //nicepointsList.Add(new Point(x, y));
            Draw();
        }

        public void RemovePoint(int x,int y)
        {
            for (int i = pointsList.Count-1; i >= 0; i--)
            {
                int dX = pointsList[i].X < x ? x - pointsList[i].X : pointsList[i].X - x;
                int dY = pointsList[i].Y < y ? y - pointsList[i].Y : pointsList[i].Y - y;
                if (dX <= 5 && dY <= 5)
                {
                    //if(nicepointsList.Contains(pointsList[i]))
                    //    nicepointsList.Remove(pointsList[i]);
                    pointsList.RemoveAt(i);
                    break;
                }
            }
            Draw();
        }

        public void Clear()
        {
            pointsList.Clear();
            graphics.Clear(Color.White);
        }
        
        public void Solve(ref Point[] points)
        {
            int min = points[0].X;
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i].X < min)
                {
                    Point tmp = points[i];
                    points[i] = points[0];
                    points[0] = tmp;
                }
            }
            for (int i = 2; i < points.Length; i++)
            {
                //for (int j = i; j > 1 && points[j - 1] > points[j]; j--)   //V1 * V2 =  ( X2 - X1 ) * ( Y3 - Y1 ) - ( Y2 - Y1 ) * ( X3 - X1 ) 
                for (int j = i; j > 1 && (points[j-1].X-points[0].X)*(points[j].Y-points[0].Y)-(points[j-1].Y-points[0].Y)*(points[j].X-points[0].X)>0; j--)
                {
                    Point tmp = points[j - 1];
                    points[j - 1] = points[j];
                    points[j] = tmp;

                }
            }

            List<Point> nicePoints = new List<Point>() { points[0], points[1] };            

            for (int i = 2; i <= points.Length-1; i++)
            {
                nicePoints.Add(points[i]);

                while (true)
                {
                    if (i == points.Length && RotatedRight(nicePoints[nicePoints.Count - 2], nicePoints[nicePoints.Count - 1], nicePoints[0]))
                        nicePoints.RemoveAt(nicePoints.Count - 1);
                    else if (RotatedRight(nicePoints[nicePoints.Count - 3], nicePoints[nicePoints.Count - 2], nicePoints[nicePoints.Count - 1]))
                        nicePoints.RemoveAt(nicePoints.Count - 2);
                    else break;
                }
                    
            }            
            points = nicePoints.ToArray();
        }


        bool RotatedRight(Point p1, Point p2, Point p3)
        {
            if ((p2.X - p1.X) * (p3.Y - p1.Y) - (p2.Y - p1.Y) * (p3.X - p1.X) < 0)
                return false;
            return true;
        }
    }
}
