using EPI_BPM.View;
using EPI_BPM.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EPI_BPM.Service
{
    public class ViewService : IViewService
    {
        private readonly IServiceProvider _serviceProvider;

        public ViewService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void ShowView<TView, TViewModel>(object parameter = null)
            where TView : Window
            where TViewModel : INotifyPropertyChanged
        {
            var viewModel = (INotifyPropertyChanged)_serviceProvider.GetService(typeof(TViewModel));
            var view = (Window)_serviceProvider.GetService(typeof(TView));

            if(parameter != null && viewModel is IParameterReceiver parameterReceiver)
            {
                parameterReceiver.ReceiveParameter(parameter);
            }
            view.DataContext = viewModel;
            view.Show();

        }
        public void ShowMainView()
        {
            ShowView<EPIMainView, EPIMainViewModel>();
        }

        public void ShowSettingView()
        {
            if (!ActivateView<EPISettingView>())
            {
                ShowView<EPISettingView, EPISettingViewModel>();
            }
        }

        private bool ActivateView<TView>() where TView : Window
        {
            IEnumerable<Window> windows = Application.Current.Windows.OfType<TView>(); //현재 실행되어 있는 윈도우들을 불러옴

            if(windows.Any())
            {
                windows.ElementAt(0).Activate();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
