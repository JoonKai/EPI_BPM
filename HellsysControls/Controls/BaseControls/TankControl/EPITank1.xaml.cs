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

namespace HellsysControls.Controls.BaseControls.TankControl
{
    /// <summary>
    /// EPITank1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPITank1 : UserControl
    {


        public int GageValue
        {
            get { return (int)GetValue(GageValueProperty); }
            set { SetValue(GageValueProperty, value); }
        }
        public static readonly DependencyProperty GageValueProperty = DependencyProperty.Register("GageValue", typeof(int), typeof(EPITank1), new PropertyMetadata(0));


        public EPITank1()
        {
            InitializeComponent();
        }
    }
}
