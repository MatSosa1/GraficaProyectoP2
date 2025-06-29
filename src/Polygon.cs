﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace Shape
{
    internal class Polygon
    {
        private readonly int NumLados;
        private float Magnitud;
        private double RadRotate;
        private PointF Center;

        public Polygon(int numLados, float magnitud, PointF center = new PointF(), double radRotate = 0)
        {
            NumLados = numLados;
            Magnitud = magnitud;
            Center = center;
            RadRotate = radRotate;
        }

        public float GetMagnitud()
        {
            return Magnitud;
        }

        public void SetMagnitud (float newMag)
        {
            this.Magnitud = newMag;
        }

        public double GetRotation()
        {
            return RadRotate;
        }

        public void SetRotation(double newRadRotate)
        {
            RadRotate = newRadRotate;
        }

        public double GetRadius()
        {
            return Magnitud / (2 * Math.Sin(GetRad() / 2));
        }

        public double GetRad()
        {
            return Math.PI * 2 / NumLados;
        }

        public double GetApothema()
        {
            return Magnitud / (2 * Math.Tan(GetRad() / 2));
        }

        public int GetNumLados()
        {
            return NumLados;
        }

        public void TraslateX(float x)
        {
            this.Center.X += x;
        }

        public void TraslateY(float y)
        {
            this.Center.Y += y;
        }

        public PointF GetCenter()
        {
            return this.Center;
        }

        public void SetCenter(float x, float y)
        {
            this.Center.X = x;
            this.Center.Y = y;
        }

        public void SetCenter(PointF newCenter)
        {
            // No asigno por si el valor se conserva en memoria
            this.Center.X = newCenter.X;
            this.Center.Y = newCenter.Y;
        }

        public void Scale(float x)
        {
            this.Magnitud *= x;
        }

        public PointF[] GetOutline()
        {
            List<PointF> points = new List<PointF>();
            double rad = GetRad();

            for (int i = 0; i < NumLados; i++)
            {
                PointF p = new PointF
                {
                    X = Center.X + (float)(Math.Cos((rad * i) + RadRotate) * Magnitud),
                    Y = Center.Y + (float)(Math.Sin((rad * i) + RadRotate) * Magnitud)
                };

                points.Add(p);
            }

            return points.ToArray();
        }
    }
}

