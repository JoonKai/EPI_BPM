using EPI_BPM.Commands;
using EPI_BPM.Service;
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
        //public ICommand ShowEPISettingViewCommand => new RelayCommand<object>(ShowSettingView);
        private readonly IViewService _viewService;

        public MainPageViewModel()
        {
            
        }
        //private void ShowSettingView(object obj)
        //{
        //    _viewService.ShowSettingView();
        //}
    }
}
