namespace GK4
{
    public struct Vector2
    {
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float X { get; set; }
        public float Y { get; set; }

        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vector2 operator -(Vector2 v)
        {
            return new Vector2(-v.X, -v.Y);
        }

        public static Vector2 operator *(Vector2 v, float a)
        {
            return new Vector2(v.X * a, v.Y * a);
        }

        public static Vector2 operator *(float a, Vector2 v)
        {
            return new Vector2(v.X * a, v.Y * a);
        }

        public static Vector2 operator /(Vector2 v, float a)
        {
            return v * (1f / a);
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }
    }
}