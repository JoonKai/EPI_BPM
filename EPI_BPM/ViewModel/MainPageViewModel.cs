using EPI_BPM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EPI_BPM.ViewModel
{
    public class MainPageViewModel
    {
        public ICommand ShowSettingViewCommand { get; set; }
        public MainPageViewModel()
        {
            ShowSettingViewCommand = new RelayCommand<object>(ShowSetting, CanShowSetting);
        }

        private bool CanShowSetting(object obj)
        {
            return true;
        }

        private void ShowSetting(object obj)
        {
            //var mainWindow = (EPIMainWindow)obj;

            SettingWindow settingView = new SettingWindow();
            //settingView.Owner = mainWindow;
            settingView.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            settingView.ShowDialog();

        }
    }
}
