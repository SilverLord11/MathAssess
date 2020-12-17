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
    }
}
