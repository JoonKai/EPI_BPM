using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HellsysControls.Controls.BaseControls.EPIControls
{
    /// <summary>
    /// EPIWaterMarkTextboxControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPIWaterMarkTextboxControl : UserControl
    {
        #region Public statics
        public static new readonly DependencyProperty BorderBrushProperty = DependencyProperty.Register("BorderBrush", typeof(Brush), typeof(EPIWaterMarkTextboxControl), new UIPropertyMetadata(Brushes.White));
        public static new readonly DependencyProperty BorderThicknessProperty = DependencyProperty.Register("BorderThickness", typeof(Thickness), typeof(EPIWaterMarkTextboxControl), new UIPropertyMetadata(new Thickness(0.5)));
        public static readonly DependencyProperty WaterMarkTextProperty = DependencyProperty.Register("WaterMarkText", typeof(string), typeof(EPIWaterMarkTextboxControl), new PropertyMetadata(null));
        public static readonly DependencyProperty WaterMarkTextColorProperty = DependencyProperty.Register("WaterMarkTextColor", typeof(Brush), typeof(EPIWaterMarkTextboxControl), new UIPropertyMetadata(Brushes.Gray));
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(EPIWaterMarkTextboxControl), new FrameworkPropertyMetadata("",FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public static readonly DependencyProperty ValidatingProperty = DependencyProperty.Register("Validating", typeof(bool), typeof(EPIWaterMarkTextboxControl), new UIPropertyMetadata(false));
        public static readonly DependencyProperty TBTextColorProperty = DependencyProperty.Register("TBTextColor", typeof(Brush), typeof(EPIWaterMarkTextboxControl), new UIPropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty TBReadOnlyProperty = DependencyProperty.Register("TBReadOnly", typeof(bool), typeof(EPIWaterMarkTextboxControl), new PropertyMetadata(false));
        public static readonly DependencyProperty TextWrappingProperty = DependencyProperty.Register("TextWrapping", typeof(TextWrapping), typeof(EPIWaterMarkTextboxControl), new UIPropertyMetadata(TextWrapping.NoWrap));
        public static readonly DependencyProperty AcceptsReturnProperty = DependencyProperty.Register("AcceptsReturn", typeof(bool), typeof(EPIWaterMarkTextboxControl), new UIPropertyMetadata(false));
        public static new readonly DependencyProperty HeightProperty = DependencyProperty.Register("Height", typeof(int), typeof(EPIWaterMarkTextboxControl), new PropertyMetadata(20));
        public static new readonly DependencyProperty WidthProperty = DependencyProperty.Register("Width", typeof(int), typeof(EPIWaterMarkTextboxControl), new PropertyMetadata(50));
        public static new readonly DependencyProperty HorizontalContentAlignmentProperty =DependencyProperty.Register("HorizontalContentAlignment", typeof(HorizontalAlignment), typeof(EPIWaterMarkTextboxControl), new UIPropertyMetadata(HorizontalAlignment.Left));
        #endregion

        #region Public Properties



        public new int Width
        {
            get { return (int)GetValue(WidthProperty); }
            set { SetValue(WidthProperty, value); }
        }



        public new int Height
        {
            get { return (int)GetValue(HeightProperty); }
            set { SetValue(HeightProperty, value); }
        }


        public TextWrapping TextWrapping
        {
            get { return (TextWrapping)GetValue(TextWrappingProperty); }
            set { SetValue(TextWrappingProperty, value); }
        }
        public bool AcceptsReturn
        {
            get { return (bool)GetValue(AcceptsReturnProperty); }
            set { SetValue(AcceptsReturnProperty, value); }
        }
        public new HorizontalAlignment HorizontalContentAlignment
        {
            get { return (HorizontalAlignment)GetValue(HorizontalContentAlignmentProperty); }
            set { SetValue(HorizontalContentAlignmentProperty, value); }
        }


        public bool TBReadOnly
        {
            get { return (bool)GetValue(TBReadOnlyProperty); }
            set { SetValue(TBReadOnlyProperty, value); }
        }
        public Brush TBTextColor
        {
            get { return (Brush)GetValue(TBTextColorProperty); }
            set { SetValue(TBTextColorProperty, value); }
        }
        public new Brush BorderBrush
        {
            get { return (Brush)GetValue(BorderBrushProperty); }
            set { SetValue(BorderBrushProperty, value); }
        }
        public new Thickness BorderThickness
        {
            get { return (Thickness)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }
        public string WaterMarkText
        {
            get { return (string)GetValue(WaterMarkTextProperty); }
            set { SetValue(WaterMarkTextProperty, value); }
        }
        public Brush WaterMarkTextColor
        {
            get { return (Brush)GetValue(WaterMarkTextColorProperty); }
            set { SetValue(WaterMarkTextColorProperty, value); }
        }
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public bool Validating
        {
            get { return (bool)GetValue(ValidatingProperty); }
            set { SetValue(ValidatingProperty, value); }
        }
        #endregion
        public EPIWaterMarkTextboxControl()
        {
            InitializeComponent();
        }
        #region Event
        private void baseTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int dummy;
            if(baseTextbox.Text != "" && Int32.TryParse(baseTextbox.Text.ToString(),out dummy))
            {
                Validating = false;
            }
            else
            {
                Validating = true;

            }
        }
        #endregion
    }
}
