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
    /// EPITank2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPITank2 : UserControl
    {

        public static readonly DependencyProperty GageValueProperty = DependencyProperty.Register("GageValue", typeof(int), typeof(EPITank2), new PropertyMetadata(0));

        public int GageValue
        {
            get { return (int)GetValue(GageValueProperty); }
            set { SetValue(GageValueProperty, value); }
        }


        public EPITank2()
        {
            InitializeComponent();
        }
    }
}
