using HellsysLibrary.Maths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellsysControls.Controls.MapControls
{
    public class MapRange : NumericRange
    {

        public bool UseAutoRange { get; set; }
        public bool UseDistribution { get; set; }
        public List<long> Distributions { get; set; }
        public bool IgnoreOutOfRange { get; set; }
        public event Action<MapRange> RangeChanged;
        public MapRange()
        {
            UseAutoRange = true;
            UseDistribution= true;
            Distributions = new List<long>();
            IgnoreOutOfRange = false;
        }
        public void SetHistogram(List<long> histogram)
        {
            lock (this)
            {
                List<long> distributions = Distributions;
                distributions.Clear();
                distributions.AddRange((IEnumerable<long>) histogram);
            }
        }
        public NumericRange GetHistogramRange(int index)
        {
            if(index <0 || index >= Distributions.Count)
            {
                return (NumericRange)null;
            }
            lock (this)
            {
                int count = Distributions.Count;
                if(count <= 1)
                {
                    return new NumericRange(Begin, End);
                }
                double num = Delta / count;
                return new NumericRange(Begin + num * index, Begin + num * (index + 1));
            }
        }
        public void Distribute(int distributions, List<double> items)
        {
            lock (this)
            {
                List<long> distributions1 = Distributions;
                distributions1.Clear();
                if(items.Count == 0)
                {
                    return;
                }
                if (UseAutoRange)
                {
                    items.Sort();
                    Begin = items[items.Count * 125 / 1000];
                    End = items[items.Count * 875 / 1000];
                }
                if(!UseDistribution)
                {
                    return;
                }
                double num1 = Delta;
                if(num1 == 0.0)
                {
                    num1 = 1.0;
                }
                double num2 = num1 / (double)distributions;
                int val1 = distributions - 1;
                for(int index =0; index<distributions; index++)
                {
                    distributions1.Add(0L);
                }
                for (int index = 0; index < distributions; ++index)
                    distributions1.Add(0L);
                foreach (double d in items)
                {
                    if (!double.IsNaN(d) && !double.IsInfinity(d) && (!this.IgnoreOutOfRange || d >= this.Begin && d <= this.End))
                    {
                        int index = (int)Math.Max(0.0, Math.Min((double)val1, (d - this.Begin) / num2));
                        ++distributions1[index];
                    }
                }
            }
        }
        public virtual void Distribute(int distributions, List<byte> items, bool ignoreOutOfRange = false)
        {
            lock (this)
            {
                List<long> distributions1 = this.Distributions;
                distributions1.Clear();
                if (items.Count == 0)
                    return;
                if (this.UseAutoRange)
                {
                    items.Sort();
                    this.Begin = (double)items[items.Count * 125 / 1000];
                    this.End = (double)items[items.Count * 875 / 1000];
                }
                if (!this.UseDistribution)
                    return;
                double num1 = this.Delta;
                if (num1 == 0.0)
                    num1 = 1.0;
                double num2 = num1 / (double)distributions;
                int val1 = distributions - 1;
                for (int index = 0; index < distributions; ++index)
                    distributions1.Add(0L);
                foreach (byte d in items)
                {
                    if (!double.IsNaN((double)d) && !double.IsInfinity((double)d) && (!ignoreOutOfRange || (double)d >= this.Begin && (double)d <= this.End))
                    {
                        int index = (int)Math.Max(0.0, Math.Min((double)val1, ((double)d - this.Begin) / num2));
                        ++distributions1[index];
                    }
                }
            }
        }
    }
}
