using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsysLibrary.Maths
{
    public class NumericRange : NumericRange<double>
    {
        public NumericRange() : this(0.0,0.0)
        {
        }

        public NumericRange(double begin, double end, bool inclusiveBegin = true, bool inclusiveEnd = true) : base(begin, end, inclusiveBegin, inclusiveEnd)
        {
        }
        public double Length => Math.Abs(End - Begin);
        public double Delta => End - Begin;
        public double Middle => (Begin + End) / 2.0;
        public double ConvertTargetPosition(NumericRange target, double base_position)
        {
            double delta = Delta;
            return delta == 0.0 ? target.Begin : (base_position - Begin) / delta * target.Delta + target.Begin;
        }
        public static NumericRange FromBoundary(double boundary1, double boundary2) => new NumericRange(Math.Min(boundary1, boundary2), Math.Max(boundary1, boundary2));
    }
}
