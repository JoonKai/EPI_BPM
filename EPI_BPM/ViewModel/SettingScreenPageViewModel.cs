using EPI_BPM.Commands;
using EPI_BPM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace EPI_BPM.ViewModel
{
    public class SettingScreenPageViewModel : ViewModelBase
    {
        DatabaseSettingItem dbsetting = new DatabaseSettingItem();
        public string DBPath 
        {
            get => dbsetting.DBPath;
            set
            {
                dbsetting.DBPath = value;
                OnPropertyChanged(nameof(DBPath));
            }
        }
        public ICommand saveCommand => new RelayCommand<string>(SaveIni);
        public ICommand loadCommand => new RelayCommand<string>(LoadIni);

        private void LoadIni(string obj)
        {
            
        }

        private void SaveIni(string obj)
        {
            DBPath = "손준석";
            MessageBox.Show(DBPath);
        }
    }
}
