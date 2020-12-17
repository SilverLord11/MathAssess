using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector4
    {
        public float x1, y1, z1, w1;
        private float v1;
        private float v2;
        private float v3;
        private float v4;
        private object p;
        internal float y;
        internal float z;
        internal float x;
        internal float w;

        public Vector4(float v1, float v2, float v3, float v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }
        public Vector4()
        {
            x1 = 0;
            y1 = 0;
            z1 = 0;
            w1 = 0;
        }

        public Vector4(object p)
        {
            this.p = p;
        }

        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.x1 + rhs.x1, lhs.y1 + rhs.y1, lhs.z1 + rhs.z1, lhs.w1 + rhs.w1);
        }

        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.x1 - rhs.x1, lhs.y1 - rhs.y1, lhs.z1 - rhs.z1, lhs.w1 - rhs.w1);
        }

        public static Vector4 operator *(Vector4 lhs, float scale)
        {
            return new Vector4(lhs.x1 * scale, lhs.y1 * scale, lhs.z1 * scale, lhs.w1 * scale);
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
