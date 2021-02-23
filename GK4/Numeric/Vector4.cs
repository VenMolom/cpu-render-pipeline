using System;
using System.Drawing;

namespace GK4
{
    public struct Vector4
    {
        public Vector4(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
            W = 0;
        }

        public Vector4(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public Vector4(Vector3 v, float w = 0)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }

        public static Vector4 Up => new Vector4(0, 1f, 0);
        public float Length => (float)Math.Sqrt(X * X + Y * Y + Z * Z + W * W);
        public Vector4 Normalized => Length == 0 ? this : this / Length;
        public float W { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public static Vector4 Cross(Vector4 v1, Vector4 v2)
        {
            return new Vector4(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }

        public static float Dot(Vector4 v1, Vector4 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z + v1.W * v2.W;
        }

        public static Vector4 operator -(Vector4 v1, Vector4 v2)
        {
            return new Vector4(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z, v1.W - v2.W);
        }

        public static Vector4 operator *(Vector4 v, float a)
        {
            return new Vector4(v.X * a, v.Y * a, v.Z * a, v.W * a);
        }

        public static Vector4 operator /(Vector4 v, float a)
        {
            return v * (1f / a);
        }

        public static Vector4 operator +(Vector4 v1, Vector4 v2)
        {
            return new Vector4(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z, v1.W + v2.W);
        }

        public PointF ToPointF()
        {
            return new PointF(X, Y);
        }

        public Vector4 ToScreenCoords(Size size)
        {
            return new Vector4((X / W + 1) * (size.Width - 1) / 2, (-Y / W + 1) * (size.Height - 1) / 2, (Z / W + 1) / 2);
        }
    }
}