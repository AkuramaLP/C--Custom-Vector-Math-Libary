using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    namespace Vector
    {
        public class Vector3
        {
            public float x;
            public float y;
            public float z;

            /// <summary>
            /// Initializes the Vector 3 with 0 everywhere
            /// </summary>
            public Vector3()
            {
                x = 0;
                y = 0;
                z = 0;
            }

            /// <summary>
            /// Initializes the Vector 3 with predefinded values
            /// </summary>
            /// <param name="tX">the x-value for the vector 3</param>
            /// <param name="tY">the y-value for the vector 3</param>
            /// <param name="tZ">the z-value for the vector 3</param>
            public Vector3(float tX, float tY, float tZ)
            {
                this.x = tX;
                this.y = tY;
                this.z = tZ;
            }

            /// <summary>
            /// Returenes the length of the vector 3 as a float
            /// </summary>
            /// <returns>the length of the Vector</returns>
            public float Length()
            {
                float result = 0;

                result = (this.x * this.x) + (this.y * this.y) + (this.z * this.z);

                double step = System.Convert.ToDouble(result);
                step = System.Math.Sqrt(step);

                result = (float)step;

                return result;
            }

            public static Vector3 operator + (Vector3 vec1, Vector3 vec2)
            {
                return new Vector3(vec1.x + vec2.x, vec1.y + vec2.y, vec1.z + vec2.z);
            }
        }
    }
}
