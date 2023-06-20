using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EPI_BPM.Service
{
    public interface IViewService
    {
        void ShowView<TView, TViewModel>(object parameter = null) 
            where TView : Window 
            where TViewModel : INotifyPropertyChanged;
        void ShowMainView();
        //void ShowSettingView(SubData subData);
        void ShowSettingView();

    }
}
