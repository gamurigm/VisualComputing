using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjPanalAbejas
{
    internal class Hexagon
    {
        public float SideLength { get; }
        public PointF[] Points { get; private set; }

        public Hexagon(float sideLength)
        {
            SideLength = sideLength;
            Points = new PointF[6];
            CalculatePoints(0, 0);
        }

        public void CalculatePoints(float offsetX, float offsetY)
        {
            float a = SideLength * (float)Math.Sqrt(3) / 2;

            Points[0] = new PointF(offsetX + 0.5f * SideLength, offsetY);
            Points[1] = new PointF(offsetX + 1.5f * SideLength, offsetY);
            Points[2] = new PointF(offsetX + 2 * SideLength, offsetY + a);
            Points[3] = new PointF(offsetX + 1.5f * SideLength, offsetY + 2 * a);
            Points[4] = new PointF(offsetX + 0.5f * SideLength, offsetY + 2 * a);
            Points[5] = new PointF(offsetX, offsetY + a);
        }

        public void Draw(Graphics g, float offsetX, float offsetY)
        {
            CalculatePoints(offsetX, offsetY);
            Brush fillBrush = new SolidBrush(Color.FromArgb(255, 255, 153, 0)); 
            Pen borderPen = new Pen(Color.Black,1);

            g.FillPolygon(fillBrush, Points);
            g.DrawPolygon(borderPen, Points);
        }
    }
}

