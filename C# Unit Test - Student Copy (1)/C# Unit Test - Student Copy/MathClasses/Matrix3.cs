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
            lhs.m1 * rhs.m1 + lhs.m4 * rhs.m2 + lhs.m7 * rhs.m3 +
            lhs.m8 * rhs.m6 + lhs.m5 * rhs.m5 + lhs.m2 * rhs.m4 +
            lhs.m6 * rhs.m8 + lhs.m3 * rhs.m7 + lhs.m9 * rhs.m9);
        }

        public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        {
            return new Vector3((lhs.m1 * rhs.x) + (lhs.m4 * rhs.y) + (lhs.m7 * rhs.z));
        }

        public void SetRotateX(double radians)
        {
            Set(1, 0, 0,
            0, (float)Math.Cos(radians), (float)-Math.Sin(radians),
            0, (float)Math.Sin(radians), (float)Math.Cos(radians));
        }

        public void RotateX(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateX(radians);

            Set(this * m);
        }

        public void SetRotateY(double radians)
        {
            Set((float)Math.Cos(radians), 0, (float)-Math.Sin(radians),
            0, 1, 0,
            (float)Math.Sin(radians), 0, (float)Math.Cos(radians));
        }

        public void RotateY(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateY(radians);

            Set(this * m);
        }

        public void SetRotateZ(double radians)
        {
            Set((float)Math.Cos(radians), (float)-Math.Sin(radians), 0,
            (float)Math.Sin(radians), (float)Math.Cos(radians), 0,
            0, 0, 1);
        }

        public void RotateZ(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateZ(radians);

            Set(this * m);
        }

        public void SetTranslation(float x, float y)
        {
            throw new NotImplementedException();
        }

        public void Scale(float width, float height, int v)
        {
            throw new NotImplementedException();
        }

        public void Translate(float x, float y)
        {
            throw new NotImplementedException();
        }

        public void SetScaled(float width, float height, int v)
        {
            throw new NotImplementedException();
        }
    }
}