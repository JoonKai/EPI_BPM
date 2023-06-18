using EPI_BPM.Commands;
using EPI_BPM.View.Screen;
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
            SettingWindow settingView = new SettingWindow();
            settingView.ShowDialog();

        }
    }
}
