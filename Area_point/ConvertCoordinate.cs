using System;

namespace Area_point
{
    static class ConvertCoordinate
    {
        public static Point CylindricalToCartesian(float theta, float radius, float z, float ZOff)
        {
            float x = (float)(radius * Math.Cos((Math.PI * theta) / 180));
            float y = (float)(radius * Math.Sin((Math.PI * theta) / 180));

            return new Point(x, y, z + ZOff);
        }

        public static Point SphericalToCartesian(float radius, float lambda, float theta, float ZOff)
        {
            float x = (float)(radius * Math.Cos((Math.PI * lambda) / 180) * Math.Cos((Math.PI * theta) / 180));
            float y = (float)(radius * Math.Cos((Math.PI * lambda) / 180) * Math.Sin((Math.PI * theta) / 180));
            float z = (float)(radius * Math.Sin((Math.PI * lambda) / 180));

            return new Point(x, y, z + ZOff);
        }

        public static PointEx CylindricalToCartesianEx(float theta, float radius, float z, float ZOff)
        {
            float x = (float)(radius * Math.Cos((Math.PI * theta) / 180));
            float y = (float)(radius * Math.Sin((Math.PI * theta) / 180));

            return new PointEx(x, y, z + ZOff, theta, 0, radius);
        }

        public static PointEx SphericalToCartesianEx(float radius, float lambda, float theta, float ZOff)
        {
            float x = (float)(radius * Math.Cos((Math.PI * lambda) / 180) * Math.Cos((Math.PI * theta) / 180));
            float y = (float)(radius * Math.Cos((Math.PI * lambda) / 180) * Math.Sin((Math.PI * theta) / 180));
            float z = (float)(radius * Math.Sin((Math.PI * lambda) / 180));

            return new PointEx(x, y, z + ZOff, theta, lambda, radius);
        }
    }
}
