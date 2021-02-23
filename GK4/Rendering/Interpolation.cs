namespace GK4.Rendering
{
    public static class Interpolation
    {
        public static float Diff(float a1, float a2, float qDiff)
        {
            return (a2 - a1) * qDiff;
        }

        public static Vector3 Interpolate(Vector3 v1, Vector3 v2, float q, float w1, float w2, bool perspectiveCorrection)
        {
            if (perspectiveCorrection)
            {
                var qw1 = (1 - q) / w1;
                var qw2 = q / w2;
                return (v1 * qw1 + v2 * qw2) / (qw1 + qw2);
            }
            else
            {
                return v1 * (1 - q) + v2 * q;
            }
        }

        public static Vector2 Interpolate(Vector2 v1, Vector2 v2, float q, float w1, float w2, bool perspectiveCorrection)
        {
            if (perspectiveCorrection)
            {
                var qw1 = (1 - q) / w1;
                var qw2 = q / w2;
                return (v1 * qw1 + v2 * qw2) / (qw1 + qw2);
            }
            else
            {
                return v1 * (1 - q) + v2 * q;
            }
        }
    }
}