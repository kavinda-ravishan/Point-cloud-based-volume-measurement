using System;
using System.Collections.Generic;
using System.IO;

namespace Area_point
{
    static class Write
    {
        public static void PCDFile(ref List<Point> points, float rgb = 0)
        {
            string filePath = @"GeneratedFiles/points.pcd";
            StreamWriter file = new StreamWriter(filePath);

            file.WriteLine("# .PCD v0.7 - Point Cloud Data file format");
            file.WriteLine("VERSION 0.7");
            file.WriteLine("FIELDS x y z rgb");
            file.WriteLine("SIZE 4 4 4 4");
            file.WriteLine("TYPE F F F F");
            file.WriteLine("COUNT 1 1 1 1");
            file.WriteLine("WIDTH " + points.Count.ToString());
            file.WriteLine("HEIGHT 1");
            file.WriteLine("VIEWPOINT 0 0 0 1 0 0 0");
            file.WriteLine("POINTS " + points.Count.ToString());
            file.WriteLine("DATA ascii");
            for (int i = 0; i < points.Count; i++)
            {
                file.WriteLine(points[i].X.ToString() + ' ' + points[i].Y.ToString() + ' ' + points[i].Z.ToString() + ' ' + rgb.ToString());
            }

            file.Close();
            file.Dispose();
        }

        public static void OBJFile(ref List<Point> points,ref List<Fase> faces)
        {
            string filePath = @"GeneratedFiles/points.obj";
            StreamWriter file = new StreamWriter(filePath);

            file.WriteLine("# OBJ file format with ext .obj");
            file.WriteLine("# vertex count = " + points.Count.ToString());
            file.WriteLine("# face count = " + faces.Count.ToString());
            for (int i = 0; i < points.Count; i++)
            {
                file.WriteLine("v " + points[i].X.ToString() + ' ' + points[i].Y.ToString() + ' ' + points[i].Z.ToString());
            }

            for (int i = 0; i < faces.Count; i++)
            {
                file.WriteLine("f " + faces[i].P1.ToString() + ' ' + faces[i].P2.ToString() + ' ' + faces[i].P3.ToString());
            }

            file.Close();
            file.Dispose();
        }

        public static void PCDFileEx(ref List<PointEx> pointsEx, float rgb = 0)
        {
            string filePath = @"GeneratedFiles/points.pcd";
            StreamWriter file = new StreamWriter(filePath);

            file.WriteLine("# .PCD v0.7 - Point Cloud Data file format");
            file.WriteLine("VERSION 0.7");
            file.WriteLine("FIELDS x y z rgb");
            file.WriteLine("SIZE 4 4 4 4");
            file.WriteLine("TYPE F F F F");
            file.WriteLine("COUNT 1 1 1 1");
            file.WriteLine("WIDTH " + pointsEx.Count.ToString());
            file.WriteLine("HEIGHT 1");
            file.WriteLine("VIEWPOINT 0 0 0 1 0 0 0");
            file.WriteLine("POINTS " + pointsEx.Count.ToString());
            file.WriteLine("DATA ascii");
            for (int i = 0; i < pointsEx.Count; i++)
            {
                file.WriteLine(pointsEx[i].X.ToString() + ' ' + pointsEx[i].Y.ToString() + ' ' + pointsEx[i].Z.ToString() + ' ' + rgb.ToString());
            }

            file.Close();
            file.Dispose();
        }

        public static void OBJFileEx(ref List<PointEx> pointsEx,ref List<Fase> faces,string fileName)
        {
            string filePath = @"GeneratedFiles/" + fileName + ".obj";
            StreamWriter file = new StreamWriter(filePath);

            file.WriteLine("# OBJ file format with ext .obj");
            file.WriteLine("# vertex count = " + pointsEx.Count.ToString());
            file.WriteLine("# face count = " + faces.Count.ToString());
            for (int i = 0; i < pointsEx.Count; i++)
            {
                file.WriteLine("v " + pointsEx[i].X.ToString() + ' ' + pointsEx[i].Y.ToString() + ' ' + pointsEx[i].Z.ToString());
            }

            for (int i = 0; i < faces.Count; i++)
            {
                file.WriteLine("f " + faces[i].P1.ToString() + ' ' + faces[i].P2.ToString() + ' ' + faces[i].P3.ToString());
            }

            file.Close();
            file.Dispose();
        }

