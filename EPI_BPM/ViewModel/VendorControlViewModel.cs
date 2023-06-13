using EPI_BPM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EPI_BPM.ViewModel
{
    public class VendorControlViewModel
    {
        public ObservableCollection<Vendor> Vendors { get; set; }
        public ICommand AddCommand { get; set; }

        public VendorControlViewModel()
        {
            Vendors = VendorManager.GetVendors();
        }
    }
}
