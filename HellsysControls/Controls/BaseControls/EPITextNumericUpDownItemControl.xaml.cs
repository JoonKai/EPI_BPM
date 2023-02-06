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

namespace HellsysControls.Controls.BaseControls
{
    /// <summary>
    /// EPITextNumericUpDownItemControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPITextNumericUpDownItemControl : UserControl
    {
        #region Dependency Properties

        public static readonly DependencyProperty THeaderTextProperty = DependencyProperty.Register("THeaderText", typeof(string), typeof(EPITextNumericUpDownItemControl), new PropertyMetadata(null));
        public static readonly DependencyProperty THeaderWidthProperty = DependencyProperty.Register("THeaderWidth", typeof(int), typeof(EPITextNumericUpDownItemControl), new PropertyMetadata(50));
        public static readonly DependencyProperty TBWidthProperty = DependencyProperty.Register("TBWidth", typeof(int), typeof(EPITextNumericUpDownItemControl), new PropertyMetadata(50));
        public static readonly DependencyProperty THeaderColorProperty = DependencyProperty.Register("THeaderColor", typeof(Brush), typeof(EPITextNumericUpDownItemControl), new UIPropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty TSemiColonColorProperty = DependencyProperty.Register("TSemiColonColor", typeof(Brush), typeof(EPITextNumericUpDownItemControl), new UIPropertyMetadata(Brushes.Black));




        public Brush TSemiColonColor
        {
            get { return (Brush)GetValue(TSemiColonColorProperty); }
            set { SetValue(TSemiColonColorProperty, value); }
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
        public int TBWidth
        {
            get { return (int)GetValue(TBWidthProperty); }
            set { SetValue(TBWidthProperty, value); }
        }




        #endregion
        public EPITextNumericUpDownItemControl()
        {
            InitializeComponent();
        }
    }
}
