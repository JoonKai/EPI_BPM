using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace HellsysControls.ColorConverters
{
    interface IColorConverter
    {
        Color ValueToColor(double begin, double end, double value);
        double ColorToValue(double begin, double end, Color value);
        void SetColors(IEnumerable<Color> colors);
        IEnumerable<Color> GetColors();
    }
}