        public static void ModelFileEx(ref List<PointEx> pointsEx,string fileName)
        {
            string filePath = @"GeneratedFiles/" + fileName + ".model";
            StreamWriter file = new StreamWriter(filePath);

            file.WriteLine(pointsEx.Count.ToString());

            for (int i = 0; i < pointsEx.Count; i++)
            {
                file.WriteLine(
                    pointsEx[i].X.ToString() + ' ' +
                    pointsEx[i].Y.ToString() + ' ' +
                    pointsEx[i].Z.ToString() + ' ' +
                    pointsEx[i].Theta.ToString() + ' ' +
                    pointsEx[i].Lambda.ToString() + ' ' +
                    pointsEx[i].Value.ToString());
            }

            file.Close();
            file.Dispose();
        }
    }

    static class Read
    {
        public static void ModelFileEx(ref List<PointEx> pointsEx)
        {
            string filePath = @"GeneratedFiles/pointsEx.model";
            StreamReader file = new StreamReader(filePath);

            int pointCount = System.Convert.ToInt32(file.ReadLine());

            for (int i = 0; i < pointCount; i++)
            {
                string[] value = file.ReadLine().Split(' ');

                pointsEx.Add(new PointEx(
                    (float)System.Convert.ToDouble(value[0]),
                    (float)System.Convert.ToDouble(value[1]),
                    (float)System.Convert.ToDouble(value[2]),
                    (float)System.Convert.ToDouble(value[3]),
                    (float)System.Convert.ToDouble(value[4]),
                    (float)System.Convert.ToDouble(value[5])
                    ));
            }
            
            file.Close();
            file.Dispose();
        }
    }

    class ReadAsynchronous
    {
        public ReadAsynchronous()
        {
            prograssChangeArgs = new ModelReadPrograssChangedEventArgs();
            modelReadEventArgs = new ModelReadEventArgs();
            points = new List<PointEx>();
        }
        public List<PointEx> points;
        private ModelReadPrograssChangedEventArgs prograssChangeArgs;
        private ModelReadEventArgs modelReadEventArgs;

        protected virtual void OnPrograssChanged(ModelReadPrograssChangedEventArgs e)
        {
            prograssChanged?.Invoke(this, e);
        }
        protected virtual void OnModelRead(ModelReadEventArgs e)
        {
            modelRead?.Invoke(this, e);
        }

        public event EventHandler<ModelReadPrograssChangedEventArgs> prograssChanged;
        public event EventHandler<ModelReadEventArgs> modelRead;

        public void ModelFileEx()
        {
            string filePath = @"GeneratedFiles/pointsEx.model";
            StreamReader file = new StreamReader(filePath);

            int pointCount = System.Convert.ToInt32(file.ReadLine());
            
            int prograss = 0;
            int div = pointCount / 100;

            prograssChangeArgs.total = pointCount;
            prograssChangeArgs.prograss = prograss;
            OnPrograssChanged(prograssChangeArgs);

            for (int i = 0; i < pointCount; i++)
            {
                string[] value = file.ReadLine().Split(' ');

                points.Add(new PointEx(
                    (float)System.Convert.ToDouble(value[0]),
                    (float)System.Convert.ToDouble(value[1]),
                    (float)System.Convert.ToDouble(value[2]),
                    (float)System.Convert.ToDouble(value[3]),
                    (float)System.Convert.ToDouble(value[4]),
                    (float)System.Convert.ToDouble(value[5])
                    ));

                prograss++;
                if (prograss % div == 0)
                {
                    prograssChangeArgs.prograss = prograss;
                    OnPrograssChanged(prograssChangeArgs);
                }
            }

            file.Close();
            file.Dispose();

            prograssChangeArgs.prograss = pointCount;
            OnPrograssChanged(prograssChangeArgs);
            OnModelRead(modelReadEventArgs);
        }
    }

    public class ModelReadPrograssChangedEventArgs : EventArgs
    {
        public int prograss { get; set; }
        public int total { get; set; }
    }

    public class ModelReadEventArgs : EventArgs
    {
    }
}
