using ProyectoGrafica_3D.src.utils;
using Shape;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrafica_3D
{
    public partial class Form1 : Form
    {
        private Shape3D s;

        private Graphics g;
        private Pen pen;

        public Form1()
        {
            InitializeComponent();

            g = picCanvas.CreateGraphics();
            pen = new Pen(Color.Black, 1);

            ClearCanvas();
        }

        public PointF GetCanvasCenter()
        {
            return new PointF
            {
                X = picCanvas.Width / 2,
                Y = picCanvas.Height / 2,
            };
        }

        private void DrawPolygons(List<List<Vector3>> polys)
        {
            foreach (var poly in polys)
            {
                List<PointF> points = new List<PointF>();
                foreach (var p in poly)
                    points.Add(p.ToPointF());

                g.DrawPolygon(pen, points.ToArray());
            }
        }

        private void ClearCanvas()
        {
            g.Clear(Color.White);
        }

        private void DrawShape3D(Shape3D shape)
        {
            ClearCanvas();

            var polys = shape.GetPolygons();

            DrawPolygons(polys);

            for (int j = 0; j < shape.GetSizesLength() - 1; j++)  // Magnitudes
            {
                var pointsPolyInf = polys[j];  // Abajo
                var pointsPolySup = polys[j + 1];  // Arriba

                for (int i = 0; i < shape.GetNumLados(); i++)  // Lados
                    g.DrawLine(pen, pointsPolyInf[i].ToPointF(), pointsPolySup[i].ToPointF());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int cantValues = 25;
            int stepsValues = 3;

            var listFloors = new List<int> { 50, 50 };

            //var listFloors = Interpolate.ReverseValues(Interpolate.InterpolateGradualData(cantValues, stepsValues));
            //listFloors.AddRange(Interpolate.InterpolateGradualData(cantValues, stepsValues));

            s = new Shape3D(4, GetCanvasCenter(), listFloors, 50);

            DrawShape3D(s);
        }

        private void btnRotateZ_Click(object sender, EventArgs e)
        {
            s.RotateZ(Math.PI / 12);

            DrawShape3D(s);
        }

        private void btnRotateX_Click(object sender, EventArgs e)
        {
            s.RotateX(Math.PI / 12);

            DrawShape3D(s);
        }

        private void btnRotateY_Click(object sender, EventArgs e)
        {
            s.RotateY(Math.PI / 12);

            DrawShape3D(s);
        }
    }
}
