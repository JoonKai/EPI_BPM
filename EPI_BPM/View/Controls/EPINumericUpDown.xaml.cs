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

namespace EPI_BPM.View.Controls
{
    /// <summary>
    /// EPINumericUpDown.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPINumericUpDown : UserControl
    {
        private int numValue = 0;

        public int NumValue
        {
            get { return numValue; }
            set
            {
                numValue = value;
                txtNum.Text = value.ToString();
            }
        }
        public EPINumericUpDown()
        {
            InitializeComponent();
            txtNum.Text = NumValue.ToString();
        }

        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNum == null)
            {
                return;
            }
            if (!int.TryParse(txtNum.Text, out numValue))
                txtNum.Text = numValue.ToString();
        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            NumValue++;
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            if (NumValue > 0)
            {
                NumValue--;
            }
        }
    }
}
