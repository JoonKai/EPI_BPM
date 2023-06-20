using System;
using System.Windows;
using WinInterop = System.Windows.Interop;

namespace EPI_BPM.View
{
    /// <summary>
    /// EPIMainView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPIMainView : Window
    {
        public EPIMainView()
        {
            InitializeComponent();
            this.SourceInitialized += MainView_SourceInitialized;
        }

        private void MainView_SourceInitialized(object sender, EventArgs e)
        {
            System.IntPtr handle = (new WinInterop.WindowInteropHelper(this)).Handle;
            WinInterop.HwndSource.FromHwnd(handle).AddHook(new WinInterop.HwndSourceHook(WindowMaximizeManager.WindowProc));
        }
    }
}
