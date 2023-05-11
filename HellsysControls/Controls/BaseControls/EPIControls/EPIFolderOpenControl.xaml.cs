using Microsoft.Win32;
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
    /// EPIFolderOpenControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPIFolderOpenControl : UserControl
    {
        public static readonly DependencyProperty TBWidthProperty = DependencyProperty.Register("TBWidth", typeof(int), typeof(EPIFolderOpenControl), new PropertyMetadata(100));
        public static readonly DependencyProperty THeaderTextProperty = DependencyProperty.Register("THeaderText", typeof(string), typeof(EPIFolderOpenControl), new PropertyMetadata("Default"));
        public static readonly DependencyProperty THeaderWidthProperty = DependencyProperty.Register("THeaderWidth", typeof(int), typeof(EPIFolderOpenControl), new PropertyMetadata(50));
        public static readonly DependencyProperty THeaderColorProperty = DependencyProperty.Register("THeaderColor", typeof(Brush), typeof(EPIFolderOpenControl), new PropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty ItemTextProperty = DependencyProperty.Register("ItemText", typeof(string), typeof(EPIFolderOpenControl), new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public static readonly DependencyProperty TBColorProperty = DependencyProperty.Register("TBColor", typeof(Brush), typeof(EPIFolderOpenControl), new UIPropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty TSemiColonColorProperty = DependencyProperty.Register("TSemiColonColor", typeof(Brush), typeof(EPIFolderOpenControl), new UIPropertyMetadata(Brushes.Black));
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
        public string ItemText
        {
            get { return (string)GetValue(ItemTextProperty); }
            set { SetValue(ItemTextProperty, value); }
        }
        public EPIFolderOpenControl()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {

            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    tbPath.Text = dialog.SelectedPath;
            }
        }
    }
}
