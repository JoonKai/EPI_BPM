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
    public class EPIMainViewModel : ViewModelBase
    {
        private readonly IViewService _viewService;
        public EPIMainViewModel(IViewService viewService)
        {
            _viewService = viewService;
        }
    }
}
