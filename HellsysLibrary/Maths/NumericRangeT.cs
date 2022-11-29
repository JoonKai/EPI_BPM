using System;

namespace HellsysLibrary.Maths
{
    public class NumericRange<T> : IComparable, ICloneable where T : IComparable
    {

        public T Begin { get; set; }
        public T End { get; set; }
        public bool InclusiveBegin { get; set; }
        public bool InclusiveEnd { get; set; }
        public NumericRange() : this(default (T), default(T))
        {
        }

        public NumericRange(T begin, T end, bool inclusiveBegin=true, bool inclusiveEnd=true)
        {
            Begin = begin;
            End = end;
            InclusiveBegin = inclusiveBegin;
            InclusiveEnd = inclusiveEnd;
        }
        public bool IsContain(T n, bool checkBoundary = true)
        {
            T obj1 = Begin;
            T obj2 = End;
            bool flag1 = InclusiveBegin;
            bool flag2 = InclusiveEnd;
            if(Begin.CompareTo((object)End) > 0)
            {
                obj1 = End;
                obj2 = Begin;
                flag1= InclusiveEnd;
                flag2= InclusiveBegin;
            }
            int num1 = n.CompareTo((object)obj1);
            int num2 = n.CompareTo((object)obj2);
            if (flag1 & flag2 || !checkBoundary)
                return 0 <= num1 && num2 <= 0;
            if (flag1)
                return 0 <= num1 && num2 < 0;
            return flag2 ? 0 < num1 && num2 <= 0 : 0 < num1 && num2 < 0;
        }
        public void Set(T begin, T end)
        {
            Begin = begin; 
            End = end;
        }

        public object Clone() => MemberwiseClone();

        public int CompareTo(object obj)
        {
            if (!(obj is NumericRange<T>))
                return 0;
            NumericRange<T> numericRange = obj as NumericRange<T>;
            T obj1 = this.Begin;
            int num = obj1.CompareTo((object)numericRange.Begin);
            if (num != 0)
                return num;
            obj1 = this.End;
            return obj1.CompareTo((object)numericRange.End);
        }

        public override string ToString()=>string.Format("{0},{1}",(object) this.Begin, (object)this.End);
        
        public override bool Equals(object obj)
        {
            if (!(obj is NumericRange<T>))
                return false;
            NumericRange<T> numericRange = obj as NumericRange<T>;
            T obj1 = this.Begin;
            int num;
            if (obj1.Equals((object)numericRange.Begin))
            {
                obj1 = this.End;
                num = obj1.Equals((object)numericRange.End) ? 1 : 0;
            }
            else
                num = 0;
            return num != 0;
        }

        public override int GetHashCode()
        {
            T obj = this.Begin;
            int hashCode1 = obj.GetHashCode();
            obj = this.End;
            int hashCode2 = obj.GetHashCode();
            return hashCode1 + hashCode2;
        }
    }
}