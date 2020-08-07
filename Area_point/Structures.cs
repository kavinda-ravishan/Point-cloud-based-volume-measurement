namespace Area_point
{
    public struct Point
    {
        public float X;
        public float Y;
        public float Z;

        public Point(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point operator +(Point point1, Point point2)
        {
            Point point3 = new Point(0, 0, 0);
            point3.X = point1.X + point2.X;
            point3.Y = point1.Y + point2.Y;
            point3.Z = point1.Z + point2.Z;
            return point3;
        }
    };

    public struct PointEx
    {
        public float X;
        public float Y;
        public float Z;
        public float Theta;
        public float Lambda;
        public float Value;

        public PointEx(float x, float y, float z, float theta = 0, float lambda = 0, float value=0)
        {
            X = x;
            Y = y;
            Z = z;
            Theta = theta;
            Lambda = lambda;
            Value = value;
        }
    };

    public struct Fase
    {
        public int P1;
        public int P2;
        public int P3;

        public Fase(int p1, int p2, int p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }
    };

    public struct PointXY
    {
        public float X;
        public float Y;

        public PointXY(float x, float y, float z)
        {
            X = x;
            Y = y;
        }
    };
}
