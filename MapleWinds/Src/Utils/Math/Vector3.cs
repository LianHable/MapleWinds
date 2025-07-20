namespace MapleWinds.Numerics;

public class Vector3<T> where T : struct, INumber<T>
{
    public T X { get; set; }
    public T Y { get; set; }
    public T Z { get; set; }

    public Vector3(T x, T y, T z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Vector3<T> operator +(Vector3<T> a, Vector3<T> b) => new Vector3<T>(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

    public static Vector3<T> operator -(Vector3<T> a, Vector3<T> b) => new Vector3<T>(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

    public static Vector3<T> operator *(Vector3<T> a, T scalar) => new Vector3<T>(a.X * scalar, a.Y * scalar, a.Z * scalar);

    public static Vector3<T> operator *(T scalar, Vector3<T> a) => new Vector3<T>(a.X * scalar, a.Y * scalar, a.Z * scalar);

    public static Vector3<T> operator /(Vector3<T> a, T scalar)
    {
        if (scalar == T.Zero) throw new DivideByZeroException("Cannot divide by zero.");
        return new Vector3<T>(a.X / scalar, a.Y / scalar, a.Z / scalar);
    }

    public static explicit operator Vector3(Vector3<T> v) { return new Vector3(float.CreateChecked(v.X), float.CreateChecked(v.Y), float.CreateChecked(v.Z)); }
    public static explicit operator Vector3<T>(Vector3 v) { return new Vector3<T>(T.CreateChecked(v.X), T.CreateChecked(v.Y), T.CreateChecked(v.Z)); }
}