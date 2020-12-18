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
            return new Vector4((y * vector.z) - (z * vector.y), (z * vector.x) - (x * vector.z), (y * vector.x) - (x * vector.y), (x * vector.w) - (w * vector.x));
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

        public Vector4 Normalize()
        {
            return new Vector4(x / x, y / y, z / z, w / w);
        }
    }
}
