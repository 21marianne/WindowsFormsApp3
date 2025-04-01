using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public static class FiguraFactory
    {
        public static Figura CrearFigura(string tipo, Color color, int x, int y)
        {
            if (tipo == "Rectangulo")
            {
                return new Rectangulo(color, x, y);
            }
            return null;
        }
    }
}