using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math.Vector;
using Math.Circle;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3 vector4 = new Vector3(1, 2, 3);
            Vector3 newVector4 = new Vector3(3, 2, 1);
            float length = vector4.Length();
            Console.WriteLine(length);

            vector4 = vector4 + newVector4;
            Console.WriteLine(vector4.x +  "" + vector4.y + "" + vector4.z);

            Vector2 vector3 = new Vector2(1, 2);
            Console.WriteLine(vector3.ConvertToPoint());

            Vector2 middlePoint = new Vector2(0f, 0f);
            Vector2 checkPoint = new Vector2(2f, 1f);
             
            Console.WriteLine(PointCheck.CircleCheck(middlePoint, checkPoint, 3));
            Console.ReadLine();
        }
    }
}
