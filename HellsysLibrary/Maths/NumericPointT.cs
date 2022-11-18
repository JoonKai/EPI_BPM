using System;

namespace HellsysLibrary.Maths
{
    public class NumericPoint<T> : IComparable, ICloneable where T : IComparable
    {
        public T X { get; set; }
        public T Y { get; set; }
        public NumericPoint()
        {
        }

        public NumericPoint(T x, T y)
        {
            X = x;
            Y = y;
        }
        public void Set(T x , T y)
        {
            X = x;
            Y = y;
        }
        public NumericPoint<T> Swap() => new NumericPoint<T>() { X = Y, Y = X };
        /// <summary>
        /// 목적지의 포인트 값 복사
        /// </summary>
        /// <param name="dest"></param>
        public void CopyTo(NumericPoint<T> dest)
        {
            dest.X = X;
            dest.Y = Y;
        }
        /// <summary>
        /// 출발지의 포인트 값 복사
        /// </summary>
        /// <param name="from"></param>
        public void CopyFrom(NumericPoint<T> from)
        {
            X = from.X;
            Y = from.Y;
        }
        public object Clone()=> this.MemberwiseClone();

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

    }
}