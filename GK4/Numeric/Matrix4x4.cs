using System;

namespace GK4
{
    public struct Matrix4x4
    {
        private readonly float m11;
        private readonly float m12;
        private readonly float m13;
        private readonly float m14;
        private readonly float m21;
        private readonly float m22;
        private readonly float m23;
        private readonly float m24;
        private readonly float m31;
        private readonly float m32;
        private readonly float m33;
        private readonly float m34;
        private readonly float m41;
        private readonly float m42;
        private readonly float m43;
        private readonly float m44;

        public Matrix4x4(float m11, float m12, float m13, float m14,
            float m21, float m22, float m23, float m24,
            float m31, float m32, float m33, float m34,
            float m41, float m42, float m43, float m44)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m14 = m14;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m24 = m24;
            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;
            this.m34 = m34;
            this.m41 = m41;
            this.m42 = m42;
            this.m43 = m43;
            this.m44 = m44;
        }

        public static Matrix4x4 Identity => new Matrix4x4(
            1f, 0, 0, 0,
            0, 1f, 0, 0,
            0, 0, 1f, 0,
            0, 0, 0, 1f);

        public static bool Inverse(Matrix4x4 m, out Matrix4x4 result)
        {
            float m1 = m.m11;
            float m2 = m.m12;
            float m3 = m.m13;
            float m4 = m.m14;
            float m5 = m.m21;
            float m6 = m.m22;
            float m7 = m.m23;
            float m8 = m.m24;
            float m9 = m.m31;
            float m10 = m.m32;
            float m11 = m.m33;
            float m12 = m.m34;
            float m13 = m.m41;
            float m14 = m.m42;
            float m15 = m.m43;
            float m16 = m.m44;
            float num = m11 * m16 - m12 * m15;
            float num2 = m10 * m16 - m12 * m14;
            float num3 = m10 * m15 - m11 * m14;
            float num4 = m9 * m16 - m12 * m13;
            float num5 = m9 * m15 - m11 * m13;
            float num6 = m9 * m14 - m10 * m13;
            float num7 = m6 * num - m7 * num2 + m8 * num3;
            float num8 = 0f - (m5 * num - m7 * num4 + m8 * num5);
            float num9 = m5 * num2 - m6 * num4 + m8 * num6;
            float num10 = 0f - (m5 * num3 - m6 * num5 + m7 * num6);
            float num11 = m1 * num7 + m2 * num8 + m3 * num9 + m4 * num10;

            if (Math.Abs(num11) < float.Epsilon)
            {
                result = new Matrix4x4(
                    float.NaN, float.NaN, float.NaN, float.NaN,
                    float.NaN, float.NaN, float.NaN, float.NaN,
                    float.NaN, float.NaN, float.NaN, float.NaN,
                    float.NaN, float.NaN, float.NaN, float.NaN);
                return false;
            }
            result = new Matrix4x4();
            float num12 = 1f / num11;
            float num13 = m7 * m16 - m8 * m15;
            float num14 = m6 * m16 - m8 * m14;
            float num15 = m6 * m15 - m7 * m14;
            float num16 = m5 * m16 - m8 * m13;
            float num17 = m5 * m15 - m7 * m13;
            float num18 = m5 * m14 - m6 * m13;
            float num19 = m7 * m12 - m8 * m11;
            float num20 = m6 * m12 - m8 * m10;
            float num21 = m6 * m11 - m7 * m10;
            float num22 = m5 * m12 - m8 * m9;
            float num23 = m5 * m11 - m7 * m9;
            float num24 = m5 * m10 - m6 * m9;

            result = new Matrix4x4(
                num7 * num12, (0f - (m2 * num - m3 * num2 + m4 * num3)) * num12, (m2 * num13 - m3 * num14 + m4 * num15) * num12, (0f - (m2 * num19 - m3 * num20 + m4 * num21)) * num12,
                num8 * num12, (m1 * num - m3 * num4 + m4 * num5) * num12, (0f - (m1 * num13 - m3 * num16 + m4 * num17)) * num12, (m1 * num19 - m3 * num22 + m4 * num23) * num12,
                num9 * num12, (0f - (m1 * num2 - m2 * num4 + m4 * num6)) * num12, (m1 * num14 - m2 * num16 + m4 * num18) * num12, (0f - (m1 * num20 - m2 * num22 + m4 * num24)) * num12,
                num10 * num12, (m1 * num3 - m2 * num5 + m3 * num6) * num12, (0f - (m1 * num15 - m2 * num17 + m3 * num18)) * num12, (m1 * num21 - m2 * num23 + m3 * num24) * num12);

            return true;
        }

