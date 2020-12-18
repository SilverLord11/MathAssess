using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector4
    {
        private object p;
        public float y;
        public float z;
        public float x;
        public float w;

        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        public Vector4()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 0;
        }

        public Vector4(object p)
        {
            this.p = p;
        }

        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        }

        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        }

        public static Vector4 operator *(Vector4 lhs, float scale)
        {
            return new Vector4(lhs.x * scale, lhs.y * scale, lhs.z * scale, lhs.w * scale);
        }

        public static Vector4 operator *(float v, Vector4 rhs)
        {
            return new Vector4(v * rhs.x, v * rhs.y, v * rhs.z, v * rhs.w);
        }
        public Vector4 Cross(Vector4 vector)
        {
            return new Vector4((x * vector.w) - (w * vector.x), (y * vector.z) - (z * vector.y), (z * vector.x) - (x * vector.z), (x * vector.y) - (y * vector.x));
        }
        public float Magnitude()
        {
            float result = (float)Math.Sqrt((x * x) + (y * y) + (z * z) + (w * w));
            return result;
        }

        public float Dot(Vector4 vector)
        {
            return (x * vector.x) + (y * vector.y) + (z * vector.z) + (w * vector.w);
        }

        public static float Dot(Vector4 vector1, Vector4 vector2)
        {
            return (vector2.x * vector1.x) + (vector2.y * vector1.y) + (vector2.z * vector1.z) + (vector2.w - vector1.w);
        }

        public static Vector4 Normalize(float x, float y, float z, float w)
        {
            return new Vector4(x / x, y / y, z / z, w / w);
        }
    }
}
