using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector3
    {
        public float x, y, z;

        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }
        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }

        public static Vector3 operator *(Vector3 lhs, float v) 
        {
            return new Vector3(lhs.x * v, lhs.y * v, lhs.z * v);
        }

        public static Vector3 operator *(float v, Vector3 rhs)
        {
            return new Vector3(v * rhs.x, v * rhs.y, v * rhs.z);
        }

        public float Magnitude()
        {
            float result = (float)Math.Sqrt((x * x) + (y * y) + (z * z));
            return result;
        }

        public float Dot(Vector3 vector)
        {
            return (x * vector.x) + (y * vector.y) + (z * vector.z);
        }

        public static float Dot(Vector3 vector1, Vector3 vector2)
        {
            return (vector2.x * vector1.x) + (vector2.y * vector1.y) + (vector2.z * vector1.z);
        }

        public Vector3 Cross(Vector3 vector)
        {
            return new Vector3((y * vector.z) - (z * vector.y), (z * vector.x) - (x * vector.z), (x * vector.y) - (y * vector.x));
        }

        public static Vector3 Normalize(float x, float y, float z)
        {
            return new Vector3(x / x, y / y, z / z);
        }
    }
}
