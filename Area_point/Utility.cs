using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Area_point
{
    public enum Model { cylinder, sphere, Complete_Model };

    class PointByTheta
    {
        public int m_slotsPerGroup;//0 to (m_slotsPerGroup-1)
        public int m_noOfThetaGroups;//0 to (m_noOfGroups-1)
        private List<PointEx> m_pointsEx;

        public PointByTheta(ref List<PointEx> pointsEx)
        {
            m_pointsEx = pointsEx;
            float thetaPrevious = pointsEx[0].Theta;
            foreach (PointEx point in pointsEx)
            {
                if (thetaPrevious <= point.Theta)
                {
                    m_noOfThetaGroups++;
                }
                else
                {
                    break;
                }
                thetaPrevious = point.Theta;
            }

            m_slotsPerGroup = (pointsEx.Count - 1) / m_noOfThetaGroups;
        }

        public PointEx SearchPointByTheta(int group, int slot)
        {
            return m_pointsEx[group + (slot * m_noOfThetaGroups)];
        }

        public List<PointEx> GetGroup(int group)
        {
            List<PointEx> pointsEx = new List<PointEx>();

            for (int slot = 0; slot < m_slotsPerGroup; slot++)
            {
                pointsEx.Add(SearchPointByTheta(group, slot));
            }

            return pointsEx;
        }
    }

    static class DebugFunctions
    {
        static public void writePointExListConsol(List<PointEx> points)
        {
            foreach (PointEx point in points)
            {
                writePointExConsol(point);
            }
        }

        static public void writePointExConsol(PointEx point)
        {
            Console.WriteLine(
                point.Theta.ToString() + ' ' +
                point.X.ToString() + ' ' +
                point.Y.ToString() + ' ' +
                point.Z.ToString() + ' ' +
                point.Lambda.ToString() + ' ' +
                point.Value.ToString()
                );
        }

        static public void writePointXYConsol(PointXY point)
        {
            Console.WriteLine(
                point.X.ToString() + ' ' +
                point.Y.ToString()
                );
        }

        static public void writePointXYListConsol(List<PointXY> points)
        {
            foreach (PointXY point in points)
            {
                writePointXYConsol(point);
            }
        }

        public static void writeMatConsol(double[,] Mat)
        {
            for (int i = 0; i < Mat.GetLength(0); i++)
            {
                for (int j = 0; j < Mat.GetLength(1); j++)
                {
                    Console.Write(" " + Mat[i, j]);
                }
                Console.WriteLine();
            }
        }
    };

    static class Calculate
    {
        public static float Area(ref List<PointXY> points)
        {
            float area = 0;

            for (int i = 0; i < points.Count - 1; i++)
            {
                area = area + (points[i + 1].X + points[i].X) * (points[i + 1].Y - points[i].Y);
            }
            area = area + (points[0].X + points[points.Count - 1].X) * (points[0].Y - points[points.Count - 1].Y);

            return Math.Abs(area / 2);
        }

        public static double DET(int n, double[,] Mat)
        {
            double d = 0;
            int k, i, j, subi, subj;
            double[,] SUBMat = new double[n, n];
            if (n == 2)
            {
                return ((Mat[0, 0] * Mat[1, 1]) - (Mat[1, 0] * Mat[0, 1]));
            }
            else
            {
                for (k = 0; k < n; k++)
                {
                    subi = 0;
                    for (i = 1; i < n; i++)
                    {
                        subj = 0;
                        for (j = 0; j < n; j++)
                        {
                            if (j == k)
                            {
                                continue;
                            }
                            SUBMat[subi, subj] = Mat[i, j];
                            subj++;
                        }
                        subi++;
                    }
                    d = d + ((double)Math.Pow(-1, k) * Mat[0, k] * DET(n - 1, SUBMat));
                }
            }
            return d;
        }

        public static double Volume(double det)
        {
            return Math.Abs(det) / 6;
        }
        public static double VolFromDet(List<Point> points)
        {
            if (points.Count != 4) throw new Exception("Invalide face count");
            else
            {
                double[,] Mat = new double[,] {
                { points[0].X, points[0].Y, points[0].Z, 1 },
                { points[1].X, points[1].Y, points[1].Z, 1 },
                { points[2].X, points[2].Y, points[2].Z, 1 },
                { points[3].X, points[3].Y, points[3].Z, 1 },
                };

                return Volume(DET(4, Mat));
            }

        }

        public static void GetFaces(ref List<Fase> faces,ref List<PointEx> points, int noOfThetaGroups, Model model)//fase numbers start from one
        {
            int pointCount;

            if (Model.sphere == model || Model.Complete_Model == model)
            {
                pointCount = points.Count;

                for (int m = 1; m <= ((pointCount - 1) / noOfThetaGroups) - 1; m++)
                {
                    for (int n = ((m - 1) * noOfThetaGroups) + 1; n < m * noOfThetaGroups; n++)
                    {
                        faces.Add(new Fase(n, n + 1, n + noOfThetaGroups));
                        faces.Add(new Fase(noOfThetaGroups + n, noOfThetaGroups + n + 1, n + 1));
                    }
                    faces.Add(new Fase(noOfThetaGroups * m, (noOfThetaGroups * m) - noOfThetaGroups + 1, noOfThetaGroups * (m + 1)));
                    faces.Add(new Fase(noOfThetaGroups * (m + 1), (noOfThetaGroups * m) + 1, (noOfThetaGroups * m) - noOfThetaGroups + 1));
                }

                for (int n = (pointCount - noOfThetaGroups); n < pointCount - 1; n++) //Bottom faces
                {
                    faces.Add(new Fase(n, n + 1, pointCount));
                }
                faces.Add(new Fase(pointCount - 1, (pointCount - noOfThetaGroups), pointCount));
            }
            else
            {
                points.Insert(0, new PointEx(0, 0, 0));
                pointCount = points.Count;

                for (int n = 2; n < noOfThetaGroups + 1; n++) //Top faces
                {
                    faces.Add(new Fase(n, n + 1, 1));
                }
                faces.Add(new Fase(noOfThetaGroups + 1, 2, 1));

                for (int m = 1; m <= ((pointCount - 1) / noOfThetaGroups) - 1; m++)
                {
                    for (int n = ((m - 1) * noOfThetaGroups) + 2; n <= m * noOfThetaGroups; n++)
                    {
                        faces.Add(new Fase(n, n + 1, n + noOfThetaGroups));
                        faces.Add(new Fase(noOfThetaGroups + n, noOfThetaGroups + n + 1, n + 1));
                    }
                    faces.Add(new Fase((noOfThetaGroups * m) + 1, (noOfThetaGroups * m) - noOfThetaGroups + 2, (noOfThetaGroups * (m + 1)) + 1));
                    faces.Add(new Fase((noOfThetaGroups * (m + 1))+1, (noOfThetaGroups * m) + 2, (noOfThetaGroups * m) - noOfThetaGroups + 2));
                }
            }
        }
    };

    public class Volume
    {
        public Volume()
        {
            prograssChangeArgs = new VolumePrograssChangedEventArgs();
            volumeCalculatedArgs = new VolumeCalculatedEventArgs();
        }

        private VolumePrograssChangedEventArgs prograssChangeArgs;
        private VolumeCalculatedEventArgs volumeCalculatedArgs;

        protected virtual void OnPrograssChanged(VolumePrograssChangedEventArgs e)
        {
            prograssChanged?.Invoke(this, e);
        }
        protected virtual void OnVolumeCalculated(VolumeCalculatedEventArgs e)
        {
            volumeCalculated?.Invoke(this, e);
        }

        public event EventHandler<VolumePrograssChangedEventArgs> prograssChanged;
        public event EventHandler<VolumeCalculatedEventArgs> volumeCalculated;

        public void TotalVolume(ref List<PointEx> pointsEx,ref List<Fase> faces,Model model)
        {
            Point zStart;

            if(Model.sphere == model)
            {
                zStart = new Point(0, 0, pointsEx[0].Z);
            }

            else if(Model.cylinder == model)
            {
                zStart = new Point(0, 0, pointsEx[pointsEx.Count - 1].Z);
            }
            else
            {
                zStart = new Point(0, 0, 0);
            }

            List<Point> points = new List<Point>();
            double totalVolume = 0;
            int prograss = 0;
            int total = faces.Count;
            int div = total / 100;

            prograssChangeArgs.total = total;
            prograssChangeArgs.prograss = prograss;
            OnPrograssChanged(prograssChangeArgs);

            foreach (Fase fase in faces)
            {
                Point p1 = new Point(pointsEx[fase.P1 - 1].X, pointsEx[fase.P1 - 1].Y, pointsEx[fase.P1 - 1].Z);
                Point p2 = new Point(pointsEx[fase.P2 - 1].X, pointsEx[fase.P2 - 1].Y, pointsEx[fase.P2 - 1].Z);
                Point p3 = new Point(pointsEx[fase.P3 - 1].X, pointsEx[fase.P3 - 1].Y, pointsEx[fase.P3 - 1].Z);

                points.Add(p1);
                points.Add(p2);
                points.Add(p3);
                points.Add(zStart);

                totalVolume = totalVolume + Calculate.VolFromDet(points);
                points.Clear();
                prograss++;

                if (prograss % div == 0)
                {
                    prograssChangeArgs.prograss = prograss;
                    OnPrograssChanged(prograssChangeArgs);
                }
                
            }
            prograssChangeArgs.prograss = total;
            OnPrograssChanged(prograssChangeArgs);

            volumeCalculatedArgs.volume = totalVolume;
            OnVolumeCalculated(volumeCalculatedArgs);
        }

    };

    public class VolumePrograssChangedEventArgs : EventArgs
    {
        public int prograss { get; set; }
        public int total { get; set; }
    }

    public class VolumeCalculatedEventArgs : EventArgs
    {
        public double volume { get; set; }
    }

    public static class ModelVolume
    {
        public static bool updated = false;
        public static double volumeS = 0;
        public static double volumeC = 0;
    }
}
