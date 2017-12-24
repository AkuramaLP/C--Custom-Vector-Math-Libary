using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math.Vector;
using SysMath = System.Math;

namespace Math.Circle
{
    public class PointCheck
    {
        public static double CircleCheck(Vector2 circle, Vector2 checkPoint, float radius)
        {
            double result = 0f;
            double sqrtRadius = SysMath.Pow(radius, 2);

            result = SysMath.Pow(checkPoint.x - circle.x, 2) + SysMath.Pow(checkPoint.y - circle.y, 2);

            if (result < sqrtRadius)
            {
                Console.WriteLine("Liegt innerhalb des Kreises");
            }
            else if (result == sqrtRadius)
            {
                Console.WriteLine("Liegt auf dem Kreis");
            }
            else if (result > sqrtRadius)
            {
                Console.WriteLine("Liegt außerhalb des Kreises");
            }

            //(x-xm)² + (y-ym)² = r²
            return result;
        }
    }
}
