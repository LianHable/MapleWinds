namespace MapleWinds;

public static class Math
{
    public const float PI = 3.14159265358979323846f;
    public const float E = 2.71828182845904523536f;

    // [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int FloorToInt(float value) { return (int)System.Math.Floor(value); }

    // [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int CeilingToInt(float value) { return (int)System.Math.Ceiling(value); }

    // [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int RoundToInt(float value) { return (int)System.Math.Round(value); }

    // [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float Clamp(float value, float min, float max)
    {
        if (value < min) return min;
        if (value > max) return max;
        return value;
    }

    // [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float Lerp(float a, float b, float t) { return a + (b - a) * Clamp(t, 0f, 1f); }

    // [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float SmoothStep(float a, float b, float t) { t = Clamp(t, 0f, 1f); return Lerp(a, b, t * t * (3f - 2f * t)); }

    // [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float Distance(float x1, float y1, float x2, float y2)
    {
        float dx = x2 - x1;
        float dy = y2 - y1;
        return MathF.Sqrt(dx * dx + dy * dy);
    }
}