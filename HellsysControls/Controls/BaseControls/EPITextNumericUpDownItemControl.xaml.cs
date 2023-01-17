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


        public string NHeaderText
        {
            get { return (string)GetValue(NHeaderTextProperty); }
            set { SetValue(NHeaderTextProperty, value); }
        }
        public static readonly DependencyProperty NHeaderTextProperty = DependencyProperty.Register("NHeaderText", typeof(string), typeof(EPITextNumericUpDownItemControl), new PropertyMetadata(null));


        #endregion
        public EPITextNumericUpDownItemControl()
        {
            InitializeComponent();
        }
    }
}
