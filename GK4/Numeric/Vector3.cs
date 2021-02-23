using GK4.Rendering;
using System;

namespace GK4
{
    public struct Vector3
    {
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3(Vector4 v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }

        public static Vector3 UWorld => new Vector3(0, 1f, 0);
        public float Length => (float)Math.Sqrt(X * X + Y * Y + Z * Z);
        public Vector3 Normalized => Length == 0 ? this : this / Length;
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public static Vector3 Cross(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }

        public static float Dot(Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static Vector3 FromNormalMap(DirectBitmap normalMap, Vector2 texCoords)
        {
            var color = normalMap.GetPixel(texCoords);

            return new Vector3(color.R * 2 - 1, color.G * 2 - 1, color.B * 2 - 1);
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector3 operator -(Vector3 v)
        {
            return new Vector3(-v.X, -v.Y, -v.Z);
        }

        public static Vector3 operator *(Vector3 v, float a)
        {
            return new Vector3(v.X * a, v.Y * a, v.Z * a);
        }

        public static Vector3 operator *(float a, Vector3 v)
        {
            return new Vector3(v.X * a, v.Y * a, v.Z * a);
        }

        public static Vector3 operator *(int a, Vector3 v)
        {
            return new Vector3(v.X * a, v.Y * a, v.Z * a);
        }

        public static Vector3 operator /(Vector3 v, float a)
        {
            return v * (1f / a);
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3 Reflect(Vector3 i, Vector3 n)
        {
            return i - (2.0f * Dot(n, i) * n);
        }
    }
}