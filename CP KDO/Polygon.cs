using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CP_KDO
{
    class Polygon
    {
        private Point[] points; //вершини многокутника
        private GraphicsPath path; //служит для малювання многокутника
        private int minX, maxX, minY, maxY;

        public Polygon(int[] points)
        {
            if (points.Length < 6 || points.Length % 2 == 1)
                throw new Exception();

            minX = minY = int.MaxValue;
            maxX = maxY = int.MinValue;

            this.points = new Point[points.Length / 2];
            for (int i = 0; i < points.Length; i += 2)
            {
                minX = Math.Min(minX, points[i]);
                maxX = Math.Max(maxX, points[i]);
                minY = Math.Min(minY, points[i + 1]);
                maxY = Math.Max(maxY, points[i + 1]);

                this.points[i / 2] = new Point(points[i], points[i + 1]);
            }

            path = new GraphicsPath();
        }

        public Point[] getPoints()
        {
            return points;
        }

        public void fill(Graphics g, SolidBrush brush, float translateX, float translateY, float scale) //малювання многокутника в точці (translateX, translateY) і масштабом scale
        {
            path.Reset();

            float lastX = (points[0].X - minX) * scale + translateX;
            float lastY = (points[0].Y - minY) * scale + translateY;

            for (int i = 1; i < points.Length; i++)
            {
                float x = (points[i].X - minX) * scale + translateX;
                float y = (points[i].Y - minY) * scale + translateY;

                path.AddLine(lastX, lastY, x, y);

                lastX = x;
                lastY = y;
            }

            g.FillPath(brush, path);
        }

        private PointOverEdge classify(Point p, Point v, Point w) //положення точки p відносно відрізка vw
        {
            //коефіцієнти
            int a = v.Y - w.Y;
            int b = w.X - v.X;
            int c = v.X * w.Y - w.X * v.Y;

            //підставимо точку в  рівняння прямої
            int f = a * p.X + b * p.Y + c;
            if (f > 0)
                return PointOverEdge.RIGHT; //точка лежить зправа від відрізка
            if (f < 0)
                return PointOverEdge.LEFT; //зліва від відрізка

            int minX = Math.Min(v.X, w.X);
            int maxX = Math.Max(v.X, w.X);
            int minY = Math.Min(v.Y, w.Y);
            int maxY = Math.Max(v.Y, w.Y);

            if (minX <= p.X && p.X <= maxX && minY <= p.Y && p.Y <= maxY)
                return PointOverEdge.BETWEEN; //точка лежить на відрізку
            return PointOverEdge.OUTSIDE; //точка лежить на прямій, але не на відрізку
        }

        private EdgeType edgeType(Point a, Point v, Point w) //тип ребра vw для точки a
        {
            switch (classify(a, v, w))
            {
                case PointOverEdge.LEFT:
                    return ((v.Y < a.Y) && (a.Y <= w.Y)) ? EdgeType.CROSSING : EdgeType.INESSENTIAL;
                case PointOverEdge.RIGHT:
                    return ((w.Y < a.Y) && (a.Y <= v.Y)) ? EdgeType.CROSSING : EdgeType.INESSENTIAL;
                case PointOverEdge.BETWEEN:
                    return EdgeType.TOUCHING;
                default:
                    return EdgeType.INESSENTIAL;
            }
        }

        public PointInPolygon pointInPolygon(Point a) //положення точки в многокутнику
        {
            bool parity = true;
            for (int i = 0; i < points.Length; i++)
            {
                Point v = points[i];
                Point w = points[(i + 1) % points.Length];

                switch (edgeType(a, v, w))
                {
                    case EdgeType.TOUCHING:
                        return PointInPolygon.BOUNDARY;
                    case EdgeType.CROSSING:
                        parity = !parity;
                        break;
                }
            }

            return parity ? PointInPolygon.OUTSIDE : PointInPolygon.INSIDE;
        }

        public int MinX()
        {
            return minX;
        }

        public int MaxX()
        {
            return maxX;
        }

        public int MinY()
        {
            return minY;
        }

        public int MaxY()
        {
            return maxY;
        }

        public int width() //ширина
        {
            return maxX - minX;
        }

        public int height() //высота
        {
            return maxY - minY;
        }

        public enum PointInPolygon { INSIDE, OUTSIDE, BOUNDARY } //положення точки в многокутнику

        private enum EdgeType { TOUCHING, CROSSING, INESSENTIAL } //положення ребра

        private enum PointOverEdge { LEFT, RIGHT, BETWEEN, OUTSIDE } //положення точки відносно відрізка

    }
}
