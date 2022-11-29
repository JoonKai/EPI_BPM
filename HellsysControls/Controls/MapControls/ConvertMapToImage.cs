using HellsysControls.ColorConverters;
using System;
using System.Diagnostics;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HellsysControls.Controls.MapControls
{
    public class ConvertMapToImage
    {

        public int PixelWidth { get; set; }
        public int PixelHeight { get; set; }
        public Func<object, double> Getter;
        public string DisplayItemName { get; set; }
        public IColorConverter ColorConverter { get; set; }
        public MapRange Range { get; set; }
        public Color BackgroundColor { get; set; }
        WriteableBitmap WBitmap { get; set; }
        int LastSetPixelWidth { get; set; }
        int LastSetPixelHeight { get; set; }
        string LastSetDisplayItemName { get; set; }
        public ConvertMapToImage()
        {
            PixelWidth = 1;
            PixelHeight = 1;
            LastSetDisplayItemName = null;
            DisplayItemName = null;
            BackgroundColor = Colors.White;
            Getter = null;
            Range = new MapRange();
            ColorConverter = new PredefinedColorGradientConverter():
        }
        

    }
}
