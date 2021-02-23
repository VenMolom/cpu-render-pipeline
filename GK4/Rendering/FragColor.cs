using System;
using System.Drawing;

namespace GK4.Rendering
{
    public struct FragColor
    {
        public FragColor(float r, float g, float b)
        {
            R = r;
            G = g;
            B = b;
        }

        public FragColor(Color color)
        {
            R = color.R / 255f;
            G = color.G / 255f;
            B = color.B / 255f;
        }

        public static FragColor Black => new FragColor(0, 0, 0);
        public static FragColor White => new FragColor(1f, 1f, 1f);
        public float B { get; set; }
        public Color Color => Color.FromArgb((int)Math.Min(255, R * 255), (int)Math.Min(255, G * 255), (int)Math.Min(255, B * 255));
        public float G { get; set; }
        public float R { get; set; }

        public static FragColor operator *(FragColor c1, FragColor c2)
        {
            return new FragColor(c1.R * c2.R, c1.G * c2.G, c1.B * c2.B);
        }

        public static FragColor operator *(float d, FragColor c)
        {
            return new FragColor(d * c.R, d * c.G, d * c.B);
        }

        public static FragColor operator *(FragColor c, float d)
        {
            return d * c;
        }

        public static FragColor operator +(FragColor c1, FragColor c2)
        {
            return new FragColor(c1.R + c2.R, c1.G + c2.G, c1.B + c2.B);
        }
    }
}