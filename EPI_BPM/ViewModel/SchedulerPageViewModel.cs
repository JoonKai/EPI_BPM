using EPI_BPM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPI_BPM.ViewModel
{
    public class SchedulerPageViewModel : ViewModelBase
    {
        private List<PMCategory> pmCategory = default;

        public List<PMCategory> PMCategories { get=>pmCategory; set { pmCategory = value;OnPropertyChanged();}}

        public SchedulerPageViewModel()
        {
            PMCategories = PMCategory.PMCategories;
        }
    }
}
