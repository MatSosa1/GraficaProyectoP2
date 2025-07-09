using ProyectoGrafica_3D.src.utils;
using Shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrafica_3D.src
{
    static class StaticShapes
    {
        public static Shape3D GenerateCube(PointF center, int size)
        {
            return new Shape3D(
                4,
                center,
                new List<int>() { size, size },
                size
            );
        }

        public static Shape3D GenerateSphere(PointF center, int stepsBySide, int radius)
        {
            double stepSize = (double)2 * radius / (stepsBySide - 1);
            var sizes = Interpolate.ReverseValues(Interpolate.InterpolateGradualData(stepsBySide, stepSize));
            sizes.AddRange(Interpolate.InterpolateGradualData(stepsBySide, stepSize));

            return new Shape3D(
                8,  // De 8 para arriba (mi pc no da)
                center,
                sizes,
                stepSize
            );
        }

        public static Shape3D GenerateCone(PointF center, int size)
        {
            return new Shape3D(
                8,  // De 8 para arriba (mi pc no da)
                center,
                new List<int>() { size, 0 },
                size
            );
        }
    }
}
