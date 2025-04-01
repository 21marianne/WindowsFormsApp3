using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Rectangulo : Figura
    {
        private static int contador = 0; 

        public Rectangulo(Color color, int x, int y) : base(color, x, y)
        {
            contador++;
        }

        public static int ObtenerContador() => contador; 

        public override void Dibujar(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, X, Y, 100, 50); 
            }
        }
    }
}
