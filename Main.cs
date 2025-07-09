using ProyectoGrafica_3D.src;
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
        private double currentScaleX = 1;
        private double currentScaleY = 1;
        private double currentScaleZ = 1;
        private double currentRotX = 0;
        private double currentRotY = 0;
        private double currentRotZ = 0;
        private double currentTransX = 0;
        private double currentTransY = 0;
        private double currentTransZ = 0;

        bool menuExpand = false;

        private Shape3D s;
        private Shape3D sOriginal;

        private Graphics g;
        private Pen pen;
        private Pen inlinePen;
        private List<int> listFloors = new List<int>();
        int cantValues = 50;
        int stepsValues = 2;

        public Main()
        {
            InitializeComponent();
            g = picCanvas.CreateGraphics();

            pen = new Pen(Color.Black, 1);
            inlinePen = new Pen(Color.Red, 1);

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

        private void ReapplyTransforms()
        {
            if (sOriginal == null) return;

            s = sOriginal.Clone();
            s.ScaleX(currentScaleX);
            s.ScaleY(currentScaleY);
            s.ScaleZ(currentScaleZ);
            s.RotateX(currentRotX);
            s.RotateY(currentRotY);
            s.RotateZ(currentRotZ);
            s.TranslateX(currentTransX);
            s.TranslateY(currentTransY);
            s.TranslateZ(currentTransZ);

            picCanvas.Invalidate();
        }

        private void ResetTransforms()
        {
            currentScaleX = 1;
            currentScaleY = 1;
            currentScaleZ = 1;
            currentRotX = 0;
            currentRotY = 0;
            currentRotZ = 0;
            currentTransX = 0;
            currentTransY = 0;
            currentTransZ = 0;
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

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (s == null) return;

            var localGraphics = e.Graphics;
            var polys = s.GetPolygons();

            localGraphics.Clear(Color.White);
            foreach (var poly in polys)
            {
                var points = poly.Select(p => p.ToPointF()).ToArray();
                localGraphics.DrawPolygon(pen, points);
            }

            for (int j = 0; j < s.GetSizesLength() - 1; j++)
            {
                var pointsPolyInf = polys[j];
                var pointsPolySup = polys[j + 1];
                for (int i = 0; i < s.GetNumLados(); i++)
                    localGraphics.DrawLine(inlinePen, pointsPolyInf[i].ToPointF(), pointsPolySup[i].ToPointF());
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            s = new Shape3D(4, GetCanvasCenter(), new List<int> { 50, 50, 50, 50 }, 50);
            sOriginal = s.Clone();
            ResetTransforms();
            picCanvas.Invalidate();
        }


        private void btnRotateZ_Click(object sender, EventArgs e)
        {
            currentRotZ += Math.PI / 12;
            ReapplyTransforms();
        }

        private void btnRotateX_Click(object sender, EventArgs e)
        {
            currentRotX += Math.PI / 12;
            ReapplyTransforms();
        }

        private void btnRotateY_Click(object sender, EventArgs e)
        {
            currentRotY += Math.PI / 12;
            ReapplyTransforms();
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
        }

        private void btnTranslateX_Click(object sender, EventArgs e)
        {
            currentTransX += 10;
            ReapplyTransforms();
        }

        private void btnTranslateY_Click(object sender, EventArgs e)
        {
            currentTransY += 10;
            ReapplyTransforms();
        }

        private void btnTranslateZ_Click(object sender, EventArgs e)
        {
            currentTransZ += 10;
            ReapplyTransforms();
        }

        private void Main_Load(object sender, EventArgs e)
        {
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
                if (menuContainer.Width >= 350)
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

        private void btnColorOutline_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorPicker.Color;
                picCanvas.Invalidate();
            }
        }

        private void btnColorInline_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                inlinePen.Color = colorPicker.Color;
                picCanvas.Invalidate();
            }
        }


        private void trScaleX_ValueChanged()
        {
            currentScaleX = trScaleX.Value / 10.0;
            ReapplyTransforms();
        }

        private void trScaleY_ValueChanged()
        {
            currentScaleY = trScaleY.Value / 10.0;
            ReapplyTransforms();
        }

        private void trScaleZ_ValueChanged()
        {
            currentScaleZ = trScaleZ.Value / 10.0;
            ReapplyTransforms();
        }
        private void btnForwardLeft_Click(object sender, EventArgs e)
        {
            currentTransX -= 10;
            ReapplyTransforms();
        }

        private void btnForwardDown_Click(object sender, EventArgs e)
        {
            currentTransY -= 10;
            ReapplyTransforms();
        }

        private void btnDiagRight_Click(object sender, EventArgs e)
        {
            currentScaleX = Math.Max(0.1, currentScaleX * 0.9);
            currentScaleY = Math.Max(0.1, currentScaleY * 0.9);
            currentScaleZ = Math.Max(0.1, currentScaleZ * 0.9);
            ReapplyTransforms();
        }

        private void btnDiagLeft_Click(object sender, EventArgs e)
        {
            currentScaleX = Math.Min(10, currentScaleX * 1.1);
            currentScaleY = Math.Min(10, currentScaleY * 1.1);
            currentScaleZ = Math.Min(10, currentScaleZ * 1.1);
            ReapplyTransforms();
        }

        private void resetAndGenerate()
        {
            sOriginal = s.Clone();
            ResetTransforms();
            picCanvas.Invalidate();
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            s = StaticShapes.GenerateCube(GetCanvasCenter(), 50);

            resetAndGenerate();
        }

        private void btnSphere_Click(object sender, EventArgs e)
        {
            s = StaticShapes.GenerateSphere(GetCanvasCenter(), 10, 50);

            resetAndGenerate();
        }

        private void btnCone_Click(object sender, EventArgs e)
        {
            s = StaticShapes.GenerateCone(GetCanvasCenter(), 50);
            resetAndGenerate();
        }

        private void btnSandClock_Click(object sender, EventArgs e)
        {
            s = StaticShapes.GenerateSandClock(GetCanvasCenter(), 50);

            resetAndGenerate();
        }
    }
}
