using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace EPI_BPM.Service
{
    public interface IViewService
    {
        void ShowView<TView, TViewModel>(object parameter = null) 
            where TView : Window 
            where TViewModel : INotifyPropertyChanged;

        void ShowUserControl<TView, TViewModel>(object parameter = null) 
            where TView : UserControl 
            where TViewModel : INotifyPropertyChanged;
        void ShowMainView();
        //void ShowSettingView(SubData subData);
        void ShowSettingView();

    }
}
