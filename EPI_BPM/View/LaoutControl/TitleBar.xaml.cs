using HellsysLibrary.Extensions;
using System.Windows;
using System.Windows.Controls;
using WinInterop = System.Windows.Interop;

namespace EPI_BPM.View.LaoutControl
{
    /// <summary>
    /// TitleBar.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TitleBar : UserControl
    {
        private Window _parentWindow;


        public Window ParentWindow
        {
            get 
            {
                if(_parentWindow == null)
                {
                    _parentWindow = this.FindParent<Window>();
                }
                return _parentWindow; 
            }
            set { _parentWindow = value; }
        }

        public TitleBar()
        {
            InitializeComponent();
            btnExit.Click += BtnExit_Click;
            btnMinimize.Click += BtnMinimize_Click;
            btnMaximize.Click += BtnMaximize_Click;
        }

        private void BtnMaximize_Click(object sender, RoutedEventArgs e)
        {
            
            ParentWindow.WindowState=ParentWindow.WindowState == WindowState.Maximized
                ?WindowState.Normal 
                :WindowState.Maximized;
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {

            ParentWindow.WindowState = WindowState.Minimized;
            ParentWindow.ResizeMode = ResizeMode.CanResizeWithGrip;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            ParentWindow.Close();

        }
    }
}
