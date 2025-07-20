namespace MapleWinds.Numerics;

public class Vector2<T> where T : struct, INumber<T>
{
    public T X { get; set; }
    public T Y { get; set; }

    public Vector2(T x, T y)
    {
        X = x;
        Y = y;
    }

    public static Vector2<T> operator +(Vector2<T> a, Vector2<T> b) => new Vector2<T>(a.X + b.X, a.Y + b.Y);

    public static Vector2<T> operator -(Vector2<T> a, Vector2<T> b) => new Vector2<T>(a.X - b.X, a.Y - b.Y);

    public static Vector2<T> operator *(Vector2<T> a, T scalar) => new Vector2<T>(a.X * scalar, a.Y * scalar);

    public static Vector2<T> operator *(T scalar, Vector2<T> a) => new Vector2<T>(a.X * scalar, a.Y * scalar);

    public static Vector2<T> operator /(Vector2<T> a, T scalar)
    {
        if (scalar == T.Zero) throw new DivideByZeroException("Cannot divide by zero.");
        return new Vector2<T>(a.X / scalar, a.Y / scalar);
    }

    public static explicit operator Vector2(Vector2<T> v) { return new Vector2(float.CreateChecked(v.X), float.CreateChecked(v.Y)); }
    public static explicit operator Vector2<T>(Vector2 v) { return new Vector2<T>(T.CreateChecked(v.X), T.CreateChecked(v.Y)); }
}