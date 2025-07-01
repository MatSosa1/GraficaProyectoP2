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
    public partial class Main : Form
    {
        private Shape3D s;

        private Graphics g;
        private Pen pen;
        private List<int> listFloors = new List<int>();
        int cantValues = 50;
        int stepsValues = 2;

        public Main()
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

        private void DrawPolygons(List<List<Vector3>> polys, Graphics g)
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

        private void DrawShape3D(Graphics e)
        {
            var polys = s.GetPolygons();

            DrawPolygons(polys, e);

            for (int j = 0; j < s.GetSizesLength() - 1; j++)  // Magnitudes
            {
                var pointsPolyInf = polys[j];  // Abajo
                var pointsPolySup = polys[j + 1];  // Arriba

                for (int i = 0; i < s.GetNumLados(); i++)  // Lados
                    e.DrawLine(new Pen(Color.Red, 1), pointsPolyInf[i].ToPointF(), pointsPolySup[i].ToPointF());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            listFloors.Clear();
            listFloors = Interpolate.InterpolateLinearData(cantValues, stepsValues);
            listFloors.AddRange(Interpolate.ReverseValues(Interpolate.InterpolateLinearData(cantValues, stepsValues)));

            s = new Shape3D(4, GetCanvasCenter(), listFloors, stepsValues);

            picCanvas.Invalidate();
        }

        private void btnRotateZ_Click(object sender, EventArgs e)
        {
            s.RotateZ(Math.PI / 12);

            picCanvas.Invalidate();
        }

        private void btnRotateX_Click(object sender, EventArgs e)
        {
            s.RotateX(Math.PI / 12);

            picCanvas.Invalidate();
        }

        private void btnRotateY_Click(object sender, EventArgs e)
        {
            s.RotateY(Math.PI / 12);

            picCanvas.Invalidate();
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            picCanvas.Width = this.Width;
            picCanvas.Height = this.Height;

            btnNew.Location = new Point(picCanvas.Width / 10, btnNew.Location.Y);
            btnRotateX.Location = new Point(picCanvas.Width - picCanvas.Width / 10, btnRotateX.Location.Y);
            btnRotateY.Location = new Point(picCanvas.Width - picCanvas.Width / 10, btnRotateY.Location.Y);
            btnRotateZ.Location = new Point(picCanvas.Width - picCanvas.Width / 10, btnRotateZ.Location.Y);

            btnNew_Click(sender, e);
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            DrawShape3D(e.Graphics);
        }
    }
}