        public static Matrix4x4 operator *(Matrix4x4 m1, Matrix4x4 m2)
        {
            return new Matrix4x4(
                m1.m11 * m2.m11 + m1.m12 * m2.m21 + m1.m13 * m2.m31 + m1.m14 * m2.m41,
                m1.m11 * m2.m12 + m1.m12 * m2.m22 + m1.m13 * m2.m32 + m1.m14 * m2.m42,
                m1.m11 * m2.m13 + m1.m12 * m2.m23 + m1.m13 * m2.m33 + m1.m14 * m2.m43,
                m1.m11 * m2.m14 + m1.m12 * m2.m24 + m1.m13 * m2.m34 + m1.m14 * m2.m44,

                m1.m21 * m2.m11 + m1.m22 * m2.m21 + m1.m23 * m2.m31 + m1.m24 * m2.m41,
                m1.m21 * m2.m12 + m1.m22 * m2.m22 + m1.m23 * m2.m32 + m1.m24 * m2.m42,
                m1.m21 * m2.m13 + m1.m22 * m2.m23 + m1.m23 * m2.m33 + m1.m24 * m2.m43,
                m1.m21 * m2.m14 + m1.m22 * m2.m24 + m1.m23 * m2.m34 + m1.m24 * m2.m44,

                m1.m31 * m2.m11 + m1.m32 * m2.m21 + m1.m33 * m2.m31 + m1.m34 * m2.m41,
                m1.m31 * m2.m12 + m1.m32 * m2.m22 + m1.m33 * m2.m32 + m1.m34 * m2.m42,
                m1.m31 * m2.m13 + m1.m32 * m2.m23 + m1.m33 * m2.m33 + m1.m34 * m2.m43,
                m1.m31 * m2.m14 + m1.m32 * m2.m24 + m1.m33 * m2.m34 + m1.m34 * m2.m44,

                m1.m41 * m2.m11 + m1.m42 * m2.m21 + m1.m43 * m2.m31 + m1.m44 * m2.m41,
                m1.m41 * m2.m12 + m1.m42 * m2.m22 + m1.m43 * m2.m32 + m1.m44 * m2.m42,
                m1.m41 * m2.m13 + m1.m42 * m2.m23 + m1.m43 * m2.m33 + m1.m44 * m2.m43,
                m1.m41 * m2.m14 + m1.m42 * m2.m24 + m1.m43 * m2.m34 + m1.m44 * m2.m44);
        }

        public static Vector4 operator *(Matrix4x4 m, Vector4 v)
        {
            return new Vector4(
                m.m11 * v.X + m.m12 * v.Y + m.m13 * v.Z + m.m14 * v.W,
                m.m21 * v.X + m.m22 * v.Y + m.m23 * v.Z + m.m24 * v.W,
                m.m31 * v.X + m.m32 * v.Y + m.m33 * v.Z + m.m34 * v.W,
                m.m41 * v.X + m.m42 * v.Y + m.m43 * v.Z + m.m44 * v.W);
        }

        public static Matrix4x4 RotationX(float angle)
        {
            return new Matrix4x4(
                1f, 0, 0, 0,
                0, (float)Math.Cos(angle), -(float)Math.Sin(angle), 0,
                0, (float)Math.Sin(angle), (float)Math.Cos(angle), 0,
                0, 0, 0, 1f);
        }

        public static Matrix4x4 RotationY(float angle)
        {
            return new Matrix4x4(
                (float)Math.Cos(angle), 0, -(float)Math.Sin(angle), 0,
                0, 1f, 0, 0,
                (float)Math.Sin(angle), 0, (float)Math.Cos(angle), 0,
                0, 0, 0, 1f);
        }

        public static Matrix4x4 RotationZ(float angle)
        {
            return new Matrix4x4(
                (float)Math.Cos(angle), -(float)Math.Sin(angle), 0, 0,
                (float)Math.Sin(angle), (float)Math.Cos(angle), 0, 0,
                0, 0, 1f, 0,
                0, 0, 0, 1f);
        }

        public static Matrix4x4 Scale(Vector3 scale)
        {
            return new Matrix4x4(
                scale.X, 0, 0, 0,
                0, scale.Y, 0, 0,
                0, 0, scale.Z, 0,
                0, 0, 0, 1);
        }

        public static Matrix4x4 Scale(float x, float y, float z)
        {
            return new Matrix4x4(
                x, 0, 0, 0,
                0, y, 0, 0,
                0, 0, z, 0,
                0, 0, 0, 1);
        }

        public static Matrix4x4 Translation(Vector3 translation)
        {
            return new Matrix4x4(
                1f, 0, 0, translation.X,
                0, 1f, 0, translation.Y,
                0, 0, 1f, translation.Z,
                0, 0, 0, 1f);
        }

        public static Matrix4x4 Transpose(Matrix4x4 m)
        {
            return new Matrix4x4(
                m.m11, m.m21, m.m31, m.m41,
                m.m12, m.m22, m.m32, m.m42,
                m.m13, m.m23, m.m33, m.m43,
                m.m14, m.m24, m.m34, m.m44);
        }

        public static Matrix4x4 View(Vector3 pos, Vector3 front)
        {
            var d = front.Normalized;
            var r = Vector3.Cross(Vector3.UWorld, d).Normalized;
            var u = Vector3.Cross(d, r);
            return new Matrix4x4(
                r.X, r.Y, r.Z, 0,
                u.X, u.Y, u.Z, 0,
                d.X, d.Y, d.Z, 0,
                0, 0, 0, 1f)
                * Translation(-pos);
        }

        internal static Matrix4x4 Projection(float fov, float far, float near, float aspect)
        {
            float ctg = 1f / (float)Math.Tan(fov / 2f);
            return new Matrix4x4(
                ctg / aspect, 0, 0, 0,
                0, ctg, 0, 0,
                0, 0, (far + near) / (far - near), -2f * far * near / (far - near),
                0, 0, 1f, 0);
        }
    }
}