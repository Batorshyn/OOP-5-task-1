using System;
using System.Collections.Generic;
using System.Text;

namespace SquareApp
{
    public interface IGeometricFigure<T>
    {
        double Area();
        double Perimeter();
    }

    public class TSquare<T> : IGeometricFigure<T>, IComparable<TSquare<T>> where T : struct, IComparable
    {
        private T side;

        public TSquare()
        {
            side = default(T);
        }

        public TSquare(T _side)
        {
            side = _side;
        }

        public TSquare(TSquare<T> other)
        {
            this.side = other.side;
        }

        public T Side
        {
            get { return side; }
            set { side = value; }
        }

        public override string ToString()
        {
            return $"[Квадрат, сторона = {side}]";
        }
        
        public double Area()
        {
            double s = Convert.ToDouble(side);
            return s * s;
        }
        public double Perimeter()
        {
            double s = Convert.ToDouble(side);
            return 4 * s;
        }

        public int CompareTo(TSquare<T> other)
        {
            double s1 = Convert.ToDouble(this.side);
            double s2 = Convert.ToDouble(other.side);
            return s1.CompareTo(s2);
        }

        public static TSquare<T> operator +(TSquare<T> sq1, TSquare<T> sq2)
        {
            dynamic s1 = sq1.side;
            dynamic s2 = sq2.side;
            return new TSquare<T>(s1 + s2);
        }

        public static TSquare<T> operator -(TSquare<T> sq1, TSquare<T> sq2)
        {
            dynamic s1 = sq1.side;
            dynamic s2 = sq2.side;
            dynamic result = s1 - s2;

            if (result < 0) result = 0;
            return new TSquare<T>(result);
        }

        public static TSquare<T> operator *(TSquare<T> sq, T multiplier)
        {
            dynamic s1 = sq.side;
            dynamic mult = multiplier;
            return new TSquare<T>(s1 * mult);
        }
    }
}
