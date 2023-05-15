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
    /// EPITextItemControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPITextItemControl : UserControl
    {
        #region Dependency Properties
        public static readonly DependencyProperty THeaderTextProperty = DependencyProperty.Register("THeaderText", typeof(string), typeof(EPITextItemControl), new PropertyMetadata(null));
        public static readonly DependencyProperty THeaderWidthProperty = DependencyProperty.Register("THeaderWidth", typeof(int), typeof(EPITextItemControl), new PropertyMetadata(50));
        public static readonly DependencyProperty THeaderColorProperty = DependencyProperty.Register("THeaderColor", typeof(Brush), typeof(EPITextItemControl), new PropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty TBTextProperty =DependencyProperty.Register("TBText", typeof(string), typeof(EPITextItemControl), new FrameworkPropertyMetadata("",FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public static readonly DependencyProperty WaterTextProperty = DependencyProperty.Register("WaterText", typeof(string), typeof(EPITextItemControl), new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public static readonly DependencyProperty TBColorProperty = DependencyProperty.Register("TBColor", typeof(Brush), typeof(EPITextItemControl), new UIPropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty TSemiColonColorProperty =  DependencyProperty.Register("TSemiColonColor", typeof(Brush), typeof(EPITextItemControl), new UIPropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty TBReadOnlyProperty = DependencyProperty.Register("TBReadOnly", typeof(bool), typeof(EPITextItemControl), new PropertyMetadata(false));
        public static new readonly DependencyProperty HorizontalContentAlignmentProperty = DependencyProperty.Register("HorizontalContentAlignment", typeof(HorizontalAlignment), typeof(EPITextItemControl), new UIPropertyMetadata(HorizontalAlignment.Left));
        public static readonly DependencyProperty TBTextWrappingProperty = DependencyProperty.Register("TBTextWrapping", typeof(TextWrapping), typeof(EPITextItemControl), new UIPropertyMetadata(TextWrapping.NoWrap));
        public static readonly DependencyProperty TBAcceptsReturnProperty = DependencyProperty.Register("TBAcceptsReturn", typeof(bool), typeof(EPITextItemControl), new UIPropertyMetadata(false));
        public static readonly DependencyProperty TBHeightProperty = DependencyProperty.Register("TBHeight", typeof(int), typeof(EPITextItemControl), new PropertyMetadata(20));
        public static readonly DependencyProperty TBWidthProperty = DependencyProperty.Register("TBWidth", typeof(int), typeof(EPITextItemControl), new PropertyMetadata(50));





        public string WaterText
        {
            get { return (string)GetValue(WaterTextProperty); }
            set { SetValue(WaterTextProperty, value); }
        }



        public int TBHeight
        {
            get { return (int)GetValue(TBHeightProperty); }
            set { SetValue(TBHeightProperty, value); }
        }
        public int TBWidth
        {
            get { return (int)GetValue(TBWidthProperty); }
            set { SetValue(TBWidthProperty, value); }
        }
        public bool TBAcceptsReturn
        {
            get { return (bool)GetValue(TBAcceptsReturnProperty); }
            set { SetValue(TBAcceptsReturnProperty, value); }
        }

        public TextWrapping TBTextWrapping
        {
            get { return (TextWrapping)GetValue(TBTextWrappingProperty); }
            set { SetValue(TBTextWrappingProperty, value); }
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
        public Brush TSemiColonColor
        {
            get { return (Brush)GetValue(TSemiColonColorProperty); }
            set { SetValue(TSemiColonColorProperty, value); }
        }
        public Brush TBColor
        {
            get { return (Brush)GetValue(TBColorProperty); }
            set { SetValue(TBColorProperty, value); }
        }
        public Brush THeaderColor
        {
            get { return (Brush)GetValue(THeaderColorProperty); }
            set { SetValue(THeaderColorProperty, value); }
        }
        public string THeaderText
        {
            get { return (string)GetValue(THeaderTextProperty); }
            set { SetValue(THeaderTextProperty, value); }
        }
        public int THeaderWidth
        {
            get { return (int)GetValue(THeaderWidthProperty); }
            set { SetValue(THeaderWidthProperty, value); }
        }
        
        public string TBText
        {
            get { return (string)GetValue(TBTextProperty); }
            set { SetValue(TBTextProperty, value); }
        }


        #endregion
        public EPITextItemControl()
        {
            InitializeComponent();
        }
    }
}
