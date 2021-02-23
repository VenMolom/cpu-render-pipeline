using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace GK4.Rendering
{
    public class DirectBitmap : IDisposable
    {
        public DirectBitmap(int width, int height)
        {
            if (height == 0) height = 1;

            Width = width;
            Height = height;
            Bits = new Int32[width * height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
        }

        public DirectBitmap(string filename)
        {
            var bitmap = new Bitmap(filename);

            Width = bitmap.Width;
            Height = bitmap.Height;
            Bits = new Int32[Width * Height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(Width, Height, Width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());

            using (Graphics g = Graphics.FromImage(Bitmap))
            {
                g.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            }
        }

        public Bitmap Bitmap { get; private set; }
        public Int32[] Bits { get; private set; }
        public bool Disposed { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            Bitmap.Dispose();
            BitsHandle.Free();
        }

        public FragColor GetPixel(int x, int y)
        {
            int index = x + (y * Width);
            int col = Bits[index];
            return new FragColor(Color.FromArgb(col));
        }

        public FragColor GetPixel(Vector2 vector)
        {
            var x = (vector.X > 1f || vector.X < 0) ? 0 : vector.X;
            var y = (vector.Y > 1f || vector.Y < 0) ? 0 : vector.Y;

            return GetPixel((int)(x * (Width - 1)), (int)(y * (Height - 1)));
        }

        public void SetPixel(int x, int y, FragColor color)
        {
            int index = x + (y * Width);
            int col = color.Color.ToArgb();

            Bits[index] = col;
        }
    }
}