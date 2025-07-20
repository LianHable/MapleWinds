namespace MapleWinds.Numerics;

public struct Float3
{
    public float x;
    public float y;
    public float z;

    public Float3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static Float3 operator +(Float3 a, Float3 b)
    {
        return new Float3(a.x + b.x, a.y + b.y, a.z + b.z);
    }

    public static Float3 operator -(Float3 a, Float3 b)
    {
        return new Float3(a.x - b.x, a.y - b.y, a.z - b.z);
    }

    public static Float3 operator *(Float3 a, float scalar)
    {
        return new Float3(a.x * scalar, a.y * scalar, a.z * scalar);
    }

    public static Float3 operator *(float scalar, Float3 a)
    {
        return new Float3(a.x * scalar, a.y * scalar, a.z * scalar);
    }

    public static Float3 operator /(Float3 a, float scalar)
    {
        if (scalar == 0) throw new DivideByZeroException("Cannot divide by zero.");
        return new Float3(a.x / scalar, a.y / scalar, a.z / scalar);
    }
}

public struct Float2
{
    public float x;
    public float y;

    public Float2(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public static Float2 operator +(Float2 a, Float2 b)
    {
        return new Float2(a.x + b.x, a.y + b.y);
    }

    public static Float2 operator -(Float2 a, Float2 b)
    {
        return new Float2(a.x - b.x, a.y - b.y);
    }

    public static Float2 operator *(Float2 a, float scalar)
    {
        return new Float2(a.x * scalar, a.y * scalar);
    }

    public static Float2 operator *(float scalar, Float2 a)
    {
        return new Float2(a.x * scalar, a.y * scalar);
    }

    public static Float2 operator /(Float2 a, float scalar)
    {
        if (scalar == 0) throw new DivideByZeroException("Cannot divide by zero.");
        return new Float2(a.x / scalar, a.y / scalar);
    }
}

public struct Int3
{
    public int x;
    public int y;
    public int z;

    public Int3(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static Int3 operator +(Int3 a, Int3 b)
    {
        return new Int3(a.x + b.x, a.y + b.y, a.z + b.z);
    }

    public static Int3 operator -(Int3 a, Int3 b)
    {
        return new Int3(a.x - b.x, a.y - b.y, a.z - b.z);
    }

    public static Int3 operator *(Int3 a, int scalar)
    {
        return new Int3(a.x * scalar, a.y * scalar, a.z * scalar);
    }

    public static Int3 operator *(int scalar, Int3 a)
    {
        return new Int3(a.x * scalar, a.y * scalar, a.z * scalar);
    }

    public static Int3 operator /(Int3 a, int scalar)
    {
        if (scalar == 0) throw new DivideByZeroException("Cannot divide by zero.");
        return new Int3(a.x / scalar, a.y / scalar, a.z / scalar);
    }
}

public struct Int2
{
    public int x;
    public int y;

    public Int2(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public static Int2 operator +(Int2 a, Int2 b)
    {
        return new Int2(a.x + b.x, a.y + b.y);
    }

    public static Int2 operator -(Int2 a, Int2 b)
    {
        return new Int2(a.x - b.x, a.y - b.y);
    }

    public static Int2 operator *(Int2 a, int scalar)
    {
        return new Int2(a.x * scalar, a.y * scalar);
    }

    public static Int2 operator *(int scalar, Int2 a)
    {
        return new Int2(a.x * scalar, a.y * scalar);
    }

    public static Int2 operator /(Int2 a, int scalar)
    {
        if (scalar == 0) throw new DivideByZeroException("Cannot divide by zero.");
        return new Int2(a.x / scalar, a.y / scalar);
    }
}