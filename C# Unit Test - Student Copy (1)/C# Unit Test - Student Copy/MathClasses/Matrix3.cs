using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix3
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;
        private float v;

        public Matrix3()
        {
            m1 = 1; m2 = 0; m3 = 0;
            m4 = 0; m5 = 1; m6 = 0;
            m7 = 0; m8 = 0; m9 = 1;
        }
        public Matrix3(float v)
        {
            this.v = v;
        }

        public Matrix3(float v1, float v2, float v3, float v4, float v5, float v6, float v7, float v8, float v9)
        {
            m1 = v1; m2 = v2; m3 = v3;
            m4 = v4; m5 = v5; m6 = v6;
            m7 = v7; m8 = v8; m9 = v9;
        }

        public void Set(float a1, float a2, float a3, float a4, float a5, float a6, float a7, float a8, float a9)
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
        }

        public void Set(Matrix3 a)
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
        }


        public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
        {
            return new Matrix3(
            (lhs.m1 * rhs.m1) + (lhs.m4 * rhs.m2) + (lhs.m7 * rhs.m3), (lhs.m2 * rhs.m1) + (lhs.m5 * rhs.m2) + (lhs.m8 * rhs.m3), (lhs.m3 * rhs.m1) + (lhs.m6 * rhs.m2) + (lhs.m9 * rhs.m3),
            (lhs.m1 * rhs.m4) + (lhs.m4 * rhs.m5) + (lhs.m7 * rhs.m6), (lhs.m2 * rhs.m4) + (lhs.m5 * rhs.m5) + (lhs.m8 * rhs.m6), (lhs.m3 * rhs.m4) + (lhs.m6 * rhs.m5) + (lhs.m9 * rhs.m6),
            (lhs.m1 * rhs.m7) + (lhs.m4 * rhs.m8) + (lhs.m7 * rhs.m9), (lhs.m2 * rhs.m7) + (lhs.m5 * rhs.m8) + (lhs.m8 * rhs.m9), (lhs.m3 * rhs.m7) + (lhs.m6 * rhs.m8) + (lhs.m9 * rhs.m9));
        }

        public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        {
            return new Vector3((lhs.m1 * rhs.x) + (lhs.m4 * rhs.y) + (lhs.m7 * rhs.z), 
                               (lhs.m2 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m8 * rhs.z), 
                               (lhs.m3 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m9 * rhs.z));
        }

        public void SetRotateX(double radians)
        {
            Set(1, 0, 0,
            0, (float)Math.Cos(radians), (float)-Math.Sin(radians),
            0, (float)Math.Sin(radians), (float)Math.Cos(radians));
        }

        public Matrix3 RotateX(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateX(radians);

            Set(this * m);
            return m;
        }

        public void SetRotateY(double radians)
        {
            Set((float)Math.Cos(radians), 0, (float)Math.Sin(radians),
            0, 1, 0,
            (float)-Math.Sin(radians), 0, (float)Math.Cos(radians));
        }

        public Matrix3 RotateY(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateY(radians);

            Set(this * m);
            return m;
        }

        public void SetRotateZ(double radians)
        {
            Set((float)Math.Cos(radians), -(float)Math.Sin(radians), 0,
            (float)Math.Sin(radians), (float)Math.Cos(radians), 0,
            0, 0, 1);
        }

        public Matrix3 RotateZ(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateZ(radians);

            Set(this * m);
            return m;
        }

        public void SetTranslation(float x, float y)
        {
            Set((float)x + y, (float)x + y, (float)x + y,
                (float)x + y, (float)x + y, (float)x + y,
                (float)x + y, (float)x + y, (float)x + y);
        }

        public Matrix3 Scale(float width, float height, int v)
        {
            Matrix3 m = new Matrix3();
            m.SetScaled(width, height, v);

            Set(this * m);
            return m;
        }

        public Matrix3 Translate(float x, float y)
        {
            Matrix3 m = new Matrix3();
            m.SetTranslation(x, y);

            Set(this * m);
            return m;
        }

        public void SetScaled(float width, float height, int v)
        {
            Set((float)v + height + width, (float)v + height + width, (float)v + height + width,
                (float)v + height + width, (float)v + height + width, (float)v + height + width,
                (float)v + height + width, (float)v + height + width, (float)v + height + width);
        }
    }
}