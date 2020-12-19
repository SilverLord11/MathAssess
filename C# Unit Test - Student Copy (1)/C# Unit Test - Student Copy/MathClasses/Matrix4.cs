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
        private float v;

        public Matrix4()
        {
            m1 = 1; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = 1; m7 = 0; m8 = 0;
            m9 = 0; m10= 0; m11= 1; m12= 0;
            m13= 0; m14= 0; m15= 0; m16= 1;
        }

        public Matrix4(float v1, float v2, float v3, float v4, float v5, float v6, float v7, float v8, float v9, float v10, float v11, float v12, float v13, float v14, float v15, float v16)
        {
            m1 = v1; m2 = v2; m3 = v3; m4 = v4;
            m5 = v5; m6 = v6; m7 = v7; m8 = v8;
            m9 = v9; m10=v10; m11=v11; m12=v12;
            m13=v13; m14=v14; m15=v15; m16=v16;
        }

        public Matrix4(float v)
        {
            this.v = v;
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
            return new Vector4((lhs.m1 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m9 * rhs.z) + (lhs.m13 * rhs.w), 
                               (lhs.m2 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m10 * rhs.z) + (lhs.m14 * rhs.w), 
                               (lhs.m3 * rhs.x) + (lhs.m7 * rhs.y) + (lhs.m11 * rhs.z) + (lhs.m15 * rhs.w), 
                               (lhs.m4 * rhs.x) + (lhs.m8 * rhs.y) + (lhs.m12 * rhs.z) + (lhs.m16 * rhs.w));
        }

        public void SetRotateX(double radians)
        {
            Set(1, 0, 0, 0,
                0, (float)Math.Cos(radians), (float)-Math.Sin(radians), 0,
                0, (float)Math.Sin(radians), (float)Math.Cos(radians), 0,
                0, 0, 0, 1);
        }

        public Matrix4 RotateX(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateX(radians);

            Set(this * m);
            return m;
        }

        public void SetRotateY(double radians)
        {
            Set((float)Math.Cos(radians), 0, (float)Math.Sin(radians), 0,
                0, 1, 0, 0,
                (float)-Math.Sin(radians), 0, (float)Math.Cos(radians), 0,
                0, 0, 0, 1);
        }

        public Matrix4 RotateY(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateY(radians);

            Set(this * m);
            return m;
        }

        public void SetRotateZ(double radians)
        {
            Set((float)Math.Cos(radians), (float)-Math.Sin(radians), 0, 0,
                (float)Math.Sin(radians), (float)Math.Cos(radians), 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1);
        }

        public Matrix4 RotateZ(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateZ(radians);

            Set(this * m);
            return m;
        }

        public static Matrix4 operator *(Matrix4 lhs, Matrix4 rhs)
        {

            return new Matrix4(
            (lhs.m1 * rhs.m1) + (lhs.m5 * rhs.m2) + (lhs.m9 * rhs.m3) + (lhs.m13 * rhs.m4), (lhs.m2 * rhs.m1) + (lhs.m6 * rhs.m2) + (lhs.m10 * rhs.m3) + (lhs.m14 * rhs.m4), (lhs.m3 * rhs.m1) + (lhs.m7 * rhs.m2) + (lhs.m11 * rhs.m3) + (lhs.m15 * rhs.m4), (lhs.m4 * rhs.m1) + (lhs.m8 * rhs.m2) + (lhs.m12 * rhs.m3) + (lhs.m16 * rhs.m4),
            (lhs.m1 * rhs.m5) + (lhs.m5 * rhs.m6) + (lhs.m9 * rhs.m7) + (lhs.m13 * rhs.m8), (lhs.m2 * rhs.m5) + (lhs.m6 * rhs.m6) + (lhs.m10 * rhs.m7) + (lhs.m14 * rhs.m8), (lhs.m3 * rhs.m5) + (lhs.m7 * rhs.m6) + (lhs.m11 * rhs.m7) + (lhs.m15 * rhs.m8), (lhs.m4 * rhs.m5) + (lhs.m8 * rhs.m6) + (lhs.m12 * rhs.m7) + (lhs.m16 * rhs.m8),
            (lhs.m1 * rhs.m9) + (lhs.m5 * rhs.m10) + (lhs.m9 * rhs.m11) + (lhs.m13 * rhs.m12), (lhs.m2 * rhs.m9) + (lhs.m6 * rhs.m10) + (lhs.m10 * rhs.m11) + (lhs.m14 * rhs.m12), (lhs.m3 * rhs.m9) + (lhs.m7 * rhs.m10) + (lhs.m11 * rhs.m11) + (lhs.m15 * rhs.m12), (lhs.m4 * rhs.m9) + (lhs.m8 * rhs.m10) + (lhs.m12 * rhs.m11) + (lhs.m16 * rhs.m12),
            (lhs.m1 * rhs.m13) + (lhs.m5 * rhs.m14) + (lhs.m9 * rhs.m15) + (lhs.m13 * rhs.m16), (lhs.m2 * rhs.m13) + (lhs.m6 * rhs.m14) + (lhs.m10 * rhs.m15) + (lhs.m14 * rhs.m16), (lhs.m3 * rhs.m13) + (lhs.m7 * rhs.m14) + (lhs.m11 * rhs.m15) + (lhs.m15 * rhs.m16), (lhs.m4 * rhs.m13) + (lhs.m8 * rhs.m14) + (lhs.m12 * rhs.m15) + (lhs.m16 * rhs.m16));
        }
        public void SetTranslation(float x, float y)
        {
            Set((float)x + y, (float)x + y, (float)x + y, (float)x + y,
                (float)x + y, (float)x + y, (float)x + y, (float)x + y,
                (float)x + y, (float)x + y, (float)x + y, (float)x + y,
                (float)x + y, (float)x + y, (float)x + y, (float)x + y);
        }

        public Matrix4 Scale(float width, float height, int v)
        {
            Matrix4 m = new Matrix4();
            m.SetScaled(width, height, v);

            Set(this * m);
            return m;
        }

        public Matrix4 Translate(float x, float y)
        {
            Matrix4 m = new Matrix4();
            m.SetTranslation(x, y);

            Set(this * m);
            return m;
        }

        public void SetScaled(float width, float height, int v)
        {
            Set((float)v + height + width, (float)v + height + width, (float)v + height + width, (float)v + height + width,
                (float)v + height + width, (float)v + height + width, (float)v + height + width, (float)v + height + width,
                (float)v + height + width, (float)v + height + width, (float)v + height + width, (float)v + height + width,
                (float)v + height + width, (float)v + height + width, (float)v + height + width, (float)v + height + width);
        }
    }
}

