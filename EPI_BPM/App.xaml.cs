using EPI_BPM.Service;
using EPI_BPM.View;
using EPI_BPM.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace EPI_BPM
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _services=null;
        //...
        public App()
        {
            _services = ConfigurationService();
        }
        private IServiceProvider ConfigurationService()
        {
            IServiceCollection services = new ServiceCollection();

            //View
            services.AddSingleton<EPIMainView>();
            services.AddTransient<EPISettingView>();

            //Service
            services.AddSingleton<IViewService, ViewService>();

            //ViewModel
            services.AddSingleton<EPIMainViewModel>();
            services.AddTransient<EPISettingViewModel>();

            return services.BuildServiceProvider();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var viewService = (IViewService)_services.GetService(typeof(IViewService));
            viewService.ShowMainView();
        }
    }
}
