using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix4
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16;

        public Matrix4()
        {
            m1 = 1; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = 1; m7 = 0; m8 = 0;
            m9 = 0; m10= 0; m11= 1; m12= 0;
            m13= 0; m14= 0; m15= 0; m16= 1;
        }
        public Matrix4(float v)
        {
            m1 = 1; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = 1; m7 = 0; m8 = 0;
            m9 = 0; m10 = 0; m11 = 1; m12 = 0;
            m13 = 0; m14 = 0; m15 = 0; m16 = 1;
        }
        public void Set(float a1, float a2, float a3, float a4, float a5, float a6, float a7, float a8, float a9, float a10, float a11, float a12, float a13, float a14, float a15, float a16)
        {
            m1 = a1;
            m2 = a2;
            m3 = a3;
            m4 = a4;
            m5 = a5;
            m6 = a6;
            m7 = a7;
            m8 = a8;
            m9 = a9;
            m10 = a10;
            m11 = a11;
            m12 = a12;
            m13 = a13;
            m14 = a14;
            m15 = a15;
            m16 = a16;
        }

        public void Set(Matrix4 a)
        {
            m1 = a.m1;
            m2 = a.m2;
            m3 = a.m3;
            m4 = a.m4;
            m5 = a.m5;
            m6 = a.m6;
            m7 = a.m7;
            m8 = a.m8;
            m9 = a.m9;
            m10 = a.m10;
            m11 = a.m11;
            m12 = a.m12;
            m13 = a.m13;
            m14 = a.m14;
            m15 = a.m15;
            m16 = a.m16;
        }


        public static Vector4 operator *(Matrix4 lhs, Vector4 rhs)
        {
            return new Vector4((lhs.m1 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m9 * rhs.z) + (lhs.m13 * rhs.w));
        }

        public void SetRotateX(double radians)
        {
            Set(1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, (float)Math.Cos(radians), (float)-Math.Sin(radians),
                0, 0, (float)Math.Sin(radians), (float)Math.Cos(radians));
        }

        public void RotateX(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateX(radians);

            Set(this * m);
        }

        public void SetRotateY(double radians)
        {
            Set((float)Math.Cos(radians), 0, 0, (float)-Math.Sin(radians),
                0, 1, 0, 0,
                0, 0, 1, 0,
                (float)Math.Sin(radians), 0, 0, (float)Math.Cos(radians));
        }

        public void RotateY(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateY(radians);

            Set(this * m);
        }

        public void SetRotateZ(double radians)
        {
            Set((float)Math.Cos(radians), (float)-Math.Sin(radians), 0, 0,
                (float)Math.Sin(radians), (float)Math.Cos(radians), 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1);
        }

        public void RotateZ(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateZ(radians);

            Set(this * m);
        }
        public static Matrix4 operator *(Matrix4 lhs, Matrix4 rhs)
        {
            return new Matrix4(
            lhs.m1 * rhs.m1 + lhs.m2 * rhs.m5 + lhs.m3 * rhs.m9 + lhs.m4 * rhs.m13 +
            lhs.m5 * rhs.m2 + lhs.m6 * rhs.m6 + lhs.m7 * rhs.m10 + lhs.m8 * rhs.m14 +
            lhs.m9 * rhs.m3 + lhs.m10 * rhs.m7 + lhs.m11 * rhs.m11 + lhs.m12 * rhs.m15 +
            lhs.m13 * rhs.m4 + lhs.m14 * rhs.m8 + lhs.m15 * rhs.m12 + lhs.m16 * rhs.m16);
        }
    }
}
}
