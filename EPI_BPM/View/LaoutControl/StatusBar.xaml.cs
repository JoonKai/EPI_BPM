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

namespace EPI_BPM.View.LaoutControl
{
    /// <summary>
    /// StatusBar.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class StatusBar : UserControl
    {


        public DateTime DigitalTime
        {
            get { return (DateTime)GetValue(DigitalTimeProperty); }
            set { SetValue(DigitalTimeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DigitalTime.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DigitalTimeProperty =
            DependencyProperty.Register("DigitalTime", typeof(DateTime), typeof(StatusBar), new FrameworkPropertyMetadata(DateTime.Now));


        public StatusBar()
        {
            InitializeComponent();
        }
    }
}
