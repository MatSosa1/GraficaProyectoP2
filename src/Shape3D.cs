using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Vector3
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3(double X, double Y, double Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public Vector3() { }

        public void RotateX(double radRot)
        {
            double y = Y;
            double z = Z;

            Y = y * Math.Cos(radRot) - z * Math.Sin(radRot);
            Z = y * Math.Sin(radRot) + z * Math.Cos(radRot);
        }

        public void RotateY(double radRot)
        {
            double x = X;
            double z = Z;

            X = x * Math.Cos(radRot) + z * Math.Sin(radRot);
            Z = -x * Math.Sin(radRot) + z * Math.Cos(radRot);
        }

        public void RotateZ(double radRot)
        {
            double x = X;
            double y = Y;

            X = x * Math.Cos(radRot) - y * Math.Sin(radRot);
            Y = x * Math.Sin(radRot) + y * Math.Cos(radRot);
        }

        public void TranslateX(double x)
        {
            X += x;
        }

        public void TranslateY(double y)
        {
            Y += y;
        }

        public void TranslateZ(double z)
        {
            Z += z;
        }

        public void ScaleX(double xScaling)
        {
            X *= xScaling;
        }

        public void ScaleY(double yScaling)
        {
            Y *= yScaling;
        }

        public void ScaleZ(double zScaling)
        {
            Z *= zScaling;
        }

        public PointF ToPointF()
        {
            return new PointF
            {
                X = (float)this.X,
                Y = (float)this.Y,
            };
        }

        public Vector3 AddCenter(PointF center)
        {
            return new Vector3()
            {
                X = this.X + center.X,
                Y = this.Y + center.Y,
                Z = this.Z,
            };
        }
    }

    public class Shape3D
    {
        private readonly int NumLados;
        private PointF Center;
        private readonly List<int> Sizes;
        private readonly double SpaceBetween;

        public List<Vector3> Vectors;

        public Shape3D(int numLados, PointF center, List<int> sizes, double spaceBetween)
        {
            NumLados = numLados;
            Center = center;
            Sizes = sizes;
            SpaceBetween = spaceBetween;

            Vectors = new List<Vector3>();

            var rad = GetRad();

            // Multiplicación de Matrices no es conmutativa: A * B != B * A
            for (int i = 0; i < Sizes.Count; i++)
            {
                var radius = Sizes[i] * Math.Sin(rad / 2);
                double ZInit = (spaceBetween / 2) * (Sizes.Count - 1);

                for (int j = 0; j < NumLados; j++)
                {
                    Vector3 v = new Vector3
                    {
                        X = (double)(Math.Cos(rad * j) * radius),
                        Y = (double)(Math.Sin(rad * j) * radius),
                        Z = -ZInit + (i * spaceBetween),
                    };

                    Vectors.Add(v);
                }
            }
        }

        public double GetRad()
        {
            return Math.PI * 2 / NumLados;
        }

        public int GetNumLados()
        {
            return NumLados;
        }

        public int GetSizesLength()
        {
            return Sizes.Count;
        }

        // Centrar con respecto a su centro
        public void RotateX(double radRotate)
        {
            foreach (var v in Vectors)
                v.RotateX(radRotate);
        }

        public void RotateY(double radRotate)
        {
            foreach (var v in Vectors)
                v.RotateY(radRotate);
        }

        public void RotateZ(double radRotate)
        {
            foreach (var v in Vectors)
                v.RotateZ(radRotate);
        }

        public void TranslateX(double x)
        {
            foreach (var v in Vectors)
                v.TranslateX(x);
        }

        public void TranslateY(double y)
        {
            foreach (var v in Vectors)
                v.TranslateY(-y);
        }

        public void TranslateZ(double z)
        {
            foreach (var v in Vectors)
                v.TranslateZ(z);
        }

        public void ScaleX(double x)
        {
            foreach (var v in Vectors)
                v.ScaleX(x);
        }

        public void ScaleY(double y)
        {
            foreach (var v in Vectors)
                v.ScaleY(y);
        }

        public void ScaleZ(double z)
        {
            foreach (var v in Vectors)
                v.ScaleZ(z);
        }

        public PointF[] GetOutline()
        {
            var points = new List<PointF>();

            foreach (var v in Vectors)
                points.Add(new PointF((float)v.X, (float)v.Y));

            return points.ToArray();
        }

        public List<List<Vector3>> GetPolygons()
        {
            var polys = new List<List<Vector3>>();

            for (int i = 0; i < Sizes.Count; i++)
            {
                List<Vector3> v = new List<Vector3>();

                for (int j = 0; j < NumLados; j++)
                    v.Add(Vectors[NumLados * i + j].AddCenter(Center));

                polys.Add(v);
            }
                    
            return polys;
        }
    }
}
