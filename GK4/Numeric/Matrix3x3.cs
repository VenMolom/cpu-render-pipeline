namespace GK4
{
    public struct Matrix3x3
    {
        private readonly float m11;
        private readonly float m12;
        private readonly float m13;
        private readonly float m21;
        private readonly float m22;
        private readonly float m23;
        private readonly float m31;
        private readonly float m32;
        private readonly float m33;

        public Matrix3x3(float m11, float m12, float m13,
            float m21, float m22, float m23,
            float m31, float m32, float m33)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;
        }

        public static Vector3 operator *(Matrix3x3 m, Vector3 v)
        {
            return new Vector3(
                m.m11 * v.X + m.m12 * v.Y + m.m13 * v.Z,
                m.m21 * v.X + m.m22 * v.Y + m.m23 * v.Z,
                m.m31 * v.X + m.m32 * v.Y + m.m33 * v.Z);
        }

        public static Matrix3x3 TBN(Vector3 tangent, Vector3 binormal, Vector3 normal)
        {
            return new Matrix3x3(
                tangent.X, binormal.X, normal.X,
                tangent.Y, binormal.Y, normal.Y,
                tangent.Z, binormal.Z, normal.Z);
        }
    }
}