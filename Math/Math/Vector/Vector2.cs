using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Math
{
    namespace Vector
    {
        public class Vector2
        {
            public float x;
            public float y;

            public Vector2()
            {
                this.x = 0;
                this.y = 0;
            }

            public Vector2(float tX, float tY)
            {
                this.x = tX;
                this.y = tY;
            }

            public float Length()
            {
                float result = 0;

                result = (this.x * this.x) + (this.y * this.y);

                double store = System.Convert.ToDouble(result);
                result = (float)System.Math.Sqrt(store);

                return result;
            }

            public Point ConvertToPoint()
            {
                return new Point((int)this.x, (int)this.y);
            }
        }
    }
}
