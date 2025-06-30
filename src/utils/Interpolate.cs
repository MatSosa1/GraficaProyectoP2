using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrafica_3D.src.utils
{
    public static class Interpolate
    {
        public static List<int> InterpolateLinearData(int cant, int steps)
        {
            var list = new List<int>();
            int i;

            for (i = 0; i < cant; i++)
                list.Add(i * steps);

            return list;
        }

        public static List<int> InterpolateGradualData(int cant, int steps)
        {
            var list = new List<int>();
            double radius = (cant - 1) * steps;

            for (int i = 0; i < cant; i++)
            {
                double x = i * steps;
                double y = Math.Sqrt(radius * radius - x * x); // y = sqrt(r^2 - x^2)
                list.Add((int)y);
            }

            return list;
        }

        public static List<int> ReverseValues(List<int> lista)
        {
            var newList = new List<int>();

            for (int i = lista.Count - 1; i >= 0; i--)
                newList.Add(lista[i]);

            return newList;
        }
    }
}
