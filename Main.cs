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
        private float btnNewRatioX;
        private float btnRotateXRatioX;
        private float btnRotateYRatioX;
        private float btnRotateZRatioX;

        bool menuExpand = false;

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

        private void DrawShape3D()
        {
            ClearCanvas();

            var polys = s.GetPolygons();

            DrawPolygons(polys);

            for (int j = 0; j < s.GetSizesLength() - 1; j++)  // Magnitudes
            {
                var pointsPolyInf = polys[j];  // Abajo
                var pointsPolySup = polys[j + 1];  // Arriba

                for (int i = 0; i < s.GetNumLados(); i++)  // Lados
                    g.DrawLine(new Pen(Color.Red, 1), pointsPolyInf[i].ToPointF(), pointsPolySup[i].ToPointF());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //listFloors.Clear();
            //listFloors = Interpolate.InterpolateLinearData(cantValues, stepsValues);
            //listFloors.AddRange(Interpolate.InterpolateGradualData(cantValues, stepsValues));

            s = new Shape3D(4, GetCanvasCenter(), new List<int> { 50, 50, 50, 50 }, 50);

            DrawShape3D();
            //picCanvas.Invalidate();
        }

        private void btnRotateZ_Click(object sender, EventArgs e)
        {
            s.RotateZ(Math.PI / 12);

            DrawShape3D();
            //picCanvas.Invalidate();
        }

        private void btnRotateX_Click(object sender, EventArgs e)
        {
            s.RotateX(Math.PI / 12);

            DrawShape3D();
            //picCanvas.Invalidate();
        }

        private void btnRotateY_Click(object sender, EventArgs e)
        {
            s.RotateY(Math.PI / 12);

            DrawShape3D();
            //picCanvas.Invalidate();
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            picCanvas.Width = this.Width;
            picCanvas.Height = this.Height;

            int rightMargin = 0; 
            int topMargin = 0;   
            int spacing = 0;     

            int btnCloseWidth = btnClose.Width;
            int btnMaximizeWidth = btnMaximize.Width;
            int btnMinimizeWidth = btnMinimize.Width;

            btnClose.Location = new Point(
                this.ClientSize.Width - btnCloseWidth - rightMargin,
                topMargin
            );
            btnMaximize.Location = new Point(
                btnClose.Left - btnMaximizeWidth - spacing,
                topMargin
            );
            btnMinimize.Location = new Point(
                btnMaximize.Left - btnMinimizeWidth - spacing,
                topMargin
            );

            g = picCanvas.CreateGraphics();

            //btnNew_Click(sender, e);
        }

        private void btnTranslateX_Click(object sender, EventArgs e)
        {
            s.TranslateX(10);

            DrawShape3D();
        }

        private void btnTranslateY_Click(object sender, EventArgs e)
        {
            s.TranslateY(10);

            DrawShape3D();
        }

        private void btnTranslateZ_Click(object sender, EventArgs e)
        {
            s.TranslateZ(10);

            DrawShape3D();
        }

        private void btnScaleX_Click(object sender, EventArgs e)
        {
            s.ScaleX(1.1);

            DrawShape3D();
        }

        private void btnScaleY_Click(object sender, EventArgs e)
        {
            s.ScaleY(1.1);

            DrawShape3D();
        }

        private void btnScaleZ_Click(object sender, EventArgs e)
        {
            s.ScaleZ(1.1);

            DrawShape3D();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnRotateXRatioX = (float)btnRotateX.Location.X / this.Width;
            btnRotateYRatioX = (float)btnRotateY.Location.X / this.Width;
            btnRotateZRatioX = (float)btnRotateZ.Location.X / this.Width;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTimer.Start();
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Width += 10;
                if (menuContainer.Width >= 400)
                {
                    menuTimer.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Width -= 10;
                if (menuContainer.Width <= 55)
                {
                    menuTimer.Stop();
                    menuExpand = false;
                    btnRightArrow.Visible = true;
                }
            }
        }

        private void btnLeftArrow_Click(object sender, EventArgs e)
        {
            menuTimer.Start();
        }

        private void btnRightArrow_Click(object sender, EventArgs e)
        {
            menuTimer.Start();
            btnRightArrow.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
